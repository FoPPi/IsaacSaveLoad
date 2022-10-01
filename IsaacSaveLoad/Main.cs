using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IsaacSaveLoad
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                CopyDir(FindeIsaacSaves(), @"Saves");
                LoadedPicture.Visible = false;
                SavedPicture.Visible = true;
                AsyncTimerOfVisible(SavedPicture);
            }
            catch
            {

            }

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                CopyDir(@"Saves", FindeIsaacSaves());
                SavedPicture.Visible = false;
                LoadedPicture.Visible = true;
                AsyncTimerOfVisible(LoadedPicture);
            }
            catch
            {

            }
        }

        private void CloseLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private async Task AsyncTimerOfVisible(PictureBox picture)
        {
            await Task.Delay(5000);
            picture.Visible = false;
        }

        private static string FindeIsaacSaves()
        {
            String query = @"%USERPROFILE%\Documents\My Games\Binding of Isaac Repentance";
            String str = Environment.ExpandEnvironmentVariables(query);
            return str;
        }

        private void CopyDir(string FromDir, string ToDir)
        {
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                if (Path.GetFileName(s1) != "log.txt")
                {
                    string s2 = ToDir + "\\" + Path.GetFileName(s1);
                    File.Copy(s1, s2, true);
                }
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }



        //двигалка
        private int x = 0; private int y = 0;
        private void MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }
        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        //появление и исчезновения указателя возле кнопки save
        private void SaveButton_MouseMove(object sender, MouseEventArgs e)
        {
            SelectSavePicture.Visible = true;
        }
        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            SelectSavePicture.Visible = false;
        }

        //появление и исчезновения указателя возле кнопки load
        private void LoadButton_MouseMove(object sender, MouseEventArgs e)
        {
            SelectLoadPicture.Visible = true;
        }
        private void LoadButton_MouseLeave(object sender, EventArgs e)
        {
            SelectLoadPicture.Visible = false;
        }
    }
}
