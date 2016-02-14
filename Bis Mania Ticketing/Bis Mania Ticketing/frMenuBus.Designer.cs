namespace Bis_Mania_Ticketing
{
    partial class frMenuBus
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.bBus = new System.Windows.Forms.Button();
            this.bOtobus = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.pnlTop.Controls.Add(this.bBus);
            this.pnlTop.Controls.Add(this.bOtobus);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(318, 39);
            this.pnlTop.TabIndex = 0;
            // 
            // bBus
            // 
            this.bBus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.bBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.bBus.FlatAppearance.BorderSize = 0;
            this.bBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.bBus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bBus.ForeColor = System.Drawing.Color.White;
            this.bBus.Location = new System.Drawing.Point(159, 0);
            this.bBus.Name = "bBus";
            this.bBus.Size = new System.Drawing.Size(147, 39);
            this.bBus.TabIndex = 1;
            this.bBus.Text = "Bus";
            this.bBus.UseVisualStyleBackColor = false;
            this.bBus.Click += new System.EventHandler(this.bBus_Click);
            // 
            // bOtobus
            // 
            this.bOtobus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bOtobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.bOtobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOtobus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.bOtobus.FlatAppearance.BorderSize = 0;
            this.bOtobus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.bOtobus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bOtobus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOtobus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bOtobus.ForeColor = System.Drawing.Color.White;
            this.bOtobus.Location = new System.Drawing.Point(12, 0);
            this.bOtobus.Name = "bOtobus";
            this.bOtobus.Size = new System.Drawing.Size(147, 39);
            this.bOtobus.TabIndex = 0;
            this.bOtobus.Text = "Otobus";
            this.bOtobus.UseVisualStyleBackColor = false;
            this.bOtobus.Click += new System.EventHandler(this.bOtobus_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 39);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(318, 57);
            this.pnlBody.TabIndex = 1;
            // 
            // frMenuBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(318, 96);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frMenuBus";
            this.Text = "Menu Bus";
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button bOtobus;
        private System.Windows.Forms.Button bBus;








    }
}