namespace WindowsFormsApp3
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mojoodiNooshabe = new System.Windows.Forms.Label();
            this.mojoodiChips = new System.Windows.Forms.Label();
            this.mojoodiPofak = new System.Windows.Forms.Label();
            this.mojoodiMust = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "نوشابه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "پفک";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "چیپس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ماست";
            // 
            // mojoodiNooshabe
            // 
            this.mojoodiNooshabe.AutoSize = true;
            this.mojoodiNooshabe.Location = new System.Drawing.Point(203, 109);
            this.mojoodiNooshabe.Name = "mojoodiNooshabe";
            this.mojoodiNooshabe.Size = new System.Drawing.Size(0, 13);
            this.mojoodiNooshabe.TabIndex = 9;
            // 
            // mojoodiChips
            // 
            this.mojoodiChips.AutoSize = true;
            this.mojoodiChips.Location = new System.Drawing.Point(203, 171);
            this.mojoodiChips.Name = "mojoodiChips";
            this.mojoodiChips.Size = new System.Drawing.Size(0, 13);
            this.mojoodiChips.TabIndex = 10;
            // 
            // mojoodiPofak
            // 
            this.mojoodiPofak.AutoSize = true;
            this.mojoodiPofak.Location = new System.Drawing.Point(203, 140);
            this.mojoodiPofak.Name = "mojoodiPofak";
            this.mojoodiPofak.Size = new System.Drawing.Size(0, 13);
            this.mojoodiPofak.TabIndex = 11;
            // 
            // mojoodiMust
            // 
            this.mojoodiMust.AutoSize = true;
            this.mojoodiMust.Location = new System.Drawing.Point(203, 204);
            this.mojoodiMust.Name = "mojoodiMust";
            this.mojoodiMust.Size = new System.Drawing.Size(0, 13);
            this.mojoodiMust.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 383);
            this.Controls.Add(this.mojoodiMust);
            this.Controls.Add(this.mojoodiPofak);
            this.Controls.Add(this.mojoodiChips);
            this.Controls.Add(this.mojoodiNooshabe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label mojoodiNooshabe;
        public System.Windows.Forms.Label mojoodiChips;
        public System.Windows.Forms.Label mojoodiPofak;
        public System.Windows.Forms.Label mojoodiMust;
    }
}