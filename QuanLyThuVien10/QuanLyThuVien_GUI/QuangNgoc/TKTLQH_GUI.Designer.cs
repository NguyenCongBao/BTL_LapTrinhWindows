namespace QuanLyThuVien_GUI.QuangNgoc
{
    partial class TKTLQH_GUI
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
            this.viewTKTLQH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // viewTKTLQH
            // 
            this.viewTKTLQH.ActiveViewIndex = -1;
            this.viewTKTLQH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewTKTLQH.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewTKTLQH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTKTLQH.Location = new System.Drawing.Point(0, 0);
            this.viewTKTLQH.Name = "viewTKTLQH";
            this.viewTKTLQH.Size = new System.Drawing.Size(800, 450);
            this.viewTKTLQH.TabIndex = 0;
            // 
            // TKTLQH_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewTKTLQH);
            this.Name = "TKTLQH_GUI";
            this.Text = "TKTLQH_GUI";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer viewTKTLQH;
    }
}