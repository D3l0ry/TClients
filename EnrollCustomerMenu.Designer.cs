namespace TClients
{
    partial class EnrollCustomerMenu
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.midleNameLabel = new System.Windows.Forms.Label();
            this.purposeVisitLabel = new System.Windows.Forms.Label();
            this.purposeVisitTextBox = new System.Windows.Forms.TextBox();
            this.dateVisitCalendar = new System.Windows.Forms.MonthCalendar();
            this.dateVisitLabel = new System.Windows.Forms.Label();
            this.enrollVisitButton = new System.Windows.Forms.Button();
            this.priceVisitLabel = new System.Windows.Forms.Label();
            this.priceVisitTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Имя:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 31);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // midleNameLabel
            // 
            this.midleNameLabel.AutoSize = true;
            this.midleNameLabel.Location = new System.Drawing.Point(12, 53);
            this.midleNameLabel.Name = "midleNameLabel";
            this.midleNameLabel.Size = new System.Drawing.Size(57, 13);
            this.midleNameLabel.TabIndex = 2;
            this.midleNameLabel.Text = "Отчество:";
            // 
            // purposeVisitLabel
            // 
            this.purposeVisitLabel.AutoSize = true;
            this.purposeVisitLabel.Location = new System.Drawing.Point(12, 72);
            this.purposeVisitLabel.Name = "purposeVisitLabel";
            this.purposeVisitLabel.Size = new System.Drawing.Size(74, 13);
            this.purposeVisitLabel.TabIndex = 3;
            this.purposeVisitLabel.Text = "Цель визита:";
            // 
            // purposeVisitTextBox
            // 
            this.purposeVisitTextBox.Location = new System.Drawing.Point(92, 69);
            this.purposeVisitTextBox.Multiline = true;
            this.purposeVisitTextBox.Name = "purposeVisitTextBox";
            this.purposeVisitTextBox.Size = new System.Drawing.Size(230, 48);
            this.purposeVisitTextBox.TabIndex = 4;
            // 
            // dateVisitCalendar
            // 
            this.dateVisitCalendar.Location = new System.Drawing.Point(158, 156);
            this.dateVisitCalendar.MaxSelectionCount = 1;
            this.dateVisitCalendar.Name = "dateVisitCalendar";
            this.dateVisitCalendar.TabIndex = 5;
            // 
            // dateVisitLabel
            // 
            this.dateVisitLabel.AutoSize = true;
            this.dateVisitLabel.Location = new System.Drawing.Point(12, 156);
            this.dateVisitLabel.Name = "dateVisitLabel";
            this.dateVisitLabel.Size = new System.Drawing.Size(74, 13);
            this.dateVisitLabel.TabIndex = 6;
            this.dateVisitLabel.Text = "Дата визита:";
            // 
            // enrollVisitButton
            // 
            this.enrollVisitButton.BackColor = System.Drawing.Color.DarkGray;
            this.enrollVisitButton.FlatAppearance.BorderSize = 0;
            this.enrollVisitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrollVisitButton.ForeColor = System.Drawing.Color.White;
            this.enrollVisitButton.Location = new System.Drawing.Point(12, 295);
            this.enrollVisitButton.Name = "enrollVisitButton";
            this.enrollVisitButton.Size = new System.Drawing.Size(134, 23);
            this.enrollVisitButton.TabIndex = 7;
            this.enrollVisitButton.Text = "Записать";
            this.enrollVisitButton.UseVisualStyleBackColor = false;
            this.enrollVisitButton.Click += new System.EventHandler(this.EnrollVisitButton_Click);
            // 
            // priceVisitLabel
            // 
            this.priceVisitLabel.AutoSize = true;
            this.priceVisitLabel.Location = new System.Drawing.Point(12, 126);
            this.priceVisitLabel.Name = "priceVisitLabel";
            this.priceVisitLabel.Size = new System.Drawing.Size(36, 13);
            this.priceVisitLabel.TabIndex = 8;
            this.priceVisitLabel.Text = "Цена:";
            // 
            // priceVisitTextBox
            // 
            this.priceVisitTextBox.Location = new System.Drawing.Point(92, 123);
            this.priceVisitTextBox.Multiline = true;
            this.priceVisitTextBox.Name = "priceVisitTextBox";
            this.priceVisitTextBox.Size = new System.Drawing.Size(230, 21);
            this.priceVisitTextBox.TabIndex = 9;
            // 
            // EnrollCustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 336);
            this.Controls.Add(this.priceVisitTextBox);
            this.Controls.Add(this.priceVisitLabel);
            this.Controls.Add(this.enrollVisitButton);
            this.Controls.Add(this.dateVisitLabel);
            this.Controls.Add(this.dateVisitCalendar);
            this.Controls.Add(this.purposeVisitTextBox);
            this.Controls.Add(this.purposeVisitLabel);
            this.Controls.Add(this.midleNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnrollCustomerMenu";
            this.Text = "Записать клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label midleNameLabel;
        private System.Windows.Forms.Label purposeVisitLabel;
        private System.Windows.Forms.TextBox purposeVisitTextBox;
        private System.Windows.Forms.MonthCalendar dateVisitCalendar;
        private System.Windows.Forms.Label dateVisitLabel;
        private System.Windows.Forms.Button enrollVisitButton;
        private System.Windows.Forms.Label priceVisitLabel;
        private System.Windows.Forms.TextBox priceVisitTextBox;
    }
}