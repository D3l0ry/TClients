namespace TClients
{
    partial class ServiceMenu
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
            this.serviceDataView = new System.Windows.Forms.DataGridView();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleService = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusService = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceDataView
            // 
            this.serviceDataView.AllowUserToAddRows = false;
            this.serviceDataView.BackgroundColor = System.Drawing.Color.White;
            this.serviceDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceDataView.ColumnHeadersHeight = 31;
            this.serviceDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.serviceDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.titleService,
            this.dateService,
            this.priceService,
            this.statusService});
            this.serviceDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.serviceDataView.Location = new System.Drawing.Point(0, 0);
            this.serviceDataView.MultiSelect = false;
            this.serviceDataView.Name = "serviceDataView";
            this.serviceDataView.Size = new System.Drawing.Size(800, 450);
            this.serviceDataView.TabIndex = 0;
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "CustomerId";
            this.customerId.HeaderText = "Номер клиента";
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            // 
            // titleService
            // 
            this.titleService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleService.DataPropertyName = "Title";
            this.titleService.HeaderText = "Цель визита";
            this.titleService.Name = "titleService";
            // 
            // dateService
            // 
            this.dateService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateService.DataPropertyName = "Date";
            this.dateService.HeaderText = "Дата визита";
            this.dateService.Name = "dateService";
            this.dateService.ReadOnly = true;
            // 
            // priceService
            // 
            this.priceService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceService.DataPropertyName = "Price";
            this.priceService.HeaderText = "Цена";
            this.priceService.Name = "priceService";
            // 
            // statusService
            // 
            this.statusService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusService.DataPropertyName = "Status";
            this.statusService.HeaderText = "Статус";
            this.statusService.Items.AddRange(new object[] {
            "Записан",
            "Выполнен"});
            this.statusService.Name = "statusService";
            // 
            // ServiceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serviceDataView);
            this.Name = "ServiceMenu";
            this.Text = "История визитов:";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView serviceDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewComboBoxColumn titleService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateService;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceService;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusService;
    }
}