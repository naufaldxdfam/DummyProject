namespace Bis_Mania_Ticketing
{
    partial class frBus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbLoadItem = new MetroFramework.Controls.MetroComboBox();
            this.lbPage = new MetroFramework.Controls.MetroLabel();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lbID = new MetroFramework.Controls.MetroLabel();
            this.lbOtobus = new MetroFramework.Controls.MetroLabel();
            this.bSave = new System.Windows.Forms.Button();
            this.tbOtobus = new MetroFramework.Controls.MetroTextBox();
            this.dgBus = new MetroFramework.Controls.MetroGrid();
            this.tbOtobusName = new MetroFramework.Controls.MetroTextBox();
            this.tbTicketTypeName = new MetroFramework.Controls.MetroTextBox();
            this.lbTicketType = new MetroFramework.Controls.MetroLabel();
            this.tbTicketType = new MetroFramework.Controls.MetroTextBox();
            this.tbBusModel = new MetroFramework.Controls.MetroTextBox();
            this.lbBusModel = new MetroFramework.Controls.MetroLabel();
            this.lbTotalSeats = new MetroFramework.Controls.MetroLabel();
            this.nudSeats = new System.Windows.Forms.NumericUpDown();
            this.lbIdValue = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(274, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 15);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Show Items :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // cbLoadItem
            // 
            this.cbLoadItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoadItem.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbLoadItem.FormattingEnabled = true;
            this.cbLoadItem.ItemHeight = 19;
            this.cbLoadItem.Items.AddRange(new object[] {
            "100",
            "150",
            "250",
            "500"});
            this.cbLoadItem.Location = new System.Drawing.Point(346, 6);
            this.cbLoadItem.Name = "cbLoadItem";
            this.cbLoadItem.Size = new System.Drawing.Size(80, 25);
            this.cbLoadItem.Style = MetroFramework.MetroColorStyle.Green;
            this.cbLoadItem.TabIndex = 29;
            this.cbLoadItem.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbLoadItem.UseSelectable = true;
            this.cbLoadItem.SelectedIndexChanged += new System.EventHandler(this.cbLoadItem_SelectedIndexChanged);
            // 
            // lbPage
            // 
            this.lbPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPage.Location = new System.Drawing.Point(388, 251);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(124, 23);
            this.lbPage.TabIndex = 28;
            this.lbPage.Text = "1";
            this.lbPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPage.UseCustomBackColor = true;
            // 
            // bPrevious
            // 
            this.bPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bPrevious.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bPrevious.Location = new System.Drawing.Point(323, 251);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(59, 23);
            this.bPrevious.TabIndex = 27;
            this.bPrevious.Text = "Previous";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // bNext
            // 
            this.bNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bNext.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bNext.Location = new System.Drawing.Point(518, 251);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(59, 23);
            this.bNext.TabIndex = 26;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bCancel.Location = new System.Drawing.Point(75, 258);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 25;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Visible = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbSearch.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.CustomButton.Image = global::Bis_Mania_Ticketing.Properties.Resources.Search;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(432, 6);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShowButton = true;
            this.tbSearch.ShowClearButton = true;
            this.tbSearch.Size = new System.Drawing.Size(210, 23);
            this.tbSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.tbSearch.TabIndex = 24;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMark = "Search";
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbSearch_ButtonClick);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bEdit.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bEdit.Location = new System.Drawing.Point(540, 280);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(102, 29);
            this.bEdit.TabIndex = 23;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bDelete.Location = new System.Drawing.Point(432, 280);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(102, 29);
            this.bDelete.TabIndex = 22;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Location = new System.Drawing.Point(8, 56);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 19);
            this.lbID.TabIndex = 20;
            this.lbID.Text = "ID";
            this.lbID.UseCustomBackColor = true;
            this.lbID.Visible = false;
            // 
            // lbOtobus
            // 
            this.lbOtobus.AutoSize = true;
            this.lbOtobus.BackColor = System.Drawing.Color.Transparent;
            this.lbOtobus.Location = new System.Drawing.Point(8, 85);
            this.lbOtobus.Name = "lbOtobus";
            this.lbOtobus.Size = new System.Drawing.Size(52, 19);
            this.lbOtobus.TabIndex = 19;
            this.lbOtobus.Text = "Otobus";
            this.lbOtobus.UseCustomBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bSave.Location = new System.Drawing.Point(156, 258);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbOtobus
            // 
            // 
            // 
            // 
            this.tbOtobus.CustomButton.Image = null;
            this.tbOtobus.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.tbOtobus.CustomButton.Name = "";
            this.tbOtobus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbOtobus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbOtobus.CustomButton.TabIndex = 1;
            this.tbOtobus.CustomButton.Text = "...";
            this.tbOtobus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbOtobus.CustomButton.UseSelectable = true;
            this.tbOtobus.Lines = new string[0];
            this.tbOtobus.Location = new System.Drawing.Point(106, 85);
            this.tbOtobus.MaxLength = 32767;
            this.tbOtobus.Name = "tbOtobus";
            this.tbOtobus.PasswordChar = '\0';
            this.tbOtobus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbOtobus.SelectedText = "";
            this.tbOtobus.SelectionLength = 0;
            this.tbOtobus.SelectionStart = 0;
            this.tbOtobus.ShowButton = true;
            this.tbOtobus.Size = new System.Drawing.Size(125, 23);
            this.tbOtobus.Style = MetroFramework.MetroColorStyle.Green;
            this.tbOtobus.TabIndex = 16;
            this.tbOtobus.UseSelectable = true;
            this.tbOtobus.WaterMark = "Otobus";
            this.tbOtobus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbOtobus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbOtobus.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbOtobus_ButtonClick);
            this.tbOtobus.Leave += new System.EventHandler(this.tbOtobus_Leave);
            // 
            // dgBus
            // 
            this.dgBus.AllowUserToAddRows = false;
            this.dgBus.AllowUserToDeleteRows = false;
            this.dgBus.AllowUserToOrderColumns = true;
            this.dgBus.AllowUserToResizeRows = false;
            this.dgBus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgBus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBus.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgBus.EnableHeadersVisualStyles = false;
            this.dgBus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgBus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgBus.Location = new System.Drawing.Point(254, 35);
            this.dgBus.MultiSelect = false;
            this.dgBus.Name = "dgBus";
            this.dgBus.ReadOnly = true;
            this.dgBus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBus.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgBus.RowHeadersVisible = false;
            this.dgBus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBus.Size = new System.Drawing.Size(388, 210);
            this.dgBus.Style = MetroFramework.MetroColorStyle.Green;
            this.dgBus.TabIndex = 17;
            this.dgBus.TabStop = false;
            this.dgBus.UseCustomBackColor = true;
            // 
            // tbOtobusName
            // 
            this.tbOtobusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.tbOtobusName.CustomButton.Image = null;
            this.tbOtobusName.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.tbOtobusName.CustomButton.Name = "";
            this.tbOtobusName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbOtobusName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbOtobusName.CustomButton.TabIndex = 1;
            this.tbOtobusName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbOtobusName.CustomButton.UseSelectable = true;
            this.tbOtobusName.CustomButton.Visible = false;
            this.tbOtobusName.Lines = new string[0];
            this.tbOtobusName.Location = new System.Drawing.Point(106, 114);
            this.tbOtobusName.MaxLength = 32767;
            this.tbOtobusName.Name = "tbOtobusName";
            this.tbOtobusName.PasswordChar = '\0';
            this.tbOtobusName.ReadOnly = true;
            this.tbOtobusName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbOtobusName.SelectedText = "";
            this.tbOtobusName.SelectionLength = 0;
            this.tbOtobusName.SelectionStart = 0;
            this.tbOtobusName.Size = new System.Drawing.Size(125, 23);
            this.tbOtobusName.Style = MetroFramework.MetroColorStyle.Green;
            this.tbOtobusName.TabIndex = 31;
            this.tbOtobusName.UseCustomBackColor = true;
            this.tbOtobusName.UseSelectable = true;
            this.tbOtobusName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbOtobusName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbTicketTypeName
            // 
            this.tbTicketTypeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.tbTicketTypeName.CustomButton.Image = null;
            this.tbTicketTypeName.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.tbTicketTypeName.CustomButton.Name = "";
            this.tbTicketTypeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTicketTypeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTicketTypeName.CustomButton.TabIndex = 1;
            this.tbTicketTypeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTicketTypeName.CustomButton.UseSelectable = true;
            this.tbTicketTypeName.CustomButton.Visible = false;
            this.tbTicketTypeName.Lines = new string[0];
            this.tbTicketTypeName.Location = new System.Drawing.Point(106, 172);
            this.tbTicketTypeName.MaxLength = 32767;
            this.tbTicketTypeName.Name = "tbTicketTypeName";
            this.tbTicketTypeName.PasswordChar = '\0';
            this.tbTicketTypeName.ReadOnly = true;
            this.tbTicketTypeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTicketTypeName.SelectedText = "";
            this.tbTicketTypeName.SelectionLength = 0;
            this.tbTicketTypeName.SelectionStart = 0;
            this.tbTicketTypeName.Size = new System.Drawing.Size(125, 23);
            this.tbTicketTypeName.Style = MetroFramework.MetroColorStyle.Green;
            this.tbTicketTypeName.TabIndex = 34;
            this.tbTicketTypeName.UseCustomBackColor = true;
            this.tbTicketTypeName.UseSelectable = true;
            this.tbTicketTypeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTicketTypeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbTicketType
            // 
            this.lbTicketType.AutoSize = true;
            this.lbTicketType.BackColor = System.Drawing.Color.Transparent;
            this.lbTicketType.Location = new System.Drawing.Point(8, 143);
            this.lbTicketType.Name = "lbTicketType";
            this.lbTicketType.Size = new System.Drawing.Size(73, 19);
            this.lbTicketType.TabIndex = 33;
            this.lbTicketType.Text = "Ticket Type";
            this.lbTicketType.UseCustomBackColor = true;
            // 
            // tbTicketType
            // 
            // 
            // 
            // 
            this.tbTicketType.CustomButton.Image = null;
            this.tbTicketType.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.tbTicketType.CustomButton.Name = "";
            this.tbTicketType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTicketType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTicketType.CustomButton.TabIndex = 1;
            this.tbTicketType.CustomButton.Text = "...";
            this.tbTicketType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTicketType.CustomButton.UseSelectable = true;
            this.tbTicketType.Lines = new string[0];
            this.tbTicketType.Location = new System.Drawing.Point(106, 143);
            this.tbTicketType.MaxLength = 32767;
            this.tbTicketType.Name = "tbTicketType";
            this.tbTicketType.PasswordChar = '\0';
            this.tbTicketType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTicketType.SelectedText = "";
            this.tbTicketType.SelectionLength = 0;
            this.tbTicketType.SelectionStart = 0;
            this.tbTicketType.ShowButton = true;
            this.tbTicketType.Size = new System.Drawing.Size(125, 23);
            this.tbTicketType.Style = MetroFramework.MetroColorStyle.Green;
            this.tbTicketType.TabIndex = 32;
            this.tbTicketType.UseSelectable = true;
            this.tbTicketType.WaterMark = "Ticket Type";
            this.tbTicketType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTicketType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbTicketType.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbTicketType_ButtonClick);
            this.tbTicketType.Leave += new System.EventHandler(this.tbTicketType_Leave);
            // 
            // tbBusModel
            // 
            // 
            // 
            // 
            this.tbBusModel.CustomButton.Image = null;
            this.tbBusModel.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.tbBusModel.CustomButton.Name = "";
            this.tbBusModel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbBusModel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbBusModel.CustomButton.TabIndex = 1;
            this.tbBusModel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbBusModel.CustomButton.UseSelectable = true;
            this.tbBusModel.CustomButton.Visible = false;
            this.tbBusModel.Lines = new string[0];
            this.tbBusModel.Location = new System.Drawing.Point(106, 201);
            this.tbBusModel.MaxLength = 32767;
            this.tbBusModel.Name = "tbBusModel";
            this.tbBusModel.PasswordChar = '\0';
            this.tbBusModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBusModel.SelectedText = "";
            this.tbBusModel.SelectionLength = 0;
            this.tbBusModel.SelectionStart = 0;
            this.tbBusModel.Size = new System.Drawing.Size(125, 23);
            this.tbBusModel.Style = MetroFramework.MetroColorStyle.Green;
            this.tbBusModel.TabIndex = 35;
            this.tbBusModel.UseSelectable = true;
            this.tbBusModel.WaterMark = "Bus Model";
            this.tbBusModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbBusModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbBusModel
            // 
            this.lbBusModel.AutoSize = true;
            this.lbBusModel.BackColor = System.Drawing.Color.Transparent;
            this.lbBusModel.Location = new System.Drawing.Point(8, 201);
            this.lbBusModel.Name = "lbBusModel";
            this.lbBusModel.Size = new System.Drawing.Size(71, 19);
            this.lbBusModel.TabIndex = 36;
            this.lbBusModel.Text = "Bus Model";
            this.lbBusModel.UseCustomBackColor = true;
            // 
            // lbTotalSeats
            // 
            this.lbTotalSeats.AutoSize = true;
            this.lbTotalSeats.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalSeats.Location = new System.Drawing.Point(8, 230);
            this.lbTotalSeats.Name = "lbTotalSeats";
            this.lbTotalSeats.Size = new System.Drawing.Size(70, 19);
            this.lbTotalSeats.TabIndex = 38;
            this.lbTotalSeats.Text = "Total Seats";
            this.lbTotalSeats.UseCustomBackColor = true;
            // 
            // nudSeats
            // 
            this.nudSeats.Location = new System.Drawing.Point(106, 230);
            this.nudSeats.Name = "nudSeats";
            this.nudSeats.Size = new System.Drawing.Size(125, 22);
            this.nudSeats.TabIndex = 39;
            // 
            // lbIdValue
            // 
            this.lbIdValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.lbIdValue.CustomButton.Image = null;
            this.lbIdValue.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.lbIdValue.CustomButton.Name = "";
            this.lbIdValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lbIdValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbIdValue.CustomButton.TabIndex = 1;
            this.lbIdValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbIdValue.CustomButton.UseSelectable = true;
            this.lbIdValue.CustomButton.Visible = false;
            this.lbIdValue.Lines = new string[0];
            this.lbIdValue.Location = new System.Drawing.Point(106, 56);
            this.lbIdValue.MaxLength = 32767;
            this.lbIdValue.Name = "lbIdValue";
            this.lbIdValue.PasswordChar = '\0';
            this.lbIdValue.ReadOnly = true;
            this.lbIdValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbIdValue.SelectedText = "";
            this.lbIdValue.SelectionLength = 0;
            this.lbIdValue.SelectionStart = 0;
            this.lbIdValue.Size = new System.Drawing.Size(125, 23);
            this.lbIdValue.Style = MetroFramework.MetroColorStyle.Green;
            this.lbIdValue.TabIndex = 40;
            this.lbIdValue.UseCustomBackColor = true;
            this.lbIdValue.UseSelectable = true;
            this.lbIdValue.Visible = false;
            this.lbIdValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbIdValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(654, 321);
            this.Controls.Add(this.lbIdValue);
            this.Controls.Add(this.nudSeats);
            this.Controls.Add(this.lbTotalSeats);
            this.Controls.Add(this.lbBusModel);
            this.Controls.Add(this.tbBusModel);
            this.Controls.Add(this.tbTicketTypeName);
            this.Controls.Add(this.lbTicketType);
            this.Controls.Add(this.tbTicketType);
            this.Controls.Add(this.tbOtobusName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbLoadItem);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbOtobus);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbOtobus);
            this.Controls.Add(this.dgBus);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frBus";
            this.Text = "frBus";
            this.Load += new System.EventHandler(this.frBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbLoadItem;
        private MetroFramework.Controls.MetroLabel lbPage;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bCancel;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private MetroFramework.Controls.MetroLabel lbID;
        private MetroFramework.Controls.MetroLabel lbOtobus;
        private System.Windows.Forms.Button bSave;
        private MetroFramework.Controls.MetroTextBox tbOtobus;
        private MetroFramework.Controls.MetroGrid dgBus;
        private MetroFramework.Controls.MetroTextBox tbOtobusName;
        private MetroFramework.Controls.MetroTextBox tbTicketTypeName;
        private MetroFramework.Controls.MetroLabel lbTicketType;
        private MetroFramework.Controls.MetroTextBox tbTicketType;
        private MetroFramework.Controls.MetroTextBox tbBusModel;
        private MetroFramework.Controls.MetroLabel lbBusModel;
        private MetroFramework.Controls.MetroLabel lbTotalSeats;
        private System.Windows.Forms.NumericUpDown nudSeats;
        private MetroFramework.Controls.MetroTextBox lbIdValue;

    }
}