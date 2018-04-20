using Common;
using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Leetcode
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {
             txtOutput.Text= HtmlHelper.GetResponseString(txtUrl.Text);
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == false) return;
            txtOutput.Text = FileHelper.ReadText(openFile.FileName);
        }

        private void btnRegex_Click(object sender, RoutedEventArgs e)
        {
            string inputstr = txtOutput.Text;
            txtOutput.Text = RegualerHelper.GetAllMatches(inputstr, txtUrl.Text);
            // txtOutput.Text = RegualerHelper.GetTitle(inputstr);
        }
    }
}
