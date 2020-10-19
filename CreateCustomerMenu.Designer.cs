namespace TClients
{
    partial class CreateCustomerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerMidleNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(77, 32);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.customerFirstNameTextBox.TabIndex = 2;
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerLastNameTextBox.Location = new System.Drawing.Point(77, 6);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.customerLastNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // customerMidleNameTextBox
            // 
            this.customerMidleNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerMidleNameTextBox.Location = new System.Drawing.Point(77, 58);
            this.customerMidleNameTextBox.Name = "customerMidleNameTextBox";
            this.customerMidleNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.customerMidleNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество:";
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerPhoneTextBox.Location = new System.Drawing.Point(77, 84);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(145, 20);
            this.customerPhoneTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон:";
            // 
            // createCustomerButton
            // 
            this.createCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createCustomerButton.BackColor = System.Drawing.Color.DarkGray;
            this.createCustomerButton.FlatAppearance.BorderSize = 0;
            this.createCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCustomerButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createCustomerButton.ForeColor = System.Drawing.Color.White;
            this.createCustomerButton.Location = new System.Drawing.Point(12, 110);
            this.createCustomerButton.Name = "createCustomerButton";
            this.createCustomerButton.Size = new System.Drawing.Size(210, 23);
            this.createCustomerButton.TabIndex = 5;
            this.createCustomerButton.Text = "Зарегистрировать";
            this.createCustomerButton.UseVisualStyleBackColor = false;
            this.createCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // CreateCustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(234, 145);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerLastNameTextBox);
            this.Controls.Add(this.createCustomerButton);
            this.Controls.Add(this.customerPhoneTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerMidleNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerFirstNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateCustomerMenu";
            this.Text = "Регистрация клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerMidleNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createCustomerButton;
    }
}