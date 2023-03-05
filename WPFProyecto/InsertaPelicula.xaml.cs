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
        MainWindow principal;
        Accion wdwAccion;

        public InsertaPelicula(Accion Accion)
        {
            InitializeComponent();
            this.wdwAccion = Accion;
        }
        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textoCategoria.Text.Equals("Accion"))
            {
                

                // Asignar los valores de las variables a las propiedades de la nueva ventana
                this.wdwAccion.Titulo = textoTitulo.Text;
                // Mostrar la nueva ventana
                this.wdwAccion.Director = textoDirector.Text;
                string auxAnio = textoAnio.Text;
                this.wdwAccion.anio = int.Parse(auxAnio);
                // Mostrar la nueva ventana
                
                this.wdwAccion.Show();
                this.Close();
            }
        }
    }
}
