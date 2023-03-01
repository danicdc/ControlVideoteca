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
    /// Lógica de interacción para InsertaPelicula.xaml
    /// </summary>
    public partial class InsertaPelicula : Window
    {
        public InsertaPelicula()
        {
            InitializeComponent();
        }

        private Pelicula Aceptar_Click(object sender, RoutedEventArgs e)
        {
            String titulo = textoTitulo.Text;
            String director = textoDirector.Text;
            int anio = int.Parse(textoAño.Text);
            Pelicula pelicula = new Pelicula(titulo, anio, director);

            return pelicula;
            // Pasar la instancia de la película a otra clase o método
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
