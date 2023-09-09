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
    public partial class Antrenori : Form
    {
        public Antrenori()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Antrenor antrenor = new Antrenor
            {
                Nume = txtNume.Text,
                Prenume = txtPrenume.Text,
                Categorie = cmbCategorie.SelectedItem.ToString(),
                Perioada = cmbPerioada.SelectedItem.ToString(),
            };

            List<Antrenor> antrenori = new List<Antrenor>();

            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\antrenor.json");

            if (File.Exists(path))
            {
                string jsonText = File.ReadAllText(path);
                antrenori = JsonConvert.DeserializeObject<List<Antrenor>>(jsonText);
            }

            antrenori.Add(antrenor);

            string jsonString = JsonConvert.SerializeObject(antrenori, Formatting.Indented);
            File.WriteAllText(path, jsonString);

            MessageBox.Show("Datele au fost salvate cu succes în fișierul antrenori.json!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNume.Clear();
            txtPrenume.Clear();

            cmbCategorie.Text = "";
            cmbPerioada.Text = "";
        }

        private void btnAntrenori_Click(object sender, EventArgs e)
        {
            VeziAntrenori va = new VeziAntrenori();
            va.Show();
        }
    }
}
