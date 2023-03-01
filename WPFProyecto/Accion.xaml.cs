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
       
        Pelicula pelicula;
        ArrayList myAL = new ArrayList();
    
        public Accion(MainWindow menuPrincipal)
        {
            myAL.Add(new Pelicula("Los 7 samurai", 1954, "Akira Kurosawa"));
            myAL.Add(new Pelicula("Terminator 2", 1992, "James Cameron"));
            myAL.Add(new Pelicula("Matrix", 2000, "Wachowski Sisters"));
            myAL.Add(new Pelicula("Die hard", 1989, "John McTiernan"));

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

            InsertaPelicula inserta = new InsertaPelicula();
            inserta.Show();

        }
    }
}
