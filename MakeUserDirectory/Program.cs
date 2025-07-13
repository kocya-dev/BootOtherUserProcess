using System;
using System.Windows.Forms;

namespace MakeUserDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 現在ログイン中のユーザーのホームディレクトリを取得
            string userHomeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            MessageBox.Show(userHomeDirectory, "User Home Directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
