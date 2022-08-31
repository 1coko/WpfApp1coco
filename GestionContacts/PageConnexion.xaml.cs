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

namespace GestionContacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string identification = "Coca";
        string motDePasse = "Cola";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnValiderPageConnexion_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserId.Text) || String.IsNullOrWhiteSpace(txtMotDePasse.Password))
            {
                MessageBox.Show("Les champs 'identification' et 'Mot de passe' doivent être renseignés");
            }
            else
            {
                if (txtUserId.Text == identification && txtMotDePasse.Password == motDePasse)
                {
                    MessageBox.Show("Bonjour,\nMerci de patienter, la connexion est en cours.");

                    MainWindow page = new MainWindow();
                    page.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Les champs 'identification' et ou 'mot de passe' sont incorrecte.\nMerci de resaisir les champs.");
                }
            }
        }
    }
}
