namespace BootOtherUserProcess
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this._buttonBoot = new System.Windows.Forms.Button();
            this._textBoxUserName = new System.Windows.Forms.TextBox();
            this._textBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _buttonBoot
            // 
            this._buttonBoot.Location = new System.Drawing.Point(12, 85);
            this._buttonBoot.Name = "_buttonBoot";
            this._buttonBoot.Size = new System.Drawing.Size(150, 23);
            this._buttonBoot.TabIndex = 2;
            this._buttonBoot.Text = "プロセス起動";
            this._buttonBoot.UseVisualStyleBackColor = true;
            this._buttonBoot.Click += new System.EventHandler(this._buttonBoot_Click);
            // 
            // _textBoxUserName
            // 
            this._textBoxUserName.Location = new System.Drawing.Point(80, 12);
            this._textBoxUserName.Name = "_textBoxUserName";
            this._textBoxUserName.Size = new System.Drawing.Size(150, 19);
            this._textBoxUserName.TabIndex = 0;
            // 
            // _textBoxPass
            // 
            this._textBoxPass.Location = new System.Drawing.Point(80, 40);
            this._textBoxPass.Name = "_textBoxPass";
            this._textBoxPass.PasswordChar = '*';
            this._textBoxPass.Size = new System.Drawing.Size(150, 19);
            this._textBoxPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ユーザー名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "パスワード:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxPass);
            this.Controls.Add(this._textBoxUserName);
            this.Controls.Add(this._buttonBoot);
            this.Name = "Form1";
            this.Text = "別ユーザーでプロセス起動";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonBoot;
        private System.Windows.Forms.TextBox _textBoxUserName;
        private System.Windows.Forms.TextBox _textBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

