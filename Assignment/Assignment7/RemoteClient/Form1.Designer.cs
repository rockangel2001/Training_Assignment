
namespace RemoteClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputnum1 = new System.Windows.Forms.TextBox();
            this.inputnum2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.btnhighestnumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Num 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Num 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // inputnum1
            // 
            this.inputnum1.Location = new System.Drawing.Point(454, 53);
            this.inputnum1.Name = "inputnum1";
            this.inputnum1.Size = new System.Drawing.Size(100, 26);
            this.inputnum1.TabIndex = 3;
            // 
            // inputnum2
            // 
            this.inputnum2.Location = new System.Drawing.Point(454, 132);
            this.inputnum2.Name = "inputnum2";
            this.inputnum2.Size = new System.Drawing.Size(100, 26);
            this.inputnum2.TabIndex = 4;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(425, 355);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(141, 26);
            this.result.TabIndex = 5;
            // 
            // btnhighestnumber
            // 
            this.btnhighestnumber.Location = new System.Drawing.Point(466, 249);
            this.btnhighestnumber.Name = "btnhighestnumber";
            this.btnhighestnumber.Size = new System.Drawing.Size(75, 36);
            this.btnhighestnumber.TabIndex = 6;
            this.btnhighestnumber.Text = "Click";
            this.btnhighestnumber.UseVisualStyleBackColor = true;
            this.btnhighestnumber.Click += new System.EventHandler(this.btnhighestnumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhighestnumber);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputnum2);
            this.Controls.Add(this.inputnum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputnum1;
        private System.Windows.Forms.TextBox inputnum2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btnhighestnumber;
    }
}

