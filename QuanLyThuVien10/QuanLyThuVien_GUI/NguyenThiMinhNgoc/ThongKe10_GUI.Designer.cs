namespace QuanLyThuVien_GUI.NguyenThiMinhNgoc
{
    partial class ThongKe10_GUI
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
            this.crview1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crview1
            // 
            this.crview1.ActiveViewIndex = -1;
            this.crview1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crview1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crview1.Location = new System.Drawing.Point(0, 0);
            this.crview1.Name = "crview1";
            this.crview1.Size = new System.Drawing.Size(800, 450);
            this.crview1.TabIndex = 0;
            // 
            // ThongKe10_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crview1);
            this.Name = "ThongKe10_GUI";
            this.Text = "ThongKe10_GUI";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crview1;
    }
}