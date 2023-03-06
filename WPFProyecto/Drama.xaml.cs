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
    /// Lógica de interacción para Drama.xaml
    /// </summary>
    public partial class Drama : Window
    {
        MainWindow principal;
        public string Titulo { get; set; }
        public string Director { get; set; }
        public int anio { get; set; }
        public Drama(MainWindow menuprincipal)
        {
            principal = menuprincipal;
            InitializeComponent();
        }

        

        

        private void ImagenBotonDrama_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            principal.Show();
            this.Hide();
        }


        private void AddDrama_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Accion ac1 = new Accion(principal);
            Window2 w2 = new Window2(principal);
            InsertaPelicula inserta = new InsertaPelicula(ac1,this, w2);
            inserta.Show();
            this.Hide();
        }
    }
}
