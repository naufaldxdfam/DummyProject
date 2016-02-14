namespace Bis_Mania_Ticketing
{
    partial class frMenuRoute
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.bRoute = new System.Windows.Forms.Button();
            this.bStation = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 39);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(318, 57);
            this.pnlBody.TabIndex = 3;
            // 
            // bRoute
            // 
            this.bRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.bRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.bRoute.FlatAppearance.BorderSize = 0;
            this.bRoute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.bRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRoute.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bRoute.ForeColor = System.Drawing.Color.White;
            this.bRoute.Location = new System.Drawing.Point(159, 0);
            this.bRoute.Name = "bRoute";
            this.bRoute.Size = new System.Drawing.Size(147, 39);
            this.bRoute.TabIndex = 1;
            this.bRoute.Text = "Route";
            this.bRoute.UseVisualStyleBackColor = false;
            this.bRoute.Click += new System.EventHandler(this.bRoute_Click);
            // 
            // bStation
            // 
            this.bStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.bStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.bStation.FlatAppearance.BorderSize = 0;
            this.bStation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.bStation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStation.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bStation.ForeColor = System.Drawing.Color.White;
            this.bStation.Location = new System.Drawing.Point(12, 0);
            this.bStation.Name = "bStation";
            this.bStation.Size = new System.Drawing.Size(147, 39);
            this.bStation.TabIndex = 0;
            this.bStation.Text = "Bus Station";
            this.bStation.UseVisualStyleBackColor = false;
            this.bStation.Click += new System.EventHandler(this.bStation_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.pnlTop.Controls.Add(this.bRoute);
            this.pnlTop.Controls.Add(this.bStation);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(318, 39);
            this.pnlTop.TabIndex = 2;
            // 
            // frMenuRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(318, 96);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frMenuRoute";
            this.Text = "Menu Route";
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button bRoute;
        private System.Windows.Forms.Button bStation;
        private System.Windows.Forms.Panel pnlTop;
    }
}