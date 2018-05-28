namespace Parking_CS
{
    partial class SamochodOkno
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masa = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.konieMech = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.zuzucieBenzyny = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.predkosc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // masa
            // 
            this.masa.AutoSize = true;
            this.masa.Location = new System.Drawing.Point(12, 9);
            this.masa.Name = "masa";
            this.masa.Size = new System.Drawing.Size(33, 13);
            this.masa.TabIndex = 1;
            this.masa.Text = "Masa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 0;
            // 
            // konieMech
            // 
            this.konieMech.AutoSize = true;
            this.konieMech.Location = new System.Drawing.Point(12, 52);
            this.konieMech.Name = "konieMech";
            this.konieMech.Size = new System.Drawing.Size(104, 13);
            this.konieMech.TabIndex = 1;
            this.konieMech.Text = "Konie Mechaniczne:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 0;
            // 
            // zuzucieBenzyny
            // 
            this.zuzucieBenzyny.AutoSize = true;
            this.zuzucieBenzyny.Location = new System.Drawing.Point(12, 99);
            this.zuzucieBenzyny.Name = "zuzucieBenzyny";
            this.zuzucieBenzyny.Size = new System.Drawing.Size(90, 13);
            this.zuzucieBenzyny.TabIndex = 1;
            this.zuzucieBenzyny.Text = "Zurzycie Benzyny";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 20);
            this.textBox4.TabIndex = 0;
            // 
            // predkosc
            // 
            this.predkosc.AutoSize = true;
            this.predkosc.Location = new System.Drawing.Point(12, 147);
            this.predkosc.Name = "predkosc";
            this.predkosc.Size = new System.Drawing.Size(52, 13);
            this.predkosc.TabIndex = 1;
            this.predkosc.Text = "Predkosc";
            // 
            // SamochodOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.predkosc);
            this.Controls.Add(this.zuzucieBenzyny);
            this.Controls.Add(this.konieMech);
            this.Controls.Add(this.masa);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "SamochodOkno";
            this.Text = "SamochodOkno";
            this.Load += new System.EventHandler(this.SamochodOkno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label masa;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label konieMech;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label zuzucieBenzyny;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label predkosc;
    }
}