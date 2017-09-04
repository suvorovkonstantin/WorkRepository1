using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Threading;

namespace WPFA001
{
    class Temper : MainWindow
    {
        async public Task<int> StartTask()
        {
            Thread.Sleep(5000);
             MessageBox.Show("Async mess");
            return 1;
        }
    }
}
