namespace Bis_Mania_Ticketing
{
    partial class frPassenger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbIdValue = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbLoadItem = new MetroFramework.Controls.MetroComboBox();
            this.lbPage = new MetroFramework.Controls.MetroLabel();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.lbID = new MetroFramework.Controls.MetroLabel();
            this.lbFirstName = new MetroFramework.Controls.MetroLabel();
            this.bSave = new System.Windows.Forms.Button();
            this.tbFirstName = new MetroFramework.Controls.MetroTextBox();
            this.dgPassenger = new MetroFramework.Controls.MetroGrid();
            this.lbLastName = new MetroFramework.Controls.MetroLabel();
            this.tbLastName = new MetroFramework.Controls.MetroTextBox();
            this.lbBirthday = new MetroFramework.Controls.MetroLabel();
            this.dtpBirthday = new MetroFramework.Controls.MetroDateTime();
            this.lbGender = new MetroFramework.Controls.MetroLabel();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.lbAddress = new MetroFramework.Controls.MetroLabel();
            this.tbTown = new MetroFramework.Controls.MetroTextBox();
            this.tbPostCode = new MetroFramework.Controls.MetroTextBox();
            this.lbTown = new MetroFramework.Controls.MetroLabel();
            this.lbPostCode = new MetroFramework.Controls.MetroLabel();
            this.lbNotice = new MetroFramework.Controls.MetroLabel();
            this.cbGender = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbPhone = new MetroFramework.Controls.MetroTextBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lbNik = new MetroFramework.Controls.MetroLabel();
            this.tbNik = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdValue
            // 
            this.lbIdValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.lbIdValue.CustomButton.Image = null;
            this.lbIdValue.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.lbIdValue.CustomButton.Name = "";
            this.lbIdValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lbIdValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbIdValue.CustomButton.TabIndex = 1;
            this.lbIdValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbIdValue.CustomButton.UseSelectable = true;
            this.lbIdValue.CustomButton.Visible = false;
            this.lbIdValue.Lines = new string[0];
            this.lbIdValue.Location = new System.Drawing.Point(93, 56);
            this.lbIdValue.MaxLength = 32767;
            this.lbIdValue.Name = "lbIdValue";
            this.lbIdValue.PasswordChar = '\0';
            this.lbIdValue.ReadOnly = true;
            this.lbIdValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbIdValue.SelectedText = "";
            this.lbIdValue.SelectionLength = 0;
            this.lbIdValue.SelectionStart = 0;
            this.lbIdValue.Size = new System.Drawing.Size(163, 23);
            this.lbIdValue.Style = MetroFramework.MetroColorStyle.Green;
            this.lbIdValue.TabIndex = 117;
            this.lbIdValue.TabStop = false;
            this.lbIdValue.UseCustomBackColor = true;
            this.lbIdValue.UseSelectable = true;
            this.lbIdValue.Visible = false;
            this.lbIdValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbIdValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroLabel1.TabIndex = 116;
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
            this.cbLoadItem.TabIndex = 115;
            this.cbLoadItem.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbLoadItem.UseSelectable = true;
            this.cbLoadItem.SelectedIndexChanged += new System.EventHandler(this.cbLoadItem_SelectedIndexChanged);
            // 
            // lbPage
            // 
            this.lbPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPage.Location = new System.Drawing.Point(388, 455);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(124, 23);
            this.lbPage.TabIndex = 114;
            this.lbPage.Text = "1";
            this.lbPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPage.UseCustomBackColor = true;
            // 
            // bPrevious
            // 
            this.bPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bPrevious.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bPrevious.Location = new System.Drawing.Point(323, 455);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(59, 23);
            this.bPrevious.TabIndex = 113;
            this.bPrevious.Text = "Previous";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // bNext
            // 
            this.bNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bNext.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bNext.Location = new System.Drawing.Point(518, 455);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(59, 23);
            this.bNext.TabIndex = 112;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bCancel.Location = new System.Drawing.Point(100, 423);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 111;
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
            this.tbSearch.TabIndex = 110;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMark = "Search";
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbSearch_ButtonClick);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Location = new System.Drawing.Point(12, 56);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 19);
            this.lbID.TabIndex = 107;
            this.lbID.Text = "ID";
            this.lbID.UseCustomBackColor = true;
            this.lbID.Visible = false;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstName.Location = new System.Drawing.Point(12, 114);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(73, 19);
            this.lbFirstName.TabIndex = 106;
            this.lbFirstName.Text = "First Name";
            this.lbFirstName.UseCustomBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bSave.Location = new System.Drawing.Point(181, 423);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 105;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbFirstName
            // 
            // 
            // 
            // 
            this.tbFirstName.CustomButton.Image = null;
            this.tbFirstName.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.tbFirstName.CustomButton.Name = "";
            this.tbFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFirstName.CustomButton.TabIndex = 1;
            this.tbFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFirstName.CustomButton.UseSelectable = true;
            this.tbFirstName.CustomButton.Visible = false;
            this.tbFirstName.Lines = new string[0];
            this.tbFirstName.Location = new System.Drawing.Point(93, 114);
            this.tbFirstName.MaxLength = 32767;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.SelectionLength = 0;
            this.tbFirstName.SelectionStart = 0;
            this.tbFirstName.Size = new System.Drawing.Size(163, 23);
            this.tbFirstName.Style = MetroFramework.MetroColorStyle.Green;
            this.tbFirstName.TabIndex = 103;
            this.tbFirstName.UseSelectable = true;
            this.tbFirstName.WaterMark = "First Name";
            this.tbFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgPassenger
            // 
            this.dgPassenger.AllowUserToAddRows = false;
            this.dgPassenger.AllowUserToDeleteRows = false;
            this.dgPassenger.AllowUserToOrderColumns = true;
            this.dgPassenger.AllowUserToResizeRows = false;
            this.dgPassenger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPassenger.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgPassenger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPassenger.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPassenger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPassenger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPassenger.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgPassenger.EnableHeadersVisualStyles = false;
            this.dgPassenger.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgPassenger.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgPassenger.Location = new System.Drawing.Point(272, 35);
            this.dgPassenger.MultiSelect = false;
            this.dgPassenger.Name = "dgPassenger";
            this.dgPassenger.ReadOnly = true;
            this.dgPassenger.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPassenger.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgPassenger.RowHeadersVisible = false;
            this.dgPassenger.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPassenger.Size = new System.Drawing.Size(370, 414);
            this.dgPassenger.Style = MetroFramework.MetroColorStyle.Green;
            this.dgPassenger.TabIndex = 104;
            this.dgPassenger.TabStop = false;
            this.dgPassenger.UseCustomBackColor = true;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.BackColor = System.Drawing.Color.Transparent;
            this.lbLastName.Location = new System.Drawing.Point(12, 143);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 19);
            this.lbLastName.TabIndex = 119;
            this.lbLastName.Text = "Last Name";
            this.lbLastName.UseCustomBackColor = true;
            // 
            // tbLastName
            // 
            // 
            // 
            // 
            this.tbLastName.CustomButton.Image = null;
            this.tbLastName.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.tbLastName.CustomButton.Name = "";
            this.tbLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLastName.CustomButton.TabIndex = 1;
            this.tbLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLastName.CustomButton.UseSelectable = true;
            this.tbLastName.CustomButton.Visible = false;
            this.tbLastName.Lines = new string[0];
            this.tbLastName.Location = new System.Drawing.Point(93, 143);
            this.tbLastName.MaxLength = 32767;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLastName.SelectedText = "";
            this.tbLastName.SelectionLength = 0;
            this.tbLastName.SelectionStart = 0;
            this.tbLastName.Size = new System.Drawing.Size(163, 23);
            this.tbLastName.Style = MetroFramework.MetroColorStyle.Green;
            this.tbLastName.TabIndex = 118;
            this.tbLastName.UseSelectable = true;
            this.tbLastName.WaterMark = "Last Name";
            this.tbLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lbBirthday.Location = new System.Drawing.Point(12, 172);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(58, 19);
            this.lbBirthday.TabIndex = 121;
            this.lbBirthday.Text = "Birthday";
            this.lbBirthday.UseCustomBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "YYYY-MM-DD";
            this.dtpBirthday.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(93, 172);
            this.dtpBirthday.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(163, 25);
            this.dtpBirthday.TabIndex = 122;
            this.dtpBirthday.Value = new System.DateTime(2016, 2, 15, 0, 0, 0, 0);
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.BackColor = System.Drawing.Color.Transparent;
            this.lbGender.Location = new System.Drawing.Point(12, 203);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(52, 19);
            this.lbGender.TabIndex = 124;
            this.lbGender.Text = "Gender";
            this.lbGender.UseCustomBackColor = true;
            // 
            // rtbAddress
            // 
            this.rtbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAddress.Location = new System.Drawing.Point(93, 234);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(163, 96);
            this.rtbAddress.TabIndex = 125;
            this.rtbAddress.Text = "";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Location = new System.Drawing.Point(12, 234);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(56, 19);
            this.lbAddress.TabIndex = 126;
            this.lbAddress.Text = "Address";
            this.lbAddress.UseCustomBackColor = true;
            // 
            // tbTown
            // 
            // 
            // 
            // 
            this.tbTown.CustomButton.Image = null;
            this.tbTown.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.tbTown.CustomButton.Name = "";
            this.tbTown.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTown.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTown.CustomButton.TabIndex = 1;
            this.tbTown.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTown.CustomButton.UseSelectable = true;
            this.tbTown.CustomButton.Visible = false;
            this.tbTown.Lines = new string[0];
            this.tbTown.Location = new System.Drawing.Point(93, 336);
            this.tbTown.MaxLength = 32767;
            this.tbTown.Name = "tbTown";
            this.tbTown.PasswordChar = '\0';
            this.tbTown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTown.SelectedText = "";
            this.tbTown.SelectionLength = 0;
            this.tbTown.SelectionStart = 0;
            this.tbTown.Size = new System.Drawing.Size(163, 23);
            this.tbTown.Style = MetroFramework.MetroColorStyle.Green;
            this.tbTown.TabIndex = 127;
            this.tbTown.UseSelectable = true;
            this.tbTown.WaterMark = "Town";
            this.tbTown.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTown.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPostCode
            // 
            // 
            // 
            // 
            this.tbPostCode.CustomButton.Image = null;
            this.tbPostCode.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.tbPostCode.CustomButton.Name = "";
            this.tbPostCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPostCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPostCode.CustomButton.TabIndex = 1;
            this.tbPostCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPostCode.CustomButton.UseSelectable = true;
            this.tbPostCode.CustomButton.Visible = false;
            this.tbPostCode.Lines = new string[0];
            this.tbPostCode.Location = new System.Drawing.Point(93, 365);
            this.tbPostCode.MaxLength = 32767;
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.PasswordChar = '\0';
            this.tbPostCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPostCode.SelectedText = "";
            this.tbPostCode.SelectionLength = 0;
            this.tbPostCode.SelectionStart = 0;
            this.tbPostCode.Size = new System.Drawing.Size(163, 23);
            this.tbPostCode.Style = MetroFramework.MetroColorStyle.Green;
            this.tbPostCode.TabIndex = 128;
            this.tbPostCode.UseSelectable = true;
            this.tbPostCode.WaterMark = "Post Code*";
            this.tbPostCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPostCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPostCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostCode_KeyPress);
            // 
            // lbTown
            // 
            this.lbTown.AutoSize = true;
            this.lbTown.BackColor = System.Drawing.Color.Transparent;
            this.lbTown.Location = new System.Drawing.Point(12, 336);
            this.lbTown.Name = "lbTown";
            this.lbTown.Size = new System.Drawing.Size(38, 19);
            this.lbTown.TabIndex = 129;
            this.lbTown.Text = "Town";
            this.lbTown.UseCustomBackColor = true;
            // 
            // lbPostCode
            // 
            this.lbPostCode.AutoSize = true;
            this.lbPostCode.BackColor = System.Drawing.Color.Transparent;
            this.lbPostCode.Location = new System.Drawing.Point(12, 365);
            this.lbPostCode.Name = "lbPostCode";
            this.lbPostCode.Size = new System.Drawing.Size(75, 19);
            this.lbPostCode.TabIndex = 130;
            this.lbPostCode.Text = "Post Code*";
            this.lbPostCode.UseCustomBackColor = true;
            // 
            // lbNotice
            // 
            this.lbNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNotice.AutoSize = true;
            this.lbNotice.BackColor = System.Drawing.Color.Transparent;
            this.lbNotice.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbNotice.Location = new System.Drawing.Point(12, 501);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(64, 15);
            this.lbNotice.TabIndex = 133;
            this.lbNotice.Text = "(*) Optional";
            this.lbNotice.UseCustomBackColor = true;
            // 
            // cbGender
            // 
            this.cbGender.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ItemHeight = 19;
            this.cbGender.Items.AddRange(new object[] {
            "100",
            "150",
            "250",
            "500"});
            this.cbGender.Location = new System.Drawing.Point(93, 203);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(163, 25);
            this.cbGender.Style = MetroFramework.MetroColorStyle.Green;
            this.cbGender.TabIndex = 134;
            this.cbGender.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbGender.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(12, 394);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 136;
            this.metroLabel2.Text = "Phone*";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // tbPhone
            // 
            // 
            // 
            // 
            this.tbPhone.CustomButton.Image = null;
            this.tbPhone.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.tbPhone.CustomButton.Name = "";
            this.tbPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPhone.CustomButton.TabIndex = 1;
            this.tbPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPhone.CustomButton.UseSelectable = true;
            this.tbPhone.CustomButton.Visible = false;
            this.tbPhone.Lines = new string[0];
            this.tbPhone.Location = new System.Drawing.Point(93, 394);
            this.tbPhone.MaxLength = 32767;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPhone.SelectedText = "";
            this.tbPhone.SelectionLength = 0;
            this.tbPhone.SelectionStart = 0;
            this.tbPhone.Size = new System.Drawing.Size(163, 23);
            this.tbPhone.Style = MetroFramework.MetroColorStyle.Green;
            this.tbPhone.TabIndex = 135;
            this.tbPhone.UseSelectable = true;
            this.tbPhone.WaterMark = "Phone Number*";
            this.tbPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bEdit.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bEdit.Location = new System.Drawing.Point(540, 484);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(102, 29);
            this.bEdit.TabIndex = 138;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bDelete.Location = new System.Drawing.Point(432, 484);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(102, 29);
            this.bDelete.TabIndex = 137;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // lbNik
            // 
            this.lbNik.AutoSize = true;
            this.lbNik.BackColor = System.Drawing.Color.Transparent;
            this.lbNik.Location = new System.Drawing.Point(12, 85);
            this.lbNik.Name = "lbNik";
            this.lbNik.Size = new System.Drawing.Size(29, 19);
            this.lbNik.TabIndex = 140;
            this.lbNik.Text = "NIK";
            this.lbNik.UseCustomBackColor = true;
            // 
            // tbNik
            // 
            // 
            // 
            // 
            this.tbNik.CustomButton.Image = null;
            this.tbNik.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.tbNik.CustomButton.Name = "";
            this.tbNik.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNik.CustomButton.TabIndex = 1;
            this.tbNik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNik.CustomButton.UseSelectable = true;
            this.tbNik.CustomButton.Visible = false;
            this.tbNik.Lines = new string[0];
            this.tbNik.Location = new System.Drawing.Point(93, 85);
            this.tbNik.MaxLength = 32767;
            this.tbNik.Name = "tbNik";
            this.tbNik.PasswordChar = '\0';
            this.tbNik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNik.SelectedText = "";
            this.tbNik.SelectionLength = 0;
            this.tbNik.SelectionStart = 0;
            this.tbNik.Size = new System.Drawing.Size(163, 23);
            this.tbNik.Style = MetroFramework.MetroColorStyle.Green;
            this.tbNik.TabIndex = 139;
            this.tbNik.UseSelectable = true;
            this.tbNik.WaterMark = "NIK";
            this.tbNik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbNik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNik_KeyPress);
            // 
            // frPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(654, 525);
            this.Controls.Add(this.lbNik);
            this.Controls.Add(this.tbNik);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.lbPostCode);
            this.Controls.Add(this.lbTown);
            this.Controls.Add(this.tbPostCode);
            this.Controls.Add(this.tbTown);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbIdValue);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbLoadItem);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.dgPassenger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frPassenger";
            this.Text = "frPassenger";
            this.Load += new System.EventHandler(this.frPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPassenger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox lbIdValue;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbLoadItem;
        private MetroFramework.Controls.MetroLabel lbPage;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bCancel;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private MetroFramework.Controls.MetroLabel lbID;
        private MetroFramework.Controls.MetroLabel lbFirstName;
        private System.Windows.Forms.Button bSave;
        private MetroFramework.Controls.MetroTextBox tbFirstName;
        private MetroFramework.Controls.MetroGrid dgPassenger;
        private MetroFramework.Controls.MetroLabel lbLastName;
        private MetroFramework.Controls.MetroTextBox tbLastName;
        private MetroFramework.Controls.MetroLabel lbBirthday;
        private MetroFramework.Controls.MetroDateTime dtpBirthday;
        private MetroFramework.Controls.MetroLabel lbGender;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private MetroFramework.Controls.MetroLabel lbAddress;
        private MetroFramework.Controls.MetroTextBox tbTown;
        private MetroFramework.Controls.MetroTextBox tbPostCode;
        private MetroFramework.Controls.MetroLabel lbTown;
        private MetroFramework.Controls.MetroLabel lbPostCode;
        private MetroFramework.Controls.MetroLabel lbNotice;
        private MetroFramework.Controls.MetroComboBox cbGender;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbPhone;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private MetroFramework.Controls.MetroLabel lbNik;
        private MetroFramework.Controls.MetroTextBox tbNik;
    }
}