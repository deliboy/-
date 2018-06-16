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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var f in FontImageButtonFactory.All)
            {
                wp.Children.Add(f);
            }


        }
    }

    public static class FontImageButtonFactory
    {
        public const string FIX = "HOLOLENS MDL2 ASSETS";
        public const string FI1 = "WINGDINGS";
        public const string FI2 = "WINGDINGS 2";
        public const string FI3 = "WEBDINGS";
        const int fs = 50;

        static List<char> fonts = new List<char>();
        static List<char> fonts2 = new List<char>();
        internal static void C() { }
        static FontImageButtonFactory()
        {
             int s = 0x0021;
             int f = 0x00EB;
            int s2 = 0xE700;
            int f2 = 0xF186;

            for (int i = s; i<=f; i++)
            {
                //   fonts.Add($"&#x{i.ToString("X4")};");
                //fonts.Add("&#x0021;");
                fonts.Add((char)i);
            }

            for (int i = s2; i <= f2; i++)
            {
                //   fonts.Add($"&#x{i.ToString("X4")};");
                //fonts.Add("&#x0021;");
                fonts2.Add((char)i);
            }
        }

        static List<Button> Buttons = null;

        public static IList<Button> All
        {
            get
            {
                if (Buttons == null)
                {
                    Buttons = new List<Button>();

                    foreach (var i in fonts2)
                    {
                        var b1 = new Button
                        {
                            FontFamily = new FontFamily(FIX),
                            FontSize = fs,
                            Foreground = Brushes.HotPink,
                            Content = i.ToString(),
                            Background = Brushes.Transparent
                              ,
                            ToolTip = $"{FIX} / {((int)i).ToString("X4")}"
                        };
                        Buttons.Add(b1);
                    }
                        foreach (var i in fonts)
                    {
                        var b1 = new Button
                        {
                            FontFamily = new FontFamily(FI1),
                            FontSize = fs,
                            Foreground = Brushes.Yellow,
                            Content = i.ToString(),
                             Background = Brushes.Transparent
                              ,ToolTip = $"{FI1} / {((int)i).ToString("X4")}"
                        };
                        Buttons.Add(b1);
                        var b2 = new Button
                        {
                            FontFamily = new FontFamily(FI2),
                            FontSize = fs,
                            Foreground = Brushes.Green,
                            Content = i.ToString(),
                            Background = Brushes.Transparent
                              ,
                            ToolTip = $"{FI2} / {((int)i).ToString("X4")}"

                        };
                        Buttons.Add(b2);
                        var b3 = new Button
                        {
                            FontFamily = new FontFamily(FI3),
                            FontSize = fs,
                            Foreground = Brushes.Red,
                            Content = i.ToString(),
                            Background = Brushes.Transparent
                              ,
                            ToolTip = $"{FI3} / {((int)i).ToString("X4")}"
                        };
                        Buttons.Add(b3);
                    }
                }

                return Buttons;
            }
        }
        

        //public const string R1 = 
    }



}
