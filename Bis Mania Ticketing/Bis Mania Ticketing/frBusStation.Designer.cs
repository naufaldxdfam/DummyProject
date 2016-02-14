namespace Bis_Mania_Ticketing
{
    partial class frBusStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBusStation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbPage = new MetroFramework.Controls.MetroLabel();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lbID = new MetroFramework.Controls.MetroLabel();
            this.lbBusStationName = new MetroFramework.Controls.MetroLabel();
            this.bSave = new System.Windows.Forms.Button();
            this.tbBusStation = new MetroFramework.Controls.MetroTextBox();
            this.dgBusStation = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbLocation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbLoadItem = new MetroFramework.Controls.MetroComboBox();
            this.lbIdValue = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusStation)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPage
            // 
            this.lbPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPage.Location = new System.Drawing.Point(411, 251);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(124, 23);
            this.lbPage.TabIndex = 26;
            this.lbPage.Text = "1";
            this.lbPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPage.UseCustomBackColor = true;
            // 
            // bPrevious
            // 
            this.bPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bPrevious.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bPrevious.Location = new System.Drawing.Point(346, 251);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(59, 23);
            this.bPrevious.TabIndex = 25;
            this.bPrevious.Text = "Previous";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // bNext
            // 
            this.bNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bNext.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bNext.Location = new System.Drawing.Point(541, 251);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(59, 23);
            this.bNext.TabIndex = 24;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bCancel.Location = new System.Drawing.Point(125, 143);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 23;
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
            this.tbSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
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
            this.tbSearch.TabIndex = 22;
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
            this.bEdit.TabIndex = 21;
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
            this.bDelete.TabIndex = 20;
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
            this.lbID.TabIndex = 18;
            this.lbID.Text = "ID";
            this.lbID.UseCustomBackColor = true;
            this.lbID.Visible = false;
            // 
            // lbBusStationName
            // 
            this.lbBusStationName.AutoSize = true;
            this.lbBusStationName.BackColor = System.Drawing.Color.Transparent;
            this.lbBusStationName.Location = new System.Drawing.Point(8, 85);
            this.lbBusStationName.Name = "lbBusStationName";
            this.lbBusStationName.Size = new System.Drawing.Size(113, 19);
            this.lbBusStationName.TabIndex = 17;
            this.lbBusStationName.Text = "Bus Station Name";
            this.lbBusStationName.UseCustomBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bSave.Location = new System.Drawing.Point(206, 143);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 16;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbBusStation
            // 
            // 
            // 
            // 
            this.tbBusStation.CustomButton.Image = null;
            this.tbBusStation.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.tbBusStation.CustomButton.Name = "";
            this.tbBusStation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbBusStation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbBusStation.CustomButton.TabIndex = 1;
            this.tbBusStation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbBusStation.CustomButton.UseSelectable = true;
            this.tbBusStation.CustomButton.Visible = false;
            this.tbBusStation.Lines = new string[0];
            this.tbBusStation.Location = new System.Drawing.Point(156, 85);
            this.tbBusStation.MaxLength = 32767;
            this.tbBusStation.Name = "tbBusStation";
            this.tbBusStation.PasswordChar = '\0';
            this.tbBusStation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBusStation.SelectedText = "";
            this.tbBusStation.SelectionLength = 0;
            this.tbBusStation.SelectionStart = 0;
            this.tbBusStation.Size = new System.Drawing.Size(125, 23);
            this.tbBusStation.Style = MetroFramework.MetroColorStyle.Green;
            this.tbBusStation.TabIndex = 14;
            this.tbBusStation.UseSelectable = true;
            this.tbBusStation.WaterMark = "Bus Station Name";
            this.tbBusStation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbBusStation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgBusStation
            // 
            this.dgBusStation.AllowUserToAddRows = false;
            this.dgBusStation.AllowUserToDeleteRows = false;
            this.dgBusStation.AllowUserToOrderColumns = true;
            this.dgBusStation.AllowUserToResizeRows = false;
            this.dgBusStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBusStation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBusStation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgBusStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBusStation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgBusStation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBusStation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBusStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBusStation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgBusStation.EnableHeadersVisualStyles = false;
            this.dgBusStation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgBusStation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgBusStation.Location = new System.Drawing.Point(303, 35);
            this.dgBusStation.MultiSelect = false;
            this.dgBusStation.Name = "dgBusStation";
            this.dgBusStation.ReadOnly = true;
            this.dgBusStation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBusStation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgBusStation.RowHeadersVisible = false;
            this.dgBusStation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgBusStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBusStation.Size = new System.Drawing.Size(339, 210);
            this.dgBusStation.Style = MetroFramework.MetroColorStyle.Green;
            this.dgBusStation.TabIndex = 15;
            this.dgBusStation.TabStop = false;
            this.dgBusStation.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(8, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Bus Station Location";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // tbLocation
            // 
            // 
            // 
            // 
            this.tbLocation.CustomButton.Image = null;
            this.tbLocation.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.tbLocation.CustomButton.Name = "";
            this.tbLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLocation.CustomButton.TabIndex = 1;
            this.tbLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLocation.CustomButton.UseSelectable = true;
            this.tbLocation.CustomButton.Visible = false;
            this.tbLocation.Lines = new string[0];
            this.tbLocation.Location = new System.Drawing.Point(156, 114);
            this.tbLocation.MaxLength = 32767;
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.PasswordChar = '\0';
            this.tbLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLocation.SelectedText = "";
            this.tbLocation.SelectionLength = 0;
            this.tbLocation.SelectionStart = 0;
            this.tbLocation.Size = new System.Drawing.Size(125, 23);
            this.tbLocation.Style = MetroFramework.MetroColorStyle.Green;
            this.tbLocation.TabIndex = 15;
            this.tbLocation.UseSelectable = true;
            this.tbLocation.WaterMark = "Location";
            this.tbLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(274, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 15);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Show Items :";
            this.metroLabel2.UseCustomBackColor = true;
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
            this.lbIdValue.Location = new System.Drawing.Point(156, 56);
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
            this.lbIdValue.TabIndex = 103;
            this.lbIdValue.TabStop = false;
            this.lbIdValue.UseCustomBackColor = true;
            this.lbIdValue.UseSelectable = true;
            this.lbIdValue.Visible = false;
            this.lbIdValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbIdValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frBusStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(654, 321);
            this.Controls.Add(this.lbIdValue);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbLoadItem);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbBusStationName);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbBusStation);
            this.Controls.Add(this.dgBusStation);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frBusStation";
            this.Text = "Bus Station";
            this.Load += new System.EventHandler(this.frBusStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBusStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbPage;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bCancel;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private MetroFramework.Controls.MetroLabel lbID;
        private MetroFramework.Controls.MetroLabel lbBusStationName;
        private System.Windows.Forms.Button bSave;
        private MetroFramework.Controls.MetroTextBox tbBusStation;
        private MetroFramework.Controls.MetroGrid dgBusStation;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbLocation;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbLoadItem;
        private MetroFramework.Controls.MetroTextBox lbIdValue;
    }
}