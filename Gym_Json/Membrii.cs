using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Json
{
    public partial class Membrii : Form
    {
        public Membrii()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Obtinem valorile introduse de utilizator
            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;
            string telefon = txtTelefon.Text;
            string tipAbonament = cmbTip.SelectedItem.ToString();
            string valabilitateAbonement = cmbValabilitate.SelectedItem.ToString();
            string dataInscriere = Convert.ToDateTime(dateTimePicker1.Text).ToString();

            //Cream un obiect membru
            Membru membru = new Membru(nume, prenume, telefon, tipAbonament, valabilitateAbonement, dataInscriere);

            //Adaugam un nou element in ListView
            ListViewItem item = new ListViewItem(new[] { nume, prenume, telefon, tipAbonament, valabilitateAbonement, dataInscriere });
            listView1.Items.Add(item);
        }

        private void btnNou_Click(object sender, EventArgs e)
        {
            txtNume.Clear();
            txtPrenume.Clear();
            txtTelefon.Clear();

            cmbTip.Text = "";
            cmbValabilitate.Text = "";

            dateTimePicker1.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //Verificam daca este selectat un element
            if (listView1.SelectedItems.Count > 0)
            {
                //Obtinem elementul selectat
                ListViewItem item = listView1.SelectedItems[0];

                //Stergem elementul din JSON
                listView1.Items.Remove(item);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //verificăm dacă există un element selectat în listview
            if (listView1.SelectedItems.Count > 0)
            {
                //extragem valorile corespunzătoare din textbox-uri și combobox-uri
                string nume = txtNume.Text;
                string prenume = txtPrenume.Text;
                string telefon = txtTelefon.Text;
                string tip = cmbTip.SelectedItem.ToString();
                string valabilitate = cmbValabilitate.SelectedItem.ToString();
                string data = dateTimePicker1.Value.ToString("dd.MM.yyyy");

                //actualizăm datele în sursa de date
                listView1.SelectedItems[0].SubItems[0].Text = nume;
                listView1.SelectedItems[0].SubItems[1].Text = prenume;
                listView1.SelectedItems[0].SubItems[2].Text = telefon;
                listView1.SelectedItems[0].SubItems[3].Text = tip;
                listView1.SelectedItems[0].SubItems[4].Text = valabilitate;
                listView1.SelectedItems[0].SubItems[5].Text = data;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            //Stergem toate elementele din ListView
            listView1.Items.Clear();
        }

        private void btnVezi_Click(object sender, EventArgs e)
        {
            // Citeste continutul fisierului JSON intr-un sir de caractere
            string json = File.ReadAllText(@"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\membrii.json");
            MessageBox.Show("Fisierul JSON a fost citit cu succes!");

            // Deserializare JSON in lista de obiecte Abonament
            List<Membru> membrii = JsonConvert.DeserializeObject<List<Membru>>(json);
            MessageBox.Show($"Au fost incarcate {membrii.Count} obiecte din fisierul JSON");

            // Adauga elementele in ListView
            foreach (Membru m in membrii)
            {
                ListViewItem item = new ListViewItem(m.Nume);
                item.SubItems.Add(m.Prenume);
                item.SubItems.Add(m.Telefon);
                item.SubItems.Add(m.TipAbonament);
                item.SubItems.Add(m.ValabilitateAbonament);
                item.SubItems.Add(m.DataInscrierii.ToString("dd/MM/yyyy"));
                listView1.Items.Add(item);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\membrii.json");

            List<Membru> membrii = new List<Membru>();

            // Dacă fișierul există, citim conținutul existent și deserializăm obiectele JSON într-o listă de obiecte Membru
            if (File.Exists(path))
            {
                string jsonContent = File.ReadAllText(path);
                membrii = JsonConvert.DeserializeObject<List<Membru>>(jsonContent);
            }

            // Iterăm prin fiecare element din ListView și adăugăm un obiect Membru pentru fiecare element
            foreach (ListViewItem item in listView1.Items)
            {
                Membru membru = new Membru
                {
                    Nume = item.SubItems[0].Text,
                    Prenume = item.SubItems[1].Text,
                    Telefon = item.SubItems[2].Text,
                    TipAbonament = item.SubItems[3].Text,
                    ValabilitateAbonament = item.SubItems[4].Text,
                    DataInscrierii = DateTime.Parse(item.SubItems[5].Text)
                };

                membrii.Add(membru);
            }

            // Serializăm lista actualizată de obiecte Membru în format JSON și scriem în fișierul membrii.json
            string jsonString = JsonConvert.SerializeObject(membrii, Formatting.Indented);
            File.WriteAllText(path, jsonString);

            MessageBox.Show("Datele au fost salvate cu succes în fișierul membrii.json!");
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefon.TextLength < 10 || txtTelefon.TextLength > 10)
            {
                errorProvider1.SetError(txtTelefon, "Numarul de telefon trebuie sa contina exact 10 cifre.");
            }
            else
            {
                errorProvider1.SetError(txtTelefon, "");
            }
        }

        //evenimentul SelectedIndexChanged al listview-ului
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificăm dacă există un element selectat în listview
            if (listView1.SelectedItems.Count > 0)
            {
                //extragem valorile corespunzătoare ale elementului selectat
                string nume = listView1.SelectedItems[0].SubItems[0].Text;
                string prenume = listView1.SelectedItems[0].SubItems[1].Text;
                string telefon = listView1.SelectedItems[0].SubItems[2].Text;
                string tip = listView1.SelectedItems[0].SubItems[3].Text;
                string valabilitate = listView1.SelectedItems[0].SubItems[4].Text;
                DateTime data = DateTime.Parse(listView1.SelectedItems[0].SubItems[5].Text);

                //setăm valorile în textbox-uri și combobox-uri
                txtNume.Text = nume;
                txtPrenume.Text = prenume;
                txtTelefon.Text = telefon;
                cmbTip.SelectedItem = tip;
                cmbValabilitate.SelectedItem = valabilitate;
                dateTimePicker1.Value = data;
            }
        }
    }
}
