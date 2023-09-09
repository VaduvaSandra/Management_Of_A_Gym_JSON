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
    public partial class CautaMembrii : Form
    {
        private List<Abonament> abonamente;

        private string tipAbonament;
        public CautaMembrii()
        {
            InitializeComponent();
            LoadAbonamente();
        }
        private void LoadAbonamente()
        {
            string path = @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\abonament.json";
            string json = File.ReadAllText(path);
            abonamente = JsonConvert.DeserializeObject<List<Abonament>>(json);

            DGV.DataSource = abonamente;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string numeCautat = txtNume.Text.ToLower();
            List<Abonament> abonamenteGasite = new List<Abonament>();

            foreach (Abonament abonament in abonamente)
            {
                if (abonament.Nume.ToLower().Contains(numeCautat))
                {
                    abonamenteGasite.Add(abonament);
                }
            }

            DGV.DataSource = abonamenteGasite;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNume.Clear();
            cmbTip.Text = "";
            LoadAbonamente();
        }
        private void ActualizeazaDataGridView()
        {
            // Citim abonamentele din fisierul JSON
            string path = @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\abonament.json";
            string json = File.ReadAllText(path);
            List<Abonament> abonamente = JsonConvert.DeserializeObject<List<Abonament>>(json);

            // Filtram abonamentele dupa tipul selectat
            var abonamenteFiltrate = abonamente.Where(abonament => abonament.TipAbonament == tipAbonament).ToList();

            // Actualizam sursa de date a DataGridView-ului
            DGV.DataSource = abonamenteFiltrate;
        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipAbonament = cmbTip.SelectedItem.ToString();
            ActualizeazaDataGridView();
        }

        private void CautaMembrii_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\abonament.json";
            string json = File.ReadAllText(filePath);
            List<Abonament> abonamente = JsonConvert.DeserializeObject<List<Abonament>>(json);

            DGV.DataSource = abonamente;
        }
    }
}
