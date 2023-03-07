using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace GraphSPcopy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        public class Elementa
        {
            private double _gradSaut4;
            private double _gradSaut3;
            private double _gradSaut2;
            private double _gradSaut1;
            private double _gradMaxSaut;

            public double Gradgaut4
            {
                get { return _gradSaut4; }
                set { _gradSaut4 = value; }
            }

            public double Gradgaut3
            {
                get { return _gradSaut3; }
                set { _gradSaut3 = value; }
            }

            public double Gradgaut2
            {
                get { return _gradSaut2; }
                set { _gradSaut2 = value; }
            }

            public double Gradgaut1
            {
                get { return _gradSaut1; }
                set { _gradSaut1 = value; }
            }

            public double GradMaxSaut
            {
                get { return _gradMaxSaut; }
                set { _gradMaxSaut = value; }

            }

        } 
    }
}

