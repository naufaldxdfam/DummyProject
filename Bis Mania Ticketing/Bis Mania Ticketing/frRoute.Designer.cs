namespace Bis_Mania_Ticketing
{
    partial class frRoute
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lbDeparture = new MetroFramework.Controls.MetroLabel();
            this.bSave = new System.Windows.Forms.Button();
            this.tbDeparture = new MetroFramework.Controls.MetroTextBox();
            this.dgRoute = new MetroFramework.Controls.MetroGrid();
            this.tbDepartureNameLocation = new MetroFramework.Controls.MetroTextBox();
            this.tbDestinationNameLocation = new MetroFramework.Controls.MetroTextBox();
            this.lbDestination = new MetroFramework.Controls.MetroLabel();
            this.tbDestination = new MetroFramework.Controls.MetroTextBox();
            this.lbIdValue = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoute)).BeginInit();
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
            this.metroLabel1.TabIndex = 43;
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
            this.cbLoadItem.TabIndex = 42;
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
            this.lbPage.TabIndex = 41;
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
            this.bPrevious.TabIndex = 40;
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
            this.bNext.TabIndex = 39;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bCancel.Location = new System.Drawing.Point(76, 201);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 38;
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
            this.tbSearch.TabIndex = 37;
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
            this.bEdit.TabIndex = 36;
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
            this.bDelete.TabIndex = 35;
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
            this.lbID.TabIndex = 33;
            this.lbID.Text = "ID";
            this.lbID.UseCustomBackColor = true;
            this.lbID.Visible = false;
            // 
            // lbDeparture
            // 
            this.lbDeparture.AutoSize = true;
            this.lbDeparture.BackColor = System.Drawing.Color.Transparent;
            this.lbDeparture.Location = new System.Drawing.Point(8, 85);
            this.lbDeparture.Name = "lbDeparture";
            this.lbDeparture.Size = new System.Drawing.Size(69, 19);
            this.lbDeparture.TabIndex = 32;
            this.lbDeparture.Text = "Departure";
            this.lbDeparture.UseCustomBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bSave.Location = new System.Drawing.Point(157, 201);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 31;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbDeparture
            // 
            // 
            // 
            // 
            this.tbDeparture.CustomButton.Image = null;
            this.tbDeparture.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.tbDeparture.CustomButton.Name = "";
            this.tbDeparture.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDeparture.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDeparture.CustomButton.TabIndex = 1;
            this.tbDeparture.CustomButton.Text = "...";
            this.tbDeparture.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDeparture.CustomButton.UseSelectable = true;
            this.tbDeparture.Lines = new string[0];
            this.tbDeparture.Location = new System.Drawing.Point(87, 85);
            this.tbDeparture.MaxLength = 32767;
            this.tbDeparture.Name = "tbDeparture";
            this.tbDeparture.PasswordChar = '\0';
            this.tbDeparture.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDeparture.SelectedText = "";
            this.tbDeparture.SelectionLength = 0;
            this.tbDeparture.SelectionStart = 0;
            this.tbDeparture.ShowButton = true;
            this.tbDeparture.Size = new System.Drawing.Size(145, 23);
            this.tbDeparture.Style = MetroFramework.MetroColorStyle.Green;
            this.tbDeparture.TabIndex = 29;
            this.tbDeparture.UseSelectable = true;
            this.tbDeparture.WaterMark = "Departure";
            this.tbDeparture.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDeparture.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbDeparture.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbDeparture_ButtonClick);
            this.tbDeparture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeparture_KeyPress);
            this.tbDeparture.Leave += new System.EventHandler(this.tbDeparture_Leave);
            // 
            // dgRoute
            // 
            this.dgRoute.AllowUserToAddRows = false;
            this.dgRoute.AllowUserToDeleteRows = false;
            this.dgRoute.AllowUserToOrderColumns = true;
            this.dgRoute.AllowUserToResizeRows = false;
            this.dgRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRoute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRoute.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgRoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRoute.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgRoute.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRoute.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRoute.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRoute.EnableHeadersVisualStyles = false;
            this.dgRoute.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgRoute.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgRoute.Location = new System.Drawing.Point(254, 35);
            this.dgRoute.MultiSelect = false;
            this.dgRoute.Name = "dgRoute";
            this.dgRoute.ReadOnly = true;
            this.dgRoute.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRoute.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRoute.RowHeadersVisible = false;
            this.dgRoute.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgRoute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRoute.Size = new System.Drawing.Size(388, 210);
            this.dgRoute.Style = MetroFramework.MetroColorStyle.Green;
            this.dgRoute.TabIndex = 30;
            this.dgRoute.TabStop = false;
            this.dgRoute.UseCustomBackColor = true;
            // 
            // tbDepartureNameLocation
            // 
            this.tbDepartureNameLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.tbDepartureNameLocation.CustomButton.Image = null;
            this.tbDepartureNameLocation.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.tbDepartureNameLocation.CustomButton.Name = "";
            this.tbDepartureNameLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDepartureNameLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDepartureNameLocation.CustomButton.TabIndex = 1;
            this.tbDepartureNameLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDepartureNameLocation.CustomButton.UseSelectable = true;
            this.tbDepartureNameLocation.CustomButton.Visible = false;
            this.tbDepartureNameLocation.Lines = new string[0];
            this.tbDepartureNameLocation.Location = new System.Drawing.Point(87, 114);
            this.tbDepartureNameLocation.MaxLength = 32767;
            this.tbDepartureNameLocation.Name = "tbDepartureNameLocation";
            this.tbDepartureNameLocation.PasswordChar = '\0';
            this.tbDepartureNameLocation.ReadOnly = true;
            this.tbDepartureNameLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDepartureNameLocation.SelectedText = "";
            this.tbDepartureNameLocation.SelectionLength = 0;
            this.tbDepartureNameLocation.SelectionStart = 0;
            this.tbDepartureNameLocation.Size = new System.Drawing.Size(145, 23);
            this.tbDepartureNameLocation.Style = MetroFramework.MetroColorStyle.Green;
            this.tbDepartureNameLocation.TabIndex = 99;
            this.tbDepartureNameLocation.TabStop = false;
            this.tbDepartureNameLocation.UseCustomBackColor = true;
            this.tbDepartureNameLocation.UseSelectable = true;
            this.tbDepartureNameLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDepartureNameLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDestinationNameLocation
            // 
            this.tbDestinationNameLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.tbDestinationNameLocation.CustomButton.Image = null;
            this.tbDestinationNameLocation.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.tbDestinationNameLocation.CustomButton.Name = "";
            this.tbDestinationNameLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDestinationNameLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDestinationNameLocation.CustomButton.TabIndex = 1;
            this.tbDestinationNameLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDestinationNameLocation.CustomButton.UseSelectable = true;
            this.tbDestinationNameLocation.CustomButton.Visible = false;
            this.tbDestinationNameLocation.Lines = new string[0];
            this.tbDestinationNameLocation.Location = new System.Drawing.Point(87, 172);
            this.tbDestinationNameLocation.MaxLength = 32767;
            this.tbDestinationNameLocation.Name = "tbDestinationNameLocation";
            this.tbDestinationNameLocation.PasswordChar = '\0';
            this.tbDestinationNameLocation.ReadOnly = true;
            this.tbDestinationNameLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDestinationNameLocation.SelectedText = "";
            this.tbDestinationNameLocation.SelectionLength = 0;
            this.tbDestinationNameLocation.SelectionStart = 0;
            this.tbDestinationNameLocation.Size = new System.Drawing.Size(145, 23);
            this.tbDestinationNameLocation.Style = MetroFramework.MetroColorStyle.Green;
            this.tbDestinationNameLocation.TabIndex = 100;
            this.tbDestinationNameLocation.TabStop = false;
            this.tbDestinationNameLocation.UseCustomBackColor = true;
            this.tbDestinationNameLocation.UseSelectable = true;
            this.tbDestinationNameLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDestinationNameLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.BackColor = System.Drawing.Color.Transparent;
            this.lbDestination.Location = new System.Drawing.Point(8, 143);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(73, 19);
            this.lbDestination.TabIndex = 46;
            this.lbDestination.Text = "Destination";
            this.lbDestination.UseCustomBackColor = true;
            // 
            // tbDestination
            // 
            // 
            // 
            // 
            this.tbDestination.CustomButton.Image = null;
            this.tbDestination.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.tbDestination.CustomButton.Name = "";
            this.tbDestination.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDestination.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDestination.CustomButton.TabIndex = 1;
            this.tbDestination.CustomButton.Text = "...";
            this.tbDestination.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDestination.CustomButton.UseSelectable = true;
            this.tbDestination.Lines = new string[0];
            this.tbDestination.Location = new System.Drawing.Point(87, 143);
            this.tbDestination.MaxLength = 32767;
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.PasswordChar = '\0';
            this.tbDestination.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDestination.SelectedText = "";
            this.tbDestination.SelectionLength = 0;
            this.tbDestination.SelectionStart = 0;
            this.tbDestination.ShowButton = true;
            this.tbDestination.Size = new System.Drawing.Size(145, 23);
            this.tbDestination.Style = MetroFramework.MetroColorStyle.Green;
            this.tbDestination.TabIndex = 30;
            this.tbDestination.UseSelectable = true;
            this.tbDestination.WaterMark = "Destination";
            this.tbDestination.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDestination.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbDestination.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbDestination_ButtonClick);
            this.tbDestination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDestination_KeyPress);
            this.tbDestination.Leave += new System.EventHandler(this.tbDestination_Leave);
            // 
            // lbIdValue
            // 
            this.lbIdValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.lbIdValue.CustomButton.Image = null;
            this.lbIdValue.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.lbIdValue.CustomButton.Name = "";
            this.lbIdValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lbIdValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbIdValue.CustomButton.TabIndex = 1;
            this.lbIdValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbIdValue.CustomButton.UseSelectable = true;
            this.lbIdValue.CustomButton.Visible = false;
            this.lbIdValue.Lines = new string[0];
            this.lbIdValue.Location = new System.Drawing.Point(87, 56);
            this.lbIdValue.MaxLength = 32767;
            this.lbIdValue.Name = "lbIdValue";
            this.lbIdValue.PasswordChar = '\0';
            this.lbIdValue.ReadOnly = true;
            this.lbIdValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbIdValue.SelectedText = "";
            this.lbIdValue.SelectionLength = 0;
            this.lbIdValue.SelectionStart = 0;
            this.lbIdValue.Size = new System.Drawing.Size(145, 23);
            this.lbIdValue.Style = MetroFramework.MetroColorStyle.Green;
            this.lbIdValue.TabIndex = 101;
            this.lbIdValue.TabStop = false;
            this.lbIdValue.UseCustomBackColor = true;
            this.lbIdValue.UseSelectable = true;
            this.lbIdValue.Visible = false;
            this.lbIdValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbIdValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(654, 321);
            this.Controls.Add(this.lbIdValue);
            this.Controls.Add(this.tbDestinationNameLocation);
            this.Controls.Add(this.lbDestination);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.tbDepartureNameLocation);
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
            this.Controls.Add(this.lbDeparture);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbDeparture);
            this.Controls.Add(this.dgRoute);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frRoute";
            this.Text = "frRoute";
            this.Load += new System.EventHandler(this.frRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoute)).EndInit();
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
        private MetroFramework.Controls.MetroLabel lbDeparture;
        private System.Windows.Forms.Button bSave;
        private MetroFramework.Controls.MetroGrid dgRoute;
        private MetroFramework.Controls.MetroTextBox tbDepartureNameLocation;
        private MetroFramework.Controls.MetroTextBox tbDestinationNameLocation;
        private MetroFramework.Controls.MetroLabel lbDestination;
        public MetroFramework.Controls.MetroTextBox tbDeparture;
        public MetroFramework.Controls.MetroTextBox tbDestination;
        private MetroFramework.Controls.MetroTextBox lbIdValue;
    }
}