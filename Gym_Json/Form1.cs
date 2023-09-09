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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectare_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Completati campurile");
            }
            else
            {
                StreamReader reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"C:\Users\vaduv\Desktop\Facultate\Facultate an 4\TTTvMM\Gym_Json\Gym_Json\userData.json"));
                string jsonString = reader.ReadToEnd();

                //deserializam fisierul pentru a lucra cu obiectul Users(lista de obiecte cu tipul User)
                Users users = JsonConvert.DeserializeObject<Users>(jsonString);

                //parcurgem lista de utilizatori si cautam utilizatorul cu username si parola introduse
                bool foundUser = false;
                foreach (User user in users.userData)
                {
                    if (user.username == TxtUsername.Text && user.password == txtPassword.Text)
                    {
                        foundUser = true;
                        Main frm = new Main();
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();

                    }
                }
                if (!foundUser) MessageBox.Show("Date introduse gresit!");


            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
