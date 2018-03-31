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

    public partial class UserSettings : Window
    {

        public UserSettings()
        {
            InitializeComponent();
            SaveFolderName.Text = MainWindow.ReadSetting("savefolder");
            SaveName.Text = MainWindow.ReadSetting("savename");
            CenterWindowOnScreen();
            SaveName.Focus();
        }

        //Open folder selection dialog and put the result to text field
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = MainWindow.ReadSetting("savefolder");
            Keyboard.Focus(SaveFolderName);
            if (folderDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SaveFolderName.Text = folderDlg.SelectedPath;
                Keyboard.Focus(SaveFolderName);
            }
            Keyboard.Focus(SaveFolderName);
        }

        //Update save name with Enter
        private void UpdateSaveName()
        {
            MainWindow.UpdateConfig("savename", SaveName.Text);
        }

        //Update save folder with Enter
        private void UpdateSaveFolder()
        {
            string savelocation = SaveFolderName.Text + @"\";
            if (MainWindow.ReadSetting("savefolder") != savelocation)
            {
                MainWindow.UpdateConfig("savefolder", savelocation);
            }
        }

        //Close window with Esc, save with Enter
        private void UserSettings_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }

            if (e.Key == Key.Enter)
            {
                Focus();
                UpdateSaveName();
                UpdateSaveFolder();
                EnterToSave.Content = "Settings saved, press Esc to exit";
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
        private void UserSettings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}

