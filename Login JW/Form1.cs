using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_JW
{
    public partial class LOGIN : Form
    {
        public LOGIN()
           
        {
            InitializeComponent();
            
        }

        int posY = 0;
        int posX = 0;
        string USUARIO = "user";
        string CONTRACEÑA = "1234";

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void intUsusario_Enter(object sender, EventArgs e)
        {
            if (intUsusario.Text == "USUARIO"){
                intUsusario.Text = "";
                intUsusario.ForeColor = Color.AliceBlue;
            }
        }

        private void intUsusario_Leave(object sender, EventArgs e)
        {
            if (intUsusario.Text == "")
            intUsusario.Text = "USUARIO";
            intUsusario.ForeColor = Color.AliceBlue;
        }

        private void intContraceña_Enter(object sender, EventArgs e)
        {
            if (intContraceña.Text == "CONTRACEÑA") {
                intContraceña.Text = "";
                intContraceña.ForeColor = Color.AliceBlue;
                intContraceña.UseSystemPasswordChar = true;
            }
        }

        private void intContraceña_Leave(object sender, EventArgs e)
        {
            if (intContraceña.Text == "") {
                intContraceña.Text = "CONTRACEÑA";
                intContraceña.ForeColor = Color.AliceBlue;
                intContraceña.UseSystemPasswordChar = false;
    
            }
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) 
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void botonAcceder_Click(object sender, EventArgs e)
        {
             if(intUsusario.Text != USUARIO || intContraceña.Text != CONTRACEÑA) 
              if(intUsusario.Text!= USUARIO) 
            {
                    MessageBox.Show("Usuario Incorrecto");
                    intUsusario.Clear();
                    intUsusario.Focus();
                    return;
            }
            if (intContraceña.Text != CONTRACEÑA)
            {
                MessageBox.Show("Contraceña Incorrecta");
                {
                    intContraceña.Clear();
                    intContraceña.Focus();
                    return;
                }
            }
            else
            {
                intUsusario.Clear();
                intContraceña.Clear();
                LOGIN form = new LOGIN();
                form.ShowDialog();
            }
        }
    }
}
