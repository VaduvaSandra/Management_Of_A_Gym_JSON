
namespace Gym_Json
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.TxtOras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LabelParola = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LableUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Noto Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(1127, 675);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(135, 54);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Inregistrare";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Noto Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(262, 676);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 53);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Inapoi";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TxtOras
            // 
            this.TxtOras.Location = new System.Drawing.Point(110, 553);
            this.TxtOras.Name = "TxtOras";
            this.TxtOras.Size = new System.Drawing.Size(182, 22);
            this.TxtOras.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sigmar One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Oras";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 444);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 22);
            this.txtPassword.TabIndex = 17;
            // 
            // LabelParola
            // 
            this.LabelParola.Font = new System.Drawing.Font("Sigmar One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelParola.Location = new System.Drawing.Point(106, 393);
            this.LabelParola.Name = "LabelParola";
            this.LabelParola.Size = new System.Drawing.Size(111, 25);
            this.LabelParola.TabIndex = 16;
            this.LabelParola.Text = "Parola";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(110, 326);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(182, 22);
            this.TxtUsername.TabIndex = 15;
            // 
            // LableUsername
            // 
            this.LableUsername.AutoSize = true;
            this.LableUsername.Font = new System.Drawing.Font("Sigmar One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableUsername.Location = new System.Drawing.Point(106, 268);
            this.LableUsername.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.LableUsername.Name = "LableUsername";
            this.LableUsername.Size = new System.Drawing.Size(94, 24);
            this.LableUsername.TabIndex = 14;
            this.LableUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sigmar One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(578, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(180, 0, 180, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 154);
            this.label1.TabIndex = 13;
            this.label1.Text = "Power Gym";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1369, 759);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.TxtOras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.LabelParola);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LableUsername);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox TxtOras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label LabelParola;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LableUsername;
        private System.Windows.Forms.Label label1;
    }
}