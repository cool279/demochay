namespace demochoi
{
    partial class Form1
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
            this.btn = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thu lam demo cong hai so";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(143, 92);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(115, 28);
            this.btn.TabIndex = 1;
            this.btn.Text = "tru";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(67, 53);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(247, 53);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 3;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(158, 170);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 301);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
    }
}

