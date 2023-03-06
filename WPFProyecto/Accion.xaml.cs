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
using System.Collections;

namespace WPFProyecto
{
    /// <summary>
    /// Lógica de interacción para Accion.xaml
    /// </summary>
    public partial class Accion : Window
    {
        MainWindow principal;

        public string Titulo { get; set; }
        public string Director { get; set; }
        public int anio { get; set; }


        ArrayList myAL = new ArrayList();
    
        public Accion(MainWindow menuPrincipal)
        {
            
            myAL.Add(new Pelicula(Titulo,anio, Director));
            myAL.ToString();
            

            principal = menuPrincipal;
            

            InitializeComponent();
        }

        private void ImagenBotonAccion_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            principal.Show();
            this.Hide();
        }

        private void AddAccion_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Drama dr1 = new Drama(principal);
            Window2 w2 = new Window2(principal);
            InsertaPelicula inserta = new InsertaPelicula(this,dr1,w2) ;
            inserta.Show();
            this.Hide();

        }
    }
}
