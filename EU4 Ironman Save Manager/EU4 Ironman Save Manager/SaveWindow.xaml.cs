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

namespace EU4_Ironman_Save_Manager
{
    /// <summary>
    /// Interaction logic for SaveWindow.xaml
    /// </summary>
    public partial class SaveWindow : Window
    {
        public SaveWindow()
        {
            InitializeComponent();
            EnterToSave.Content= "Press Enter to save";
            SaveName.Focus();
            CenterWindowOnScreen();
        }

        //Do the copying over of the custom named save file
        private void Copysave()
        {
                MainWindow.UpdateConfig("copysavename", SaveName.Text);
                
                //Structure strings for copying
                if (MainWindow.ReadSetting("copysavename") != null)
                {
                    string savename = MainWindow.ReadSetting("savename") + ".eu4";
                    string copysavename = MainWindow.ReadSetting("savename") + "-" + MainWindow.ReadSetting("copysavename") + ".eu4";
                    string source = MainWindow.ReadSetting("savefolder");
                    string target = source + MainWindow.ReadSetting("savename");
                    string sourceFile = System.IO.Path.Combine(source, savename);
                    string destFile = System.IO.Path.Combine(target, copysavename);

                    //Create directory if needed
                    if (!System.IO.Directory.Exists(target))
                    {
                        System.IO.Directory.CreateDirectory(target);
                    }

                    //Copy file over, overwrite if necessary
                    try
                    {
                        System.IO.File.Copy(sourceFile, destFile, true);
                        EnterToSave.Content = MainWindow.ReadSetting("copysavename") + " saved, press Esc to exit";
                    }
                    catch
                    {
                        MessageBox.Show("No save found, check save name and location in settings");
                    }
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

        //Close window with Esc
        private void SaveWindow_KeyDown(object sender, KeyEventArgs e)
        {
        //Save when Enter is pressed, close if Esc is pressed
        if (e.Key == Key.Escape)
            {
                Close();
            }

            if (e.Key == Key.Enter)
            {
                Copysave();
            }
        }

        //Make window draggable
        private void SaveWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
