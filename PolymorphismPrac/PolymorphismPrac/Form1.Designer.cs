namespace PolymorphismPrac
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
            this.Button_SignUp = new System.Windows.Forms.Button();
            this.Button_ShoutGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_SignUp
            // 
            this.Button_SignUp.Location = new System.Drawing.Point(23, 26);
            this.Button_SignUp.Name = "Button_SignUp";
            this.Button_SignUp.Size = new System.Drawing.Size(75, 23);
            this.Button_SignUp.TabIndex = 0;
            this.Button_SignUp.Text = "動物報名";
            this.Button_SignUp.UseVisualStyleBackColor = true;
            this.Button_SignUp.Click += new System.EventHandler(this.Button_SignUp_Click);
            // 
            // Button_ShoutGame
            // 
            this.Button_ShoutGame.Location = new System.Drawing.Point(113, 26);
            this.Button_ShoutGame.Name = "Button_ShoutGame";
            this.Button_ShoutGame.Size = new System.Drawing.Size(75, 23);
            this.Button_ShoutGame.TabIndex = 1;
            this.Button_ShoutGame.Text = "叫聲比賽";
            this.Button_ShoutGame.UseVisualStyleBackColor = true;
            this.Button_ShoutGame.Click += new System.EventHandler(this.Button_ShoutGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 68);
            this.Controls.Add(this.Button_ShoutGame);
            this.Controls.Add(this.Button_SignUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_SignUp;
        private System.Windows.Forms.Button Button_ShoutGame;
    }
}

