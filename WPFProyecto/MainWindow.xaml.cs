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

namespace WPFProyecto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Accion ventanaAccion;
        Drama ventanaDrama;
        Window2 ventanaComedia;
        public MainWindow()
        {
            ventanaDrama = new Drama(this);
            ventanaAccion = new Accion(this);
            ventanaComedia = new Window2(this);
            InitializeComponent();
        }

        private void Button_ClickAccion(object sender, RoutedEventArgs e)
        {
            ventanaAccion.Show();
            this.Hide();
        }

        private void Button_ClickDrama(object sender, RoutedEventArgs e)
        {
            ventanaDrama.Show();
            this.Hide();
        }
        
        private void Button_ClickComedia(object sender, RoutedEventArgs e)
        {
            ventanaComedia.Show();
            this.Hide();
        }

        
    }
}
