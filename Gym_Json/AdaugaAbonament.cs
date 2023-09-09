using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Json
{
    public partial class AdaugaAbonament : Form
    {
        public AdaugaAbonament()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // citim lista de abonamente din fișierul JSON existent sau creăm una nouă dacă nu există
            List<Abonament> abonamente = new List<Abonament>();
            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\abonament.json");
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);
                if (!string.IsNullOrEmpty(jsonString))
                {
                    abonamente = JsonConvert.DeserializeObject<List<Abonament>>(jsonString);
                }
            }

            // adăugăm noul abonament la lista existentă
            Abonament abonament = new Abonament
            {
                Nume = txtNume.Text,
                Prenume = txtPrenume.Text,
                TipAbonament = cmbTip.SelectedItem.ToString(),
                ValabilitateAbonament = cmbValabilitate.SelectedItem.ToString(),
                Pret = cmbPret.SelectedItem.ToString(),
            };
            abonamente.Add(abonament);

            // salvăm lista actualizată în fișierul JSON
            string jsonStringOutput = JsonConvert.SerializeObject(abonamente, Formatting.Indented);
            File.WriteAllText(path, jsonStringOutput);

            // afișăm lista de abonamente în listview
            listView1.Items.Clear();
            foreach (var item in abonamente)
            {
                ListViewItem listViewItem = new ListViewItem(item.Nume);
                listViewItem.SubItems.Add(item.Prenume);
                listViewItem.SubItems.Add(item.TipAbonament);
                listViewItem.SubItems.Add(item.ValabilitateAbonament);
                listViewItem.SubItems.Add(item.Pret.ToString());
                listView1.Items.Add(listViewItem);
            }

            MessageBox.Show("Datele au fost salvate cu succes în fișierul abonament.json!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNume.Clear();
            txtPrenume.Clear();
            cmbValabilitate.Text = "";
            cmbTip.Text = "";
            cmbPret.Text = "";
        }

        private void AdaugaAbonament_Load(object sender, EventArgs e)
        {
            // Citim lista de abonamente din fișierul JSON existent sau creăm una nouă dacă nu există
            List<Abonament> abonamente = new List<Abonament>();
            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\abonament.json");
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);
                abonamente = JsonConvert.DeserializeObject<List<Abonament>>(jsonString);
            }

            // Afisam datele in ListView
            foreach (var item in abonamente)
            {
                ListViewItem listViewItem = new ListViewItem(item.Nume);
                listViewItem.SubItems.Add(item.Prenume);
                listViewItem.SubItems.Add(item.TipAbonament);
                listViewItem.SubItems.Add(item.ValabilitateAbonament);
                listViewItem.SubItems.Add(item.Pret.ToString());
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
