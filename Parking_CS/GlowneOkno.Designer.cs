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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.panelSamochodow = new System.Windows.Forms.Panel();
            this.Osobowy = new System.Windows.Forms.Button();
            this.Ciezarowy = new System.Windows.Forms.Button();
            this.Sportowy = new System.Windows.Forms.Button();
            this.ParkingZnak = new System.Windows.Forms.PictureBox();
            this.panelSamochodow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingZnak)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonPanel.Location = new System.Drawing.Point(12, 12);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(365, 473);
            this.buttonPanel.TabIndex = 1;
            // 
            // panelSamochodow
            // 
            this.panelSamochodow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelSamochodow.Controls.Add(this.Osobowy);
            this.panelSamochodow.Controls.Add(this.Ciezarowy);
            this.panelSamochodow.Controls.Add(this.Sportowy);
            this.panelSamochodow.Location = new System.Drawing.Point(506, 12);
            this.panelSamochodow.Name = "panelSamochodow";
            this.panelSamochodow.Size = new System.Drawing.Size(202, 140);
            this.panelSamochodow.TabIndex = 2;
            // 
            // Osobowy
            // 
            this.Osobowy.Image = global::Parking_CS.Properties.Resources.osobowy;
            this.Osobowy.Location = new System.Drawing.Point(130, 20);
            this.Osobowy.Name = "Osobowy";
            this.Osobowy.Size = new System.Drawing.Size(50, 100);
            this.Osobowy.TabIndex = 0;
            this.Osobowy.UseVisualStyleBackColor = true;
            this.Osobowy.Click += new System.EventHandler(this.Osobowy_Click);
            // 
            // Ciezarowy
            // 
            this.Ciezarowy.Image = global::Parking_CS.Properties.Resources.Ciezarowka;
            this.Ciezarowy.Location = new System.Drawing.Point(74, 20);
            this.Ciezarowy.Name = "Ciezarowy";
            this.Ciezarowy.Size = new System.Drawing.Size(50, 100);
            this.Ciezarowy.TabIndex = 0;
            this.Ciezarowy.UseVisualStyleBackColor = true;
            this.Ciezarowy.Click += new System.EventHandler(this.Ciezarowy_Click);
            // 
            // Sportowy
            // 
            this.Sportowy.Image = global::Parking_CS.Properties.Resources.Sport;
            this.Sportowy.Location = new System.Drawing.Point(18, 20);
            this.Sportowy.Name = "Sportowy";
            this.Sportowy.Size = new System.Drawing.Size(50, 100);
            this.Sportowy.TabIndex = 0;
            this.Sportowy.UseVisualStyleBackColor = true;
            this.Sportowy.Click += new System.EventHandler(this.Sportowy_Click);
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
            // GlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.panelSamochodow);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.ParkingZnak);
            this.Name = "GlowneOkno";
            this.Text = "GlowneOkno";
            this.panelSamochodow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParkingZnak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ParkingZnak;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel panelSamochodow;
        private System.Windows.Forms.Button Sportowy;
        private System.Windows.Forms.Button Osobowy;
        private System.Windows.Forms.Button Ciezarowy;
    }
}