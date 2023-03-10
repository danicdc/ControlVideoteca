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
using System.Windows.Shapes;

namespace WPFProyecto
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MainWindow principal;
        public string Titulo { get; set; }
        public string Director { get; set; }
        public int anio { get; set; }

        public Window2(MainWindow menuPrincipal)
        {
            principal = menuPrincipal;
            InitializeComponent();
        }

        private void ImagenBotonComedia_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            principal.Show();
            this.Hide();
        }

        private void AddComedia_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Accion ac1 = new Accion(principal);
            Drama d2 = new Drama(principal);
            InsertaPelicula inserta = new InsertaPelicula(ac1,d2, this);
            inserta.Show();
            this.Hide();
        }
    }
}
