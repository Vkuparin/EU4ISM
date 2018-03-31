using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using System.Windows.Forms;

namespace EU4_Ironman_Save_Manager
{
    /// <summary>
    /// Interaction logic for SaveWindow.xaml
    /// </summary>
    /// 

    public partial class UserLoadWindow : Window
    {

        public UserLoadWindow()
        {
            InitializeComponent();
            SaveFolderName.Text = MainWindow.ReadSetting("copysavefolder");
            EnterToLoad.Content = "Press Enter to load save";
            CenterWindowOnScreen();
        }

        //Path to the save file the user selects in the dialog
        string sSelectedFile = "";
        //Name of the save file + extension that the user selects in the dialog
        string sSelectedFileName = "";

        //Replace the current save file with the one that the user selects in the dialog, also delete Backup save
        private void Load()
        {
            string savename = MainWindow.ReadSetting("savename") + ".eu4";
            string backupsavename = MainWindow.ReadSetting("savename") + "_Backup.eu4";
            string loadsavename = sSelectedFileName;
            string source = MainWindow.ReadSetting("copysavefolder");
            string target = MainWindow.ReadSetting("savefolder");
            string sourceFile = System.IO.Path.Combine(source, loadsavename);
            string destFile = System.IO.Path.Combine(target, savename);
            string backupPath = System.IO.Path.Combine(target, backupsavename);
            System.IO.File.Copy(sourceFile, destFile, true);
            System.IO.File.Delete(backupPath);
        }

        //Open file selection dialog and put the resulting folder to text field
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog loadfilename = new OpenFileDialog();
            Keyboard.Focus(SaveFolderName);
            if (MainWindow.ReadSetting("copysavefolder").Equals(MainWindow.ReadSetting("savefolder")))
            {
                loadfilename.InitialDirectory = MainWindow.ReadSetting("savefolder");
            }
            else
            {
                loadfilename.InitialDirectory = MainWindow.ReadSetting("copysavefolder");
            }
            loadfilename.Filter = "All Files (*.eu4)|*.eu4";
            loadfilename.FilterIndex = 1;
            loadfilename.Multiselect = false;
            if (loadfilename.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sSelectedFile = loadfilename.FileName;
                sSelectedFileName = loadfilename.SafeFileName;
                SaveFolderName.Text = System.IO.Path.GetDirectoryName(sSelectedFile);
                string savelocation = System.IO.Path.GetDirectoryName(sSelectedFile) + @"\";
                MainWindow.UpdateConfig("copysavefolder", savelocation);
            }
            else
            {
                sSelectedFile = string.Empty;
            }
            Keyboard.Focus(SaveFolderName);

        }

        //Close window with Esc, load save with Enter
        private void UserLoadWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }

            if (e.Key == Key.Enter)
            {
                Load();
                EnterToLoad.Content = "Main save file replaced with selected file, Esc to exit";
            }

        }
        //Center window
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }
        //Make window draggable
        private void UserLoadWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}

