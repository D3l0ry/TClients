namespace TClients
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.customerDataView = new System.Windows.Forms.DataGridView();
            this.clientDataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataMidleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataLastVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customerServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollCustomerServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyCustomerVisitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerCreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataView)).BeginInit();
            this.CustomerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDataView
            // 
            this.customerDataView.AllowUserToAddRows = false;
            this.customerDataView.BackgroundColor = System.Drawing.Color.White;
            this.customerDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientDataId,
            this.clientDataLastName,
            this.clientDataFirstName,
            this.clientDataMidleName,
            this.customerPhoneNumber,
            this.clientDataLastVisit});
            this.customerDataView.ContextMenuStrip = this.CustomerMenuStrip;
            this.customerDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.customerDataView.Location = new System.Drawing.Point(0, 0);
            this.customerDataView.MultiSelect = false;
            this.customerDataView.Name = "customerDataView";
            this.customerDataView.Size = new System.Drawing.Size(800, 450);
            this.customerDataView.TabIndex = 1;
            // 
            // clientDataId
            // 
            this.clientDataId.DataPropertyName = "Id";
            this.clientDataId.HeaderText = "Код";
            this.clientDataId.Name = "clientDataId";
            this.clientDataId.ReadOnly = true;
            // 
            // clientDataLastName
            // 
            this.clientDataLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientDataLastName.DataPropertyName = "LastName";
            this.clientDataLastName.HeaderText = "Фамилия";
            this.clientDataLastName.Name = "clientDataLastName";
            // 
            // clientDataFirstName
            // 
            this.clientDataFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientDataFirstName.DataPropertyName = "FirstName";
            this.clientDataFirstName.HeaderText = "Имя";
            this.clientDataFirstName.Name = "clientDataFirstName";
            // 
            // clientDataMidleName
            // 
            this.clientDataMidleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientDataMidleName.DataPropertyName = "MidleName";
            this.clientDataMidleName.HeaderText = "Отчество";
            this.clientDataMidleName.Name = "clientDataMidleName";
            // 
            // customerPhoneNumber
            // 
            this.customerPhoneNumber.DataPropertyName = "PhoneNumber";
            this.customerPhoneNumber.HeaderText = "Номер телефона";
            this.customerPhoneNumber.Name = "customerPhoneNumber";
            // 
            // clientDataLastVisit
            // 
            this.clientDataLastVisit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientDataLastVisit.DataPropertyName = "LastVisit";
            this.clientDataLastVisit.HeaderText = "Последний визит";
            this.clientDataLastVisit.Name = "clientDataLastVisit";
            this.clientDataLastVisit.ReadOnly = true;
            // 
            // CustomerMenuStrip
            // 
            this.CustomerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerServiceMenuItem,
            this.customerCreateMenuItem});
            this.CustomerMenuStrip.Name = "CustomerMenuStrip";
            this.CustomerMenuStrip.Size = new System.Drawing.Size(205, 48);
            // 
            // customerServiceMenuItem
            // 
            this.customerServiceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollCustomerServiceMenuItem,
            this.historyCustomerVisitMenuItem});
            this.customerServiceMenuItem.Name = "customerServiceMenuItem";
            this.customerServiceMenuItem.Size = new System.Drawing.Size(204, 22);
            this.customerServiceMenuItem.Text = "Обслуживание клиента";
            // 
            // enrollCustomerServiceMenuItem
            // 
            this.enrollCustomerServiceMenuItem.Name = "enrollCustomerServiceMenuItem";
            this.enrollCustomerServiceMenuItem.Size = new System.Drawing.Size(224, 22);
            this.enrollCustomerServiceMenuItem.Text = "Записать на обслуживание";
            this.enrollCustomerServiceMenuItem.Click += new System.EventHandler(this.EnrollCustomerServiceMenuItem_Click);
            // 
            // historyCustomerVisitMenuItem
            // 
            this.historyCustomerVisitMenuItem.Name = "historyCustomerVisitMenuItem";
            this.historyCustomerVisitMenuItem.Size = new System.Drawing.Size(224, 22);
            this.historyCustomerVisitMenuItem.Text = "История визитов";
            this.historyCustomerVisitMenuItem.Click += new System.EventHandler(this.HistoryCustomerVisitMenuItem_Click);
            // 
            // customerCreateMenuItem
            // 
            this.customerCreateMenuItem.Name = "customerCreateMenuItem";
            this.customerCreateMenuItem.Size = new System.Drawing.Size(204, 22);
            this.customerCreateMenuItem.Text = "Добавить клиента";
            this.customerCreateMenuItem.Click += new System.EventHandler(this.CustomerCreateMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerDataView);
            this.Name = "Menu";
            this.Text = "Учет клиентов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataView)).EndInit();
            this.CustomerMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip CustomerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem customerServiceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollCustomerServiceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyCustomerVisitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerCreateMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataMidleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataLastVisit;
        internal System.Windows.Forms.DataGridView customerDataView;
    }
}

