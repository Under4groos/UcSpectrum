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
using UcSpectrum.Controls;
 

namespace UcSpectrum
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;

            this.PreviewMouseLeftButtonDown += (o, e) =>
            {
                this.DragMove();

                
            };
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            {
                // SystemParameters.FullPrimaryScreenHeight
                // SystemParameters.FullPrimaryScreenWidth




                this.Left = SystemParameters.FullPrimaryScreenWidth/2 - this.Width/2;
                this.Top = SystemParameters.FullPrimaryScreenHeight - this.Height;

            }
        }
    }
}
