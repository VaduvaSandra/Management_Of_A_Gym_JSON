using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Json
{
    public partial class Produse : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public Produse()
        {
            InitializeComponent();
         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare la încărcarea imaginii: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nu s-a selectat nicio imagine.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (bindingSource.DataSource == null)
            {
                bindingSource.DataSource = new List<Produs>();
            }
            // Creăm un nou produs
            Produs produs = new Produs
            {
                Nume = txtNume.Text
            };

            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    produs.ImageData = ms.ToArray();
                }
            }

            // Adăugăm produsul în lista de produse
            List<Produs> products = bindingSource.DataSource as List<Produs>;
            products.Add(produs);

            // Serializăm lista de produse într-un fișier JSON
            string json = JsonConvert.SerializeObject(products);
            File.WriteAllText(@"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\produse.json", json);

            // Actualizăm BindingSource
            bindingSource.ResetBindings(false);
            DGV.DataSource = bindingSource;

            // Resetați TextBox-urile și PictureBox-ul
            txtNume.Text = "";
            pictureBox1.Image = null;


        }
       

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void Produse_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Deserializăm fișierul JSON într-o listă de produse
            string filePath = @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\produse.json";
            List<Produs> products = LoadProductsFromJsonFile(filePath);
            // Actualizăm BindingSource cu lista de produse
            bindingSource.DataSource = products;

            // Actualizăm DataGridView
            DGV.DataSource = bindingSource;
        }
        private List<Produs> LoadProductsFromJsonFile(string filePath)
        {
            List<Produs> products = new List<Produs>();
            string jsonContent = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Produs>>(jsonContent);
            return products;
        }

        private void btnOrd_Click(object sender, EventArgs e)
        {
            List<Produs> products = bindingSource.DataSource as List<Produs>;
            if (products != null)
            {
                products.Sort((p1, p2) => p1.Nume.CompareTo(p2.Nume));
                bindingSource.ResetBindings(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Produs> products = bindingSource.DataSource as List<Produs>;

            foreach (DataGridViewRow row in DGV.SelectedRows)
            {
                if (row.DataBoundItem != null)
                {
                    products.Remove(row.DataBoundItem as Produs);
                }
            }

            // Actualizăm BindingSource
            bindingSource.ResetBindings(false);

            // Resetăm selecția în DataGridView
            DGV.ClearSelection();
        }
    }
}
