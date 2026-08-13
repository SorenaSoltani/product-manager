namespace WindowsFormsApp3
{
    partial class Form2
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
            this.nooshabe = new System.Windows.Forms.TextBox();
            this.chips = new System.Windows.Forms.TextBox();
            this.must = new System.Windows.Forms.TextBox();
            this.pofak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nooshabe
            // 
            this.nooshabe.Location = new System.Drawing.Point(199, 61);
            this.nooshabe.Name = "nooshabe";
            this.nooshabe.Size = new System.Drawing.Size(100, 20);
            this.nooshabe.TabIndex = 0;
            // 
            // chips
            // 
            this.chips.Location = new System.Drawing.Point(199, 152);
            this.chips.Name = "chips";
            this.chips.Size = new System.Drawing.Size(100, 20);
            this.chips.TabIndex = 1;
            this.chips.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // must
            // 
            this.must.Location = new System.Drawing.Point(199, 196);
            this.must.Name = "must";
            this.must.Size = new System.Drawing.Size(100, 20);
            this.must.TabIndex = 2;
            // 
            // pofak
            // 
            this.pofak.Location = new System.Drawing.Point(199, 109);
            this.pofak.Name = "pofak";
            this.pofak.Size = new System.Drawing.Size(100, 20);
            this.pofak.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نوشابه";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "پفک";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "چیپس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ماست";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pofak);
            this.Controls.Add(this.must);
            this.Controls.Add(this.chips);
            this.Controls.Add(this.nooshabe);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox nooshabe;
        public System.Windows.Forms.TextBox chips;
        public System.Windows.Forms.TextBox must;
        public System.Windows.Forms.TextBox pofak;
    }
}