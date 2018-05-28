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
            this.iloscSamochodow = new System.Windows.Forms.Label();
            this.sr_konie_mech = new System.Windows.Forms.Label();
            this.sr_predkosc = new System.Windows.Forms.Label();
            this.sr_zuz_ben = new System.Windows.Forms.Label();
            this.sr_masa = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.iloscSamochodow);
            this.panel1.Controls.Add(this.sr_konie_mech);
            this.panel1.Controls.Add(this.sr_predkosc);
            this.panel1.Controls.Add(this.sr_zuz_ben);
            this.panel1.Controls.Add(this.sr_masa);
            this.panel1.Controls.Add(this.napisStatystyki);
            this.panel1.Location = new System.Drawing.Point(506, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 300);
            this.panel1.TabIndex = 3;
            // 
            // iloscSamochodow
            // 
            this.iloscSamochodow.AutoSize = true;
            this.iloscSamochodow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iloscSamochodow.Location = new System.Drawing.Point(15, 50);
            this.iloscSamochodow.Name = "iloscSamochodow";
            this.iloscSamochodow.Size = new System.Drawing.Size(89, 13);
            this.iloscSamochodow.TabIndex = 1;
            this.iloscSamochodow.Text = "Samochody 0/30";
            this.iloscSamochodow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sr_konie_mech
            // 
            this.sr_konie_mech.AutoSize = true;
            this.sr_konie_mech.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sr_konie_mech.Location = new System.Drawing.Point(15, 218);
            this.sr_konie_mech.Name = "sr_konie_mech";
            this.sr_konie_mech.Size = new System.Drawing.Size(79, 13);
            this.sr_konie_mech.TabIndex = 1;
            this.sr_konie_mech.Text = "sr. konie mech.";
            this.sr_konie_mech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sr_predkosc
            // 
            this.sr_predkosc.AutoSize = true;
            this.sr_predkosc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sr_predkosc.Location = new System.Drawing.Point(15, 176);
            this.sr_predkosc.Name = "sr_predkosc";
            this.sr_predkosc.Size = new System.Drawing.Size(65, 13);
            this.sr_predkosc.TabIndex = 1;
            this.sr_predkosc.Text = "sr. predkosc";
            this.sr_predkosc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sr_zuz_ben
            // 
            this.sr_zuz_ben.AutoSize = true;
            this.sr_zuz_ben.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sr_zuz_ben.Location = new System.Drawing.Point(15, 135);
            this.sr_zuz_ben.Name = "sr_zuz_ben";
            this.sr_zuz_ben.Size = new System.Drawing.Size(69, 13);
            this.sr_zuz_ben.TabIndex = 1;
            this.sr_zuz_ben.Text = "sr. zuz. benz.";
            this.sr_zuz_ben.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sr_masa
            // 
            this.sr_masa.AutoSize = true;
            this.sr_masa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sr_masa.Location = new System.Drawing.Point(15, 93);
            this.sr_masa.Name = "sr_masa";
            this.sr_masa.Size = new System.Drawing.Size(46, 13);
            this.sr_masa.TabIndex = 1;
            this.sr_masa.Text = "sr. masa";
            this.sr_masa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSamochodow);
            this.Controls.Add(this.ParkingZnak);
            this.Name = "GlowneOkno";
            this.Text = "GlowneOkno";
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
        private System.Windows.Forms.Label iloscSamochodow;
        private System.Windows.Forms.Label sr_masa;
        private System.Windows.Forms.Label sr_konie_mech;
        private System.Windows.Forms.Label sr_predkosc;
        private System.Windows.Forms.Label sr_zuz_ben;
    }
}