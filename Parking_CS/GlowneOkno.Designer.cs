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
            this.panelSamochodow = new System.Windows.Forms.Panel();
            this.Osobowy = new System.Windows.Forms.Button();
            this.Ciezarowy = new System.Windows.Forms.Button();
            this.Sportowy = new System.Windows.Forms.Button();
            this.ParkingZnak = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ileZaparkowanychTxt = new System.Windows.Forms.Label();
            this.konieMechTxt = new System.Windows.Forms.Label();
            this.predkoscTxt = new System.Windows.Forms.Label();
            this.zuzBenTxt = new System.Windows.Forms.Label();
            this.masaTxt = new System.Windows.Forms.Label();
            this.napisStatystyki = new System.Windows.Forms.Label();
            this.panelSamochodow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingZnak)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Osobowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.Ciezarowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.Sportowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.ileZaparkowanychTxt);
            this.panel1.Controls.Add(this.konieMechTxt);
            this.panel1.Controls.Add(this.predkoscTxt);
            this.panel1.Controls.Add(this.zuzBenTxt);
            this.panel1.Controls.Add(this.masaTxt);
            this.panel1.Controls.Add(this.napisStatystyki);
            this.panel1.Location = new System.Drawing.Point(506, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 300);
            this.panel1.TabIndex = 3;
            // 
            // ileZaparkowanychTxt
            // 
            this.ileZaparkowanychTxt.AutoSize = true;
            this.ileZaparkowanychTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ileZaparkowanychTxt.Location = new System.Drawing.Point(15, 50);
            this.ileZaparkowanychTxt.Name = "ileZaparkowanychTxt";
            this.ileZaparkowanychTxt.Size = new System.Drawing.Size(89, 13);
            this.ileZaparkowanychTxt.TabIndex = 1;
            this.ileZaparkowanychTxt.Text = "Samochody 0/30";
            this.ileZaparkowanychTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // konieMechTxt
            // 
            this.konieMechTxt.AutoSize = true;
            this.konieMechTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.konieMechTxt.Location = new System.Drawing.Point(15, 218);
            this.konieMechTxt.Name = "konieMechTxt";
            this.konieMechTxt.Size = new System.Drawing.Size(97, 13);
            this.konieMechTxt.TabIndex = 1;
            this.konieMechTxt.Text = "sr. konie mech. = 0";
            this.konieMechTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // predkoscTxt
            // 
            this.predkoscTxt.AutoSize = true;
            this.predkoscTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.predkoscTxt.Location = new System.Drawing.Point(15, 176);
            this.predkoscTxt.Name = "predkoscTxt";
            this.predkoscTxt.Size = new System.Drawing.Size(83, 13);
            this.predkoscTxt.TabIndex = 1;
            this.predkoscTxt.Text = "sr. predkosc = 0";
            this.predkoscTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zuzBenTxt
            // 
            this.zuzBenTxt.AutoSize = true;
            this.zuzBenTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zuzBenTxt.Location = new System.Drawing.Point(15, 135);
            this.zuzBenTxt.Name = "zuzBenTxt";
            this.zuzBenTxt.Size = new System.Drawing.Size(87, 13);
            this.zuzBenTxt.TabIndex = 1;
            this.zuzBenTxt.Text = "sr. zuz. benz. = 0";
            this.zuzBenTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // masaTxt
            // 
            this.masaTxt.AutoSize = true;
            this.masaTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.masaTxt.Location = new System.Drawing.Point(15, 93);
            this.masaTxt.Name = "masaTxt";
            this.masaTxt.Size = new System.Drawing.Size(64, 13);
            this.masaTxt.TabIndex = 1;
            this.masaTxt.Text = "sr. masa = 0";
            this.masaTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // napisStatystyki
            // 
            this.napisStatystyki.AutoSize = true;
            this.napisStatystyki.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.napisStatystyki.Location = new System.Drawing.Point(75, 10);
            this.napisStatystyki.Name = "napisStatystyki";
            this.napisStatystyki.Size = new System.Drawing.Size(52, 13);
            this.napisStatystyki.TabIndex = 1;
            this.napisStatystyki.Text = "Statystyki";
            this.napisStatystyki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSamochodow);
            this.Controls.Add(this.ParkingZnak);
            this.Name = "GlowneOkno";
            this.Text = "GlowneOkno";
            this.Load += new System.EventHandler(this.GlowneOkno_Load);
            this.panelSamochodow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParkingZnak)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ParkingZnak;
        private System.Windows.Forms.Panel panelSamochodow;
        private System.Windows.Forms.Button Sportowy;
        private System.Windows.Forms.Button Osobowy;
        private System.Windows.Forms.Button Ciezarowy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label napisStatystyki;
        private System.Windows.Forms.Label ileZaparkowanychTxt;
        private System.Windows.Forms.Label masaTxt;
        private System.Windows.Forms.Label konieMechTxt;
        private System.Windows.Forms.Label predkoscTxt;
        private System.Windows.Forms.Label zuzBenTxt;
    }
}