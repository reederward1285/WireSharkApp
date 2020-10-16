namespace WireSharkApp
{
    partial class MainForm
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
            this.textBox_TypeInValueToShowOnMsgBox = new System.Windows.Forms.TextBox();
            this.label_TypeInValueToShowOnMsgBox = new System.Windows.Forms.Label();
            this.button_GenerateMsgBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_TypeInValueToShowOnMsgBox
            // 
            this.textBox_TypeInValueToShowOnMsgBox.Location = new System.Drawing.Point(12, 55);
            this.textBox_TypeInValueToShowOnMsgBox.Name = "textBox_TypeInValueToShowOnMsgBox";
            this.textBox_TypeInValueToShowOnMsgBox.Size = new System.Drawing.Size(695, 38);
            this.textBox_TypeInValueToShowOnMsgBox.TabIndex = 0;
            // 
            // label_TypeInValueToShowOnMsgBox
            // 
            this.label_TypeInValueToShowOnMsgBox.AutoSize = true;
            this.label_TypeInValueToShowOnMsgBox.Location = new System.Drawing.Point(3, 9);
            this.label_TypeInValueToShowOnMsgBox.Name = "label_TypeInValueToShowOnMsgBox";
            this.label_TypeInValueToShowOnMsgBox.Size = new System.Drawing.Size(0, 32);
            this.label_TypeInValueToShowOnMsgBox.TabIndex = 1;
            // 
            // button_GenerateMsgBox
            // 
            this.button_GenerateMsgBox.Location = new System.Drawing.Point(302, 149);
            this.button_GenerateMsgBox.Name = "button_GenerateMsgBox";
            this.button_GenerateMsgBox.Size = new System.Drawing.Size(425, 57);
            this.button_GenerateMsgBox.TabIndex = 2;
            this.button_GenerateMsgBox.Text = "Generate MessageBox";
            this.button_GenerateMsgBox.UseVisualStyleBackColor = true;
            this.button_GenerateMsgBox.Click += new System.EventHandler(this.Button_GenerateMsgBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(739, 218);
            this.Controls.Add(this.button_GenerateMsgBox);
            this.Controls.Add(this.label_TypeInValueToShowOnMsgBox);
            this.Controls.Add(this.textBox_TypeInValueToShowOnMsgBox);
            this.Name = "MainForm";
            this.Text = "WireShark Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TypeInValueToShowOnMsgBox;
        private System.Windows.Forms.Label label_TypeInValueToShowOnMsgBox;
        private System.Windows.Forms.Button button_GenerateMsgBox;
    }
}

