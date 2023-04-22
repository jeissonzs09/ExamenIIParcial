using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoUsuariotextBox, "Campo Usuario Vacio, por favor ingrese un usuario");
                return;

            }
            errorProvider1.Clear();
            if (ContraseñatextBox.Text == "")
            {
                errorProvider1.SetError(ContraseñatextBox, "Campo Contraseña Vacio, por favor ingrese una contraseña");
                return;
            }
            errorProvider1.Clear();

            Login login = new Login(CodigoUsuariotextBox.Text, ContraseñatextBox.Text);

            UsuarioDB usuarioDB = new UsuarioDB();
            Usuarios usuarios = new Usuarios();

            usuarios = usuarioDB.Autenticar(login);

            if (usuarios != null)
            {
                if (usuarios.EstaActivo)
                {
                    Menu menuFormulario = new Menu();
                    this.Hide();
                    menuFormulario.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no esta activo");
                }

            }

            else
            {
                MessageBox.Show("Usuario o Contraseña Invalidos");
            }


        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            if (ContraseñatextBox.PasswordChar == '*')
            {
                ContraseñatextBox.PasswordChar = '\0';
            }
            else
            {
                ContraseñatextBox.PasswordChar = '*';
            }
        }
    }
}
