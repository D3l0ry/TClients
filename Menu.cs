using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

using TClients.CustomerInteraction;
using TClients.Properties;

namespace TClients
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            XmlSerializer customerSerializer = new XmlSerializer(typeof(Customer[]));

            if (!Directory.Exists(Settings.Default.servicesPath))
            {
                Directory.CreateDirectory(Settings.Default.servicesPath);
            }

            using (FileStream clientFile = new FileStream("clients.xml", FileMode.OpenOrCreate,FileAccess.Read))
            {
                if(clientFile.Length == 0)
                {
                    return;
                }

                try
                {
                    CustomerManager.Customers.AddRange(customerSerializer.Deserialize(clientFile) as Customer[]);
                }
                catch(Exception ex)
                {
                    using (StreamWriter reportFile = new StreamWriter("report.bug"))
                    {
                        reportFile.WriteLine(ex.Message);
                    }
                }
            }

            customerDataView.DataSource = CustomerManager.Customers.ToArray();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            XmlSerializer customerSerializer = new XmlSerializer(typeof(Customer[]));

            using (FileStream clientFile = new FileStream("clients.xml", FileMode.Truncate, FileAccess.Write))
            {
                customerSerializer.Serialize(clientFile, CustomerManager.Customers.ToArray());
            }
        }

        private void CustomerCreateMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new CreateCustomerMenu().ShowDialog();

            if (result == DialogResult.Cancel)
            {
                customerDataView.DataSource = CustomerManager.Customers.ToArray();
            }
        }

        private void EnrollCustomerServiceMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = customerDataView.CurrentRow.Cells;
            XmlSerializer serviceSerializer = new XmlSerializer(typeof(CustomerService[]));

            CustomerManager.CustomerServices.Clear();
            using (FileStream serviceFile = new FileStream($"{Settings.Default.servicesPath}/{cells[0].Value}.xml", FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (serviceFile.Length != 0)
                {
                    try
                    {
                        CustomerManager.CustomerServices.AddRange(serviceSerializer.Deserialize(serviceFile) as CustomerService[]);
                    }
                    catch (Exception ex)
                    {
                        using (StreamWriter reportFile = new StreamWriter("report.bug"))
                        {
                            reportFile.WriteLine(ex.Message);
                        }
                    }
                }
            }

            new EnrollCustomerMenu((int)cells[0].Value, cells[2].Value as string, cells[1].Value as string, cells[3].Value as string).ShowDialog();
        }

        private void HistoryCustomerVisitMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = customerDataView.CurrentRow.Cells;

            XmlSerializer serviceSerializer = new XmlSerializer(typeof(CustomerService[]));

            using (FileStream serviceFile = new FileStream($"{Settings.Default.servicesPath}/{cells[0].Value}.xml", FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (serviceFile.Length == 0)
                {
                    return;
                }

                try
                {
                    CustomerManager.CustomerServices.Clear();
                    CustomerManager.CustomerServices.AddRange(serviceSerializer.Deserialize(serviceFile) as CustomerService[]);
                }
                catch (Exception ex)
                {
                    using (StreamWriter reportFile = new StreamWriter("report.bug"))
                    {
                        reportFile.WriteLine(ex.Message);
                    }
                }
            }

            new ServiceMenu((int)cells[0].Value, $"{(string)cells[3].Value} {(string)cells[1].Value} {(string)cells[2].Value}").ShowDialog();
        }
    }
}