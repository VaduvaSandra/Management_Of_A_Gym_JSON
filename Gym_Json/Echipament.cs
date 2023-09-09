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
    public partial class Echipament : Form
    {
        List<Echipamente> listaEchipamente;
        public Echipament()
        {
            InitializeComponent();
            listaEchipamente = new List<Echipamente>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Echipamente echipament = new Echipamente
            {
                NumeAparat = txtNume.Text,
                Descriere = txtDescriere.Text,
                GrupaMusculara = cmbGrupa.SelectedItem.ToString()
            };
            listaEchipamente.Add(echipament);

            string json = JsonConvert.SerializeObject(listaEchipamente);

            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\echipamente.json");

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }

            MessageBox.Show("Datele au fost salvate cu succes in fisierul echipamente.json!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNume.Clear();
            txtDescriere.Clear();
            cmbGrupa.Text = "";
        }

        private void btnVezi_Click(object sender, EventArgs e)
        {
            VeziEchipament ve = new VeziEchipament();
            ve.Show();
        }
    }
}
