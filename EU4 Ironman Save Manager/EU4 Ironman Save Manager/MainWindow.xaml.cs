using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace EU4_Ironman_Save_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            CheckFirstTime();
        }

        private static void CheckFirstTime()
        {
            string firsttime = ReadSetting("first_time");
            Console.WriteLine("this is console " + firsttime);
            string savelocation = "";
            if (firsttime.Equals("1"))
            {
                savelocation = @"C:\Users\" + Environment.UserName + @"\Documents\Paradox Interactive\Europa Universalis IV\save games\";
                UpdateConfig("savefolder", savelocation);
                UpdateConfig("copysavefolder", savelocation);
                UpdateConfig("first_time", "0");
            }
        }

        //Reads a specified setting from the config file
        public static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                Console.WriteLine(result);
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error reading app settings, run the program as administrator");
            }
            return "";
        }
        //Updates a specified field in the config file
        public static void UpdateConfig(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                settings.Remove(key);
                settings.Add(key, value);
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error writing app settings, run the program as administrator");
            }
        }
        //Makes a copy of the save file and adds -quicksave to the end of the copy's filename
        private void QuickSave()
        {
            if (ReadSetting("savename") != "default" && ReadSetting("savefolder") != "default")
            {
                string savename = ReadSetting("savename") + ".eu4";
                string quicksavename = ReadSetting("savename") + "-quicksave.eu4";
                string target = ReadSetting("savefolder");
                string sourceFile = System.IO.Path.Combine(target, savename);
                string destFile = System.IO.Path.Combine(target, quicksavename);
                File.Copy(sourceFile, destFile, true);
            }
            else
            {
                MessageBox.Show("Update save file name and / or folder in Settings");
            }

        }

        //Replaces the current save with the quicksave file
        private void Replace()
        {
            if (ReadSetting("savename") != "default" && ReadSetting("savefolder") != "default")
            {
                string savename = ReadSetting("savename") + ".eu4";
                string quicksavename = ReadSetting("savename") + "-quicksave.eu4";
                string target = ReadSetting("savefolder");
                string sourceFile = System.IO.Path.Combine(target, quicksavename);
                string destFile = System.IO.Path.Combine(target, savename);
                File.Copy(sourceFile, destFile, true);
            }
            else
            {
                MessageBox.Show("Update save file name and / or folder in Settings");
            }
        }

        //Deletes the largely useless clutter called a backup save. You've got a save manager now!
        public void DeleteBackup()
        {
            if (ReadSetting("savename") != "default" && ReadSetting("savefolder") != "default")
            {
                string target = ReadSetting("savefolder");
                string backupsavename = ReadSetting("savename") + "_Backup.eu4";
                string backupPath = System.IO.Path.Combine(target, backupsavename);
                if (File.Exists(backupPath)) { 
                System.IO.File.Delete(backupPath);
                }
            }
            else
            {
                MessageBox.Show("Update save file name and / or folder in Settings");
            }
        }
            

        //Calls QuickSave when the button is clicked
        private void QuicksaveButton_Click(object sender, RoutedEventArgs e)
        {
            QuickSave();
        }

        //Opens up a dialog for a custom-named save file
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ReadSetting("savename") != "default" && ReadSetting("savefolder") != "default")
            {
                new SaveWindow().Show();
            }
            else
            {
                MessageBox.Show("Update save file name and / or folder in Settings");
            }
        }

        //Calls Replace when the Quickload button is clicked and removes the useless _Backup file
        private void ReplaceButton_Click(object sender, RoutedEventArgs e)
        {
            Replace();
            DeleteBackup();
        }

        //Opens the Settings window
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            new UserSettings().Show();
        }

        //Makes window draggable
        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        //Calls the window for custom save file and deletes the useless backup save
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            if (ReadSetting("savename") != "default" && ReadSetting("savefolder") != "default")
            {
                new UserLoadWindow().Show();
                DeleteBackup();
            }
            else
            {
                MessageBox.Show("Update save file name and / or folder in Settings");
            }
        }

        //Make this app be on top. Top I say! Except in non-windowed fullscreen...
        private void Window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
            Activate();
        }

        //Still trying to make this stay on top
        private void Window_Activated(object sender, EventArgs e)
        {
            this.Topmost = true;
        }

        //Closes the program from the X button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
