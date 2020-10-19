using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

using TClients.CustomerInteraction;
using TClients.Properties;

namespace TClients
{
    public partial class ServiceMenu : Form
    {
        private int m_customerId;
        public ServiceMenu(int customerId, string lfmName)
        {
            InitializeComponent();

            m_customerId = customerId;
            Text += lfmName;
            titleService.DataSource = Settings.Default.serviceTitle;
            serviceDataView.DataSource = CustomerManager.CustomerServices.ToArray();
        }

        private void ServiceMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Customer customer = CustomerManager.Customers.Where(X => X.Id == m_customerId).First();
            CustomerService[] services = CustomerManager.CustomerServices.ToArray();

            XmlSerializer serviceSerializer = new XmlSerializer(typeof(CustomerService[]));

            using (FileStream clientServiceFile = new FileStream($"{Settings.Default.servicesPath}/{m_customerId}.xml", FileMode.Truncate, FileAccess.Write))
            {
                serviceSerializer.Serialize(clientServiceFile, CustomerManager.CustomerServices.ToArray());
            }

            CustomerService lastService = services.Where(X => X.Status == "Выполнен").LastOrDefault();

            if (lastService != null)
            {
                customer.LastVisit = lastService.Date;
            }

            DataGridViewRow currentRow = Program.menu.customerDataView.CurrentRow;

            Program.menu.customerDataView.UpdateCellValue(currentRow.Cells.Count - 1, currentRow.Index);

            Dispose();
        }
    }
}