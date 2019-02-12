namespace InheritPrac
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Cat_Shout = new System.Windows.Forms.Button();
            this.Button_Dog_Shout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Cat_Shout
            // 
            this.Button_Cat_Shout.Location = new System.Drawing.Point(12, 26);
            this.Button_Cat_Shout.Name = "Button_Cat_Shout";
            this.Button_Cat_Shout.Size = new System.Drawing.Size(75, 23);
            this.Button_Cat_Shout.TabIndex = 0;
            this.Button_Cat_Shout.Text = "貓叫";
            this.Button_Cat_Shout.UseVisualStyleBackColor = true;
            this.Button_Cat_Shout.Click += new System.EventHandler(this.Button_Cat_Shout_Click);
            // 
            // Button_Dog_Shout
            // 
            this.Button_Dog_Shout.Location = new System.Drawing.Point(93, 26);
            this.Button_Dog_Shout.Name = "Button_Dog_Shout";
            this.Button_Dog_Shout.Size = new System.Drawing.Size(75, 23);
            this.Button_Dog_Shout.TabIndex = 1;
            this.Button_Dog_Shout.Text = "狗叫";
            this.Button_Dog_Shout.UseVisualStyleBackColor = true;
            this.Button_Dog_Shout.Click += new System.EventHandler(this.Button_Dog_Shout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.Button_Dog_Shout);
            this.Controls.Add(this.Button_Cat_Shout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Cat_Shout;
        private System.Windows.Forms.Button Button_Dog_Shout;
    }
}

