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


namespace Voiliers
{
    /// <summary>
    /// Logique d'interaction pour TableauDeBord.xaml
    /// </summary>
    public partial class TableauDeBord : Window
    {
        public TableauDeBord()
        {
            InitializeComponent(); 
        }

        //ouvre la fenetre permettant d'attribué une pénalité
        private void button_Click(object sender, RoutedEventArgs e)
        {
            var Penalite = new Penalites();
            Penalite.Show(); 
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var Classement = new Classement();
            Classement.Show();

            var TableauDeBord = new TableauDeBord();
            TableauDeBord.Close();
        }
    }
}
