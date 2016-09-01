using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace testImage
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //image.Source = new BitmapImage(new Uri(@"C:\Users\Richard\Pictures\3.bmp"));
            using(MemoryStream ms =new MemoryStream())
            {
                Bitmap bitmap = new Bitmap(@"C:\Users\Richard\Pictures\2.png");
                bitmap.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.CacheOption = BitmapCacheOption.OnLoad;
                bi.StreamSource = ms;
                bi.EndInit();
                bi.Freeze();
                image.Source = bi;
            }
        }

    }
}
