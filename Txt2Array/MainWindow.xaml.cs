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

namespace Txt2Array
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.output.Text = "";

            var input = this.input.Text;
            string output = "";

            var seperator = new string[] { Environment.NewLine };
            var lines = input.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            foreach(var item in lines)
            {
                output += "\"";
                output += item;
                output += "\"";
                output += ", ";
                output += Environment.NewLine;
            }
            this.output.Text = output;

        }
    }
}
