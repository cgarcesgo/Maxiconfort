using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twelve.Maxiconfort.Core.Facade;
using Twelve.Maxiconfort.Model.Entities;

namespace Twelve.Maxiconfort.Facturacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        #region Eventos controles

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cboRoles.DataSource = FacturacionFacade.SelectAllRole();
            cboRoles.ValueMember = "RolId";
            cboRoles.DisplayMember = "Nombre";
        }

        private void lblIngresar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = FacturacionFacade.SelectByIdUsuario(txtUsuario.Text, int.Parse(cboRoles.SelectedValue.ToString()));

            if (objUsuario != null)
            {
                if (cboRoles.SelectedValue.ToString() == "2" || objUsuario.Contrasena == txtContrasena.Text)
                {
                    this.Hide();
                    new frmFacturacion(txtUsuario.Text, int.Parse(cboRoles.SelectedValue.ToString())).Show();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta.");
                }
            }
            else
            {
                MessageBox.Show("El usuario es incorrecto.");
            }
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoles.SelectedValue.ToString() == "2")
                OcultarCampos();
            else
                VisualizarCampos();
        }

        #endregion Eventos controles


        #region Metodos públicos

        /// <summary>
        /// Visualiza los campos del formulario login
        /// </summary>
        public void VisualizarCampos()
        {
            lblContrasenia.Visible = true;
            txtContrasena.Visible = true;
        }


        /// <summary>
        /// Oculta los campos del formulario login
        /// </summary>
        public void OcultarCampos()
        {
            lblContrasenia.Visible = false;
            txtContrasena.Visible = false;
        }

        #endregion Metodos públicos
    }
}
