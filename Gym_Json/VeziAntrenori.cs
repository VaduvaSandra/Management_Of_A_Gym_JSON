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
    public partial class VeziAntrenori : Form
    {
        public VeziAntrenori()
        {
            InitializeComponent();
        }
        private void IncarcaAntrenori()
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\antrenor.json");
            string jsonString = File.ReadAllText(path);

            List<Antrenor> antrenori = JsonConvert.DeserializeObject<List<Antrenor>>(jsonString);

            listView1.Items.Clear();
            foreach (Antrenor antrenor in antrenori)
            {
                ListViewItem item = new ListViewItem(antrenor.Nume);
                item.SubItems.Add(antrenor.Prenume);
                item.SubItems.Add(antrenor.Categorie);
                item.SubItems.Add(antrenor.Perioada);
                listView1.Items.Add(item);
            }
        }
        private void VeziAntrenori_Load(object sender, EventArgs e)
        {
            IncarcaAntrenori();
        }
    }
}
