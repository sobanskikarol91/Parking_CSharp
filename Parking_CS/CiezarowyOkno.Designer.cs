namespace Parking_CS
{
    partial class CiezarowyOkno
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
            this.label1 = new System.Windows.Forms.Label();
            this.zaladunek = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // zaladunek
            // 
            this.zaladunek.AutoSize = true;
            this.zaladunek.Location = new System.Drawing.Point(12, 196);
            this.zaladunek.Name = "zaladunek";
            this.zaladunek.Size = new System.Drawing.Size(56, 13);
            this.zaladunek.TabIndex = 3;
            this.zaladunek.Text = "zaladunek";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 212);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 20);
            this.textBox5.TabIndex = 4;
            // 
            // CiezarowyOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.zaladunek);
            this.Controls.Add(this.label1);
            this.Name = "CiezarowyOkno";
            this.Text = "CiezarowyOkno";
            this.Load += new System.EventHandler(this.CiezarowyOkno_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.zaladunek, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zaladunek;
        private System.Windows.Forms.TextBox textBox5;
    }
}