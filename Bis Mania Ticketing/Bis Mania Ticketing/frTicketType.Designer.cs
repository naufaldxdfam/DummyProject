namespace Bis_Mania_Ticketing
{
    partial class frTicketType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbPage = new MetroFramework.Controls.MetroLabel();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lbID = new MetroFramework.Controls.MetroLabel();
            this.lbTicket = new MetroFramework.Controls.MetroLabel();
            this.bSave = new System.Windows.Forms.Button();
            this.tbTicket = new MetroFramework.Controls.MetroTextBox();
            this.dgTicket = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbLoadItem = new MetroFramework.Controls.MetroComboBox();
            this.lbIdValue = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPage
            // 
            this.lbPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPage.Location = new System.Drawing.Point(388, 251);
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
            this.bPrevious.Location = new System.Drawing.Point(323, 251);
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
            this.bNext.Location = new System.Drawing.Point(518, 251);
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
            this.bCancel.Location = new System.Drawing.Point(75, 114);
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
            // lbTicket
            // 
            this.lbTicket.AutoSize = true;
            this.lbTicket.BackColor = System.Drawing.Color.Transparent;
            this.lbTicket.Location = new System.Drawing.Point(8, 85);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(73, 19);
            this.lbTicket.TabIndex = 17;
            this.lbTicket.Text = "Ticket Type";
            this.lbTicket.UseCustomBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bSave.Location = new System.Drawing.Point(156, 114);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 16;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbTicket
            // 
            // 
            // 
            // 
            this.tbTicket.CustomButton.Image = null;
            this.tbTicket.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.tbTicket.CustomButton.Name = "";
            this.tbTicket.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTicket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTicket.CustomButton.TabIndex = 1;
            this.tbTicket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTicket.CustomButton.UseSelectable = true;
            this.tbTicket.CustomButton.Visible = false;
            this.tbTicket.Lines = new string[0];
            this.tbTicket.Location = new System.Drawing.Point(106, 85);
            this.tbTicket.MaxLength = 32767;
            this.tbTicket.Name = "tbTicket";
            this.tbTicket.PasswordChar = '\0';
            this.tbTicket.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTicket.SelectedText = "";
            this.tbTicket.SelectionLength = 0;
            this.tbTicket.SelectionStart = 0;
            this.tbTicket.Size = new System.Drawing.Size(125, 23);
            this.tbTicket.Style = MetroFramework.MetroColorStyle.Green;
            this.tbTicket.TabIndex = 14;
            this.tbTicket.UseSelectable = true;
            this.tbTicket.WaterMark = "Ticket Type";
            this.tbTicket.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTicket.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgTicket
            // 
            this.dgTicket.AllowUserToAddRows = false;
            this.dgTicket.AllowUserToDeleteRows = false;
            this.dgTicket.AllowUserToOrderColumns = true;
            this.dgTicket.AllowUserToResizeRows = false;
            this.dgTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTicket.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgTicket.EnableHeadersVisualStyles = false;
            this.dgTicket.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgTicket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgTicket.Location = new System.Drawing.Point(254, 35);
            this.dgTicket.MultiSelect = false;
            this.dgTicket.Name = "dgTicket";
            this.dgTicket.ReadOnly = true;
            this.dgTicket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTicket.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgTicket.RowHeadersVisible = false;
            this.dgTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTicket.Size = new System.Drawing.Size(388, 210);
            this.dgTicket.Style = MetroFramework.MetroColorStyle.Green;
            this.dgTicket.TabIndex = 15;
            this.dgTicket.TabStop = false;
            this.dgTicket.UseCustomBackColor = true;
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
            this.metroLabel1.TabIndex = 28;
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
            this.cbLoadItem.TabIndex = 27;
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
            this.lbIdValue.TabIndex = 102;
            this.lbIdValue.TabStop = false;
            this.lbIdValue.UseCustomBackColor = true;
            this.lbIdValue.UseSelectable = true;
            this.lbIdValue.Visible = false;
            this.lbIdValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbIdValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frTicketType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(654, 321);
            this.Controls.Add(this.lbIdValue);
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
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbTicket);
            this.Controls.Add(this.dgTicket);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frTicketType";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.frTicketType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTicket)).EndInit();
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
        private MetroFramework.Controls.MetroLabel lbTicket;
        private System.Windows.Forms.Button bSave;
        private MetroFramework.Controls.MetroTextBox tbTicket;
        private MetroFramework.Controls.MetroGrid dgTicket;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbLoadItem;
        private MetroFramework.Controls.MetroTextBox lbIdValue;



    }
}