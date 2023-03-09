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
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GraphSPcopy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged

    {

        

        // Call the OnPropertyChanged method on the instance
        
        public MainWindow()

            
        {
            DataContext = this;
            InitializeComponent();
            
           
        }

        
        public class Elementa
        {
            private double _gradSaut4;
            private double _gradSaut3;
            private double _gradSaut2;
            private double _gradSaut1;
            private double _gradMaxSaut;

            private double _plotX;
            private double _plotY;
            private double _originX;
            private double _originY;

            public double GradSaut4
            {
                get { return _gradSaut4; }
                set { _gradSaut4 = value;
                }
            }

            public double Gradsaut3
            {
                get { return _gradSaut3; }
                set { _gradSaut3 = value;
                    
                }
            }

            public double GradSaut2
            {
                get { return _gradSaut2; }
                set { _gradSaut2 = value;
               }
            }

            public double GradSaut1
            {
                get { return _gradSaut1; }
                set { _gradSaut1 = value; }
            }

            public double GradMaxSaut
            {
                get { return _gradMaxSaut; }
                set { _gradMaxSaut = value; }

            }

            public double PlotX
            {
                get { return _plotX; }
                   set { _plotX = value; }
            }

            public double PlotY
            {
                get { return _plotY; }
                set { _plotY = value; }
            }

            public double OriginX
            {
                get { return _originX; }
                set { _originX = value; }
            }

            public double OriginY
            {
                get { return _originY; }
                set
                {
                    _originY = value;
                }
            }
        }
        Elementa myElementa = new Elementa();

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}

