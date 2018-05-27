namespace Parking_CS
{
    partial class GlowneOkno
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
            this.ParkingZnak = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingZnak)).BeginInit();
            this.SuspendLayout();
            // 
            // ParkingZnak
            // 
            this.ParkingZnak.Image = global::Parking_CS.Properties.Resources.znak;
            this.ParkingZnak.Location = new System.Drawing.Point(772, 12);
            this.ParkingZnak.Name = "ParkingZnak";
            this.ParkingZnak.Size = new System.Drawing.Size(100, 100);
            this.ParkingZnak.TabIndex = 0;
            this.ParkingZnak.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 473);
            this.panel1.TabIndex = 1;
            // 
            // GlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ParkingZnak);
            this.Name = "GlowneOkno";
            this.Text = "GlowneOkno";
            this.Load += new System.EventHandler(this.GlowneOkno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParkingZnak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ParkingZnak;
        private System.Windows.Forms.Panel panel1;
    }
}