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

namespace NbrMystereWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numero;
        int essai;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NewPartie();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {

                int valeur = Test();
                
            if ((valeur > 0) && (valeur < 20))
            {
                essai++;
                if (valeur > numero)
                {
                    info.Text = "C'est Moins";
                }
                else if (valeur < numero)
                {
                    info.Text = "C'est Plus";
                }
                else
                {
                    Win();
                }
                box.Text = "Nombre d'essais : " + essai;
            }
             
        }

        private void btnNouvellePartie_Click(object sender, RoutedEventArgs e)
        {
            NewPartie();
        }
        void NewPartie()
        {
            numero = new Random().Next(1, 20);
            info.Text = String.Empty;
            block.Text = String.Empty;
            essai = 0;
            box.Text = "Nombre d'essais : 0";
        }
        void Win()
        {
            info.Text="Bravo c'etait bien tu as gagné";
        }
        int Test()
        {
            string lol;
            int lol2;
            lol = block.Text;
            if ((!int.TryParse(lol, out lol2)) || (int.Parse(lol) >= 20) || (int.Parse(lol) < 1))
            {
                info.Text="il faut saisir un nombre entre 1 et 20";

            }
            else 
            { 
                info.Text = "";
            }
            return lol2;
        }
    }
}
