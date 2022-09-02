namespace ENUM
{
    partial class SumValue
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnsum = new System.Windows.Forms.Button();
            this.grab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num1.Location = new System.Drawing.Point(0, 3);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(93, 25);
            this.num1.TabIndex = 0;
            this.num1.Text = "Value 1:";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num2.Location = new System.Drawing.Point(0, 108);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(93, 25);
            this.num2.TabIndex = 1;
            this.num2.Text = "Value 2:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(92, 0);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(688, 30);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(92, 108);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(688, 30);
            this.txt2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(12, 191);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(791, 290);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnsum
            // 
            this.btnsum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsum.Location = new System.Drawing.Point(808, 100);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(154, 40);
            this.btnsum.TabIndex = 6;
            this.btnsum.Text = "SUM";
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // grab
            // 
            this.grab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grab.Location = new System.Drawing.Point(12, 487);
            this.grab.Name = "grab";
            this.grab.Size = new System.Drawing.Size(280, 40);
            this.grab.TabIndex = 7;
            this.grab.Text = "Grab Sum Value";
            this.grab.UseVisualStyleBackColor = false;
            this.grab.Click += new System.EventHandler(this.button1_Click);
            // 
            // SumValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.grab);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SumValue";
            this.Text = "SumValue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SumValue_FormClosing);
            this.Load += new System.EventHandler(this.SumValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button grab;
    }
}