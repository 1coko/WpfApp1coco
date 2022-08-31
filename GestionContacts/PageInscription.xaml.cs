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
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomInscription.Text) || string.IsNullOrWhiteSpace(txtPrenomInscription.Text) || string.IsNullOrWhiteSpace(txtTelInscription.Text))
            {
                MessageBox.Show("Remplissez tous les champs !");
            }
            else
            {/*
                if (txtTelInscription.Length != longNumTel)
                {
                    MessageBox.Show("SVP, merci de saisir un numéro de téléphone à 8 chiffres");
                    txtTelInscription.Text = string.Empty;
                }
                else
                {
                    txtListeInscrit.Text = txtListeInscrit.Text + "\n" + txtNomInscription.Text + " " + txtPrenomInscription.Text + " " + txtTelInscription.Text;


                    txtNomInscription.Text = string.Empty;
                    txtPrenomInscription.Text = string.Empty;
                    txtTelInscription.Text = string.Empty;
                }*/
                txtlisteInscrit.Text = txtlisteInscrit.Text + "\n" + txtNomInscription.Text + " " + txtPrenomInscription.Text + " " + txtTelInscription.Text;


                txtNomInscription.Text = string.Empty;
                txtPrenomInscription.Text = string.Empty;
                txtTelInscription.Text = string.Empty;
            }
        }
    }
}
