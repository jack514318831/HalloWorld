using Common;
using Microsoft.Win32;
using Model;
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

namespace Leetcode
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ProblemModel> ModelList = new List<ProblemModel>();
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
            //txtOutput.Text = RegualerHelper.GetAllMatches(inputstr, txtUrl.Text);
            txtOutput.Text = RegualerHelper.GetSolution(inputstr);
        }

        private void btnReadData_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == false) return;
            using (StreamReader sr = new StreamReader(openFile.FileName, Encoding.Default, false))
            {
                int i = 0;
                while (!sr.EndOfStream && i < 5)
                {
                    string link = sr.ReadLine();
                    link += "/description/";
                    string htmlstr = HtmlHelper.GetResponseString(link);
                    string title = RegualerHelper.GetTitle(htmlstr);
                    string content = RegualerHelper.GetContent(htmlstr);
                    link = link.Replace("problems", "articles").Replace("/description/","");
                    htmlstr = HtmlHelper.GetResponseString(link);
                    string solution = RegualerHelper.GetSolution(htmlstr);
                    ModelList.Add(new ProblemModel() { Title = title, Discrition= content, Solution= solution });
                    i++;
                }
            }
        }
    }
}
