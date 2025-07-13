using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootOtherUserProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _buttonBoot_Click(object sender, EventArgs e)
        {
            // 起動するユーザーを指定してMakeUserDirectory.exeを起動
            string userName = _textBoxUserName.Text.Trim();
            string password = _textBoxPass.Text;
            
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("ユーザー名を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("パスワードを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                // SecureStringを使用してパスワードを安全に処理
                System.Security.SecureString securePassword = new System.Security.SecureString();
                foreach (char c in password)
                {
                    securePassword.AppendChar(c);
                }
                securePassword.MakeReadOnly();

                // MakeUserDirectory.exeを別ユーザーとして起動
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "MakeUserDirectory.exe",
                    UseShellExecute = false,
                    UserName = userName,
                    Password = securePassword,
                    Domain = Environment.MachineName, // ローカルマシンのドメインを使用
                    LoadUserProfile = true // ユーザープロファイルを読み込む
                };
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"プロセスの起動に失敗しました: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
