namespace Parking_CS
{
    partial class SportowyOkno
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
            this.nitro = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nitro
            // 
            this.nitro.AutoSize = true;
            this.nitro.Location = new System.Drawing.Point(12, 197);
            this.nitro.Name = "nitro";
            this.nitro.Size = new System.Drawing.Size(27, 13);
            this.nitro.TabIndex = 2;
            this.nitro.Text = "nitro";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 213);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 20);
            this.textBox5.TabIndex = 3;
            // 
            // SportowyOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.nitro);
            this.Name = "SportowyOkno";
            this.Text = "SportowyOkno";
            this.Load += new System.EventHandler(this.SportowyOkno_Load);
            this.Controls.SetChildIndex(this.nitro, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nitro;
        private System.Windows.Forms.TextBox textBox5;
    }
}