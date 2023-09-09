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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "" || txtPassword.Text == "" || TxtOras.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                //cream obiectul User pentru a-l insera in obiectul Users care reprezinta fisierul JSON deserializat
                User user = new User();
                user.username = TxtUsername.Text;
                user.password = txtPassword.Text;
                user.oras = TxtOras.Text;

                //deserializam fisierul JSON (il transformam intr-un obiect Users -- o lista de obiecte User --)
                StreamReader reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\userData.json"));
                string jsonString = reader.ReadToEnd();
                Users users = JsonConvert.DeserializeObject<Users>(jsonString);
                reader.Close();

                //adaugam noul user in lista de utilizatori
                users.Add(user);

                //scriem in fisierul JSON noul rezultat
                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\userData.json"), JsonConvert.SerializeObject(users, Formatting.Indented));

                MessageBox.Show("Utilizator creat cu succes!");
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
