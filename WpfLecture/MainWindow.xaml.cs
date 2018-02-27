using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfLecture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string leftOp = "";
        //string operation = "";
        //string rightOp = "";
        string result;


        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement c in rootGrid.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += this.Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)(e.OriginalSource)).Content;

            this.textBlock.Text += s;

            int num;

            if (Int32.TryParse(s, out num))
            {
               
                    result += s;
                
            }
            else
            {
                if (s == "CLEAR")
                {
                    result = "";
                    this.textBlock.Text = result;

                }
                else  if (s == "=")
                {
                    DataTable dt = new DataTable();
                    var calc = "";
                    try
                    {
                        calc = dt.Compute(result, "").ToString();
                    }
                    catch 
                    {
                        MessageBox.Show("Incorrect expression");
                        
                    }
                    result = calc.ToString();
                    this.textBlock.Text = result;
                    
                }
                 else
                {

                    result += s;

                }


            }
        }

       
    }
}
