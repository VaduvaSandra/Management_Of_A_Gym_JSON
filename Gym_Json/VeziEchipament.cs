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
    public partial class VeziEchipament : Form
    {
        public VeziEchipament()
        {
            InitializeComponent();
        }

        private void VeziEchipament_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\echipamente.json");

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<Echipamente> listaEchipamente = JsonConvert.DeserializeObject<List<Echipamente>>(json);

                DGV.DataSource = listaEchipamente;
            }
        }
    }
}
