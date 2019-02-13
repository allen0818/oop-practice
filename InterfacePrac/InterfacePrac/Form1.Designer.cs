namespace InterfacePrac
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
            this.Button_ChangeThing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_ChangeThing
            // 
            this.Button_ChangeThing.Location = new System.Drawing.Point(13, 13);
            this.Button_ChangeThing.Name = "Button_ChangeThing";
            this.Button_ChangeThing.Size = new System.Drawing.Size(75, 23);
            this.Button_ChangeThing.TabIndex = 0;
            this.Button_ChangeThing.Text = "變出東西";
            this.Button_ChangeThing.UseVisualStyleBackColor = true;
            this.Button_ChangeThing.Click += new System.EventHandler(this.Button_ChangeThing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 56);
            this.Controls.Add(this.Button_ChangeThing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_ChangeThing;
    }
}

