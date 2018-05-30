namespace Parking_CS
{
    partial class Sportowy
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
            this.nitroTB = new System.Windows.Forms.TextBox();
            this.nitroTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nitroTB
            // 
            this.nitroTB.Location = new System.Drawing.Point(12, 245);
            this.nitroTB.Name = "nitroTB";
            this.nitroTB.Size = new System.Drawing.Size(100, 20);
            this.nitroTB.TabIndex = 0;
            this.nitroTB.Text = "100";
            // 
            // nitroTxt
            // 
            this.nitroTxt.AutoSize = true;
            this.nitroTxt.Location = new System.Drawing.Point(9, 229);
            this.nitroTxt.Name = "nitroTxt";
            this.nitroTxt.Size = new System.Drawing.Size(29, 13);
            this.nitroTxt.TabIndex = 3;
            this.nitroTxt.Text = "Nitro";
            // 
            // Sportowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.nitroTxt);
            this.Controls.Add(this.nitroTB);
            this.Name = "Sportowy";
            this.Text = "Sportowy";
            this.Load += new System.EventHandler(this.Sportowy_Load);
            this.Controls.SetChildIndex(this.nitroTB, 0);
            this.Controls.SetChildIndex(this.nitroTxt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nitroTB;
        private System.Windows.Forms.Label nitroTxt;
    }
}