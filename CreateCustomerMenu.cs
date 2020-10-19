using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TClients.CustomerInteraction;
using TClients.Properties;

namespace TClients
{
    public partial class CreateCustomerMenu : Form
    {
        private int m_newId;

        public CreateCustomerMenu()
        {
            InitializeComponent();
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(customerFirstNameTextBox.Text) || string.IsNullOrWhiteSpace(customerLastNameTextBox.Text) || string.IsNullOrWhiteSpace(customerPhoneTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            CustomerManager.Customers.Add(new Customer(CustomerManager.Customers.Count == 0 ? 0: m_newId = CustomerManager.Customers.Max(customer => customer.Id) + 1, customerFirstNameTextBox.Text, customerMidleNameTextBox.Text, customerLastNameTextBox.Text, customerPhoneTextBox.Text));

            File.Create($"{Settings.Default.servicesPath}/{m_newId}.xml").Close();

            Close();
        }
    }
}