using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upisPodatakaNaSucelju
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) // Ako pritisnemo X u gornjem desnom kutu, aplikacija ce se prekinuti
        {
            this.Close();
        }

        private void btnOcisti_Click(object sender, EventArgs e) // Kompletno cisti sva polja gdje je nesto napisano
        {
            txtboxcontactID.Clear();
            prezimeOsobe.Clear();
            brMob.Clear();
            mail.Clear();
            adresa.Clear();
            imebox1.Clear();
            txtboxcontactID2.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e) 
        {
            Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e) // Tekst treba selektirati pa onda stisnuti "Obriši" gumb
        {
            txtboxcontactID.SelectedText = "";
            prezimeOsobe.SelectedText = "";
            brMob.SelectedText = "";
            mail.SelectedText = "";
            adresa.SelectedText = "";
        }

        private void btnAdd_Click(object sender, EventArgs e) // Brise sva polja koja sadrze podatke i izbacuje tekst da su podaci uneseni, dakle radi na isti princip kao i "Očisti" funkcija
        {
            string prvi = txtboxcontactID.Text;
            txtboxcontactID2.Text = prvi;

            txtboxcontactID.Clear();
            prezimeOsobe.Clear();
            brMob.Clear();
            mail.Clear();
            adresa.Clear();

            imebox1.Text = "Podaci od navedene osobe su uneseni. Hvala!";
        }

        private void IvanSignature_Click(object sender, EventArgs e)
        {

        }
    }
}
