using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SLA001
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            button1_Click(null, null);
        }                

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Temper tmp = new Temper();
            tmp.StartTask();
        }
    }
}
