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
    }
}
