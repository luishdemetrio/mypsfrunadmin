using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfElevatedApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

        }

        

        private void CreateFileOnSystem32(object sender, RoutedEventArgs e)
        {
            try
            {
                File.WriteAllText(@"C:\Windows\System32\psfdemo.txt", "It works! ");

                MessageBox.Show("File saved!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void CreateHKLMKey(object sender, RoutedEventArgs e)
        {

            var regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\PSFRunningScript", true);

            if (regKey == null)
            {
                regKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\PSFRunningScript", RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            regKey.SetValue("Date", DateTime.Now);

            MessageBox.Show("Registry keys saved!");

        }
    }
}
