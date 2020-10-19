using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

using TClients.CustomerInteraction;
using TClients.Properties;

namespace TClients
{
    public partial class EnrollCustomerMenu : Form
    {
        private int m_Id;

        public EnrollCustomerMenu(int id, string firstNameLabel, string lastNameLabel, string midleNameLabel)
        {
            InitializeComponent();

            m_Id = id;
            this.firstNameLabel.Text += firstNameLabel;
            this.lastNameLabel.Text += lastNameLabel;
            this.midleNameLabel.Text += midleNameLabel;
        }

        private void EnrollVisitButton_Click(object sender, EventArgs e)
        {
            CustomerManager.CustomerServices.Add(new CustomerService(m_Id, purposeVisitTextBox.Text, int.TryParse(priceVisitTextBox.Text, out int result) ? result : 0, dateVisitCalendar.SelectionRange.Start, "Записан"));

            XmlSerializer serviceSerializer = new XmlSerializer(typeof(CustomerService[]));

            if (!File.Exists($"{Settings.Default.servicesPath}/{m_Id}.xml"))
            {
                File.Create($"{Settings.Default.servicesPath}/{m_Id}.xml").Close();
            }

            using (FileStream clientServiceFile = new FileStream($"{Settings.Default.servicesPath}/{m_Id}.xml", FileMode.Truncate, FileAccess.Write))
            {
                serviceSerializer.Serialize(clientServiceFile, CustomerManager.CustomerServices.ToArray());
            }

            Close();
            Dispose();
        }
    }
}