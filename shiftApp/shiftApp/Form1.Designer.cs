namespace shiftApp
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
            this.rotateBtn = new System.Windows.Forms.Button();
            this.TxtNumberToBeRotated = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumberForRotation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRightRotatedNumber = new System.Windows.Forms.TextBox();
            this.TxtLeftRotatedNumber = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rotateBtn
            // 
            this.rotateBtn.Location = new System.Drawing.Point(208, 158);
            this.rotateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(100, 28);
            this.rotateBtn.TabIndex = 0;
            this.rotateBtn.Text = "Rotate";
            this.rotateBtn.UseVisualStyleBackColor = true;
            this.rotateBtn.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // TxtNumberToBeRotated
            // 
            this.TxtNumberToBeRotated.Location = new System.Drawing.Point(74, 63);
            this.TxtNumberToBeRotated.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumberToBeRotated.MaxLength = 4;
            this.TxtNumberToBeRotated.Name = "TxtNumberToBeRotated";
            this.TxtNumberToBeRotated.Size = new System.Drawing.Size(63, 22);
            this.TxtNumberToBeRotated.TabIndex = 1;
            this.TxtNumberToBeRotated.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberToBeRotated_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the number to be rotated";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the bitwise rotation number";
            // 
            // TxtNumberForRotation
            // 
            this.TxtNumberForRotation.Location = new System.Drawing.Point(74, 120);
            this.TxtNumberForRotation.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumberForRotation.MaxLength = 1;
            this.TxtNumberForRotation.Name = "TxtNumberForRotation";
            this.TxtNumberForRotation.Size = new System.Drawing.Size(63, 22);
            this.TxtNumberForRotation.TabIndex = 6;
            this.TxtNumberForRotation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberForRotation_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(245, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "=>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number after bitwise left rotation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number after bitwise right rotation";
            // 
            // TxtRightRotatedNumber
            // 
            this.TxtRightRotatedNumber.Enabled = false;
            this.TxtRightRotatedNumber.Location = new System.Drawing.Point(355, 63);
            this.TxtRightRotatedNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRightRotatedNumber.Name = "TxtRightRotatedNumber";
            this.TxtRightRotatedNumber.Size = new System.Drawing.Size(63, 22);
            this.TxtRightRotatedNumber.TabIndex = 12;
            // 
            // TxtLeftRotatedNumber
            // 
            this.TxtLeftRotatedNumber.Enabled = false;
            this.TxtLeftRotatedNumber.Location = new System.Drawing.Point(355, 120);
            this.TxtLeftRotatedNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLeftRotatedNumber.Name = "TxtLeftRotatedNumber";
            this.TxtLeftRotatedNumber.Size = new System.Drawing.Size(63, 22);
            this.TxtLeftRotatedNumber.TabIndex = 13;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(208, 194);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Round robin bitwise rotation of Hexadecimal number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.TxtLeftRotatedNumber);
            this.Controls.Add(this.TxtRightRotatedNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNumberForRotation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNumberToBeRotated);
            this.Controls.Add(this.rotateBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rotateBtn;
        private System.Windows.Forms.TextBox TxtNumberToBeRotated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNumberForRotation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtRightRotatedNumber;
        private System.Windows.Forms.TextBox TxtLeftRotatedNumber;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label2;
    }
}

