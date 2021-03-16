using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CapaPresentacion
{
    public partial class FrmProducto : XtraForm
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            IniciarParametros();
        }

        private void IniciarParametros()
        {
            Icon = Properties.Resources.ItemDS;
            ShowIcon = false;
            txtBuscar.Focus();
            //cboEtiqueta.SelectedIndex = 1;            
            ucEtiqueta0.Instance.setDatos("Hola");
            EstablecerVersionEtiqueta(0);
        }

        private void EstablecerVersionEtiqueta(int indexEtiqueta)
        {
            switch (indexEtiqueta)
            {
                case 0:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta0.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta0.Instance);
                        ucEtiqueta0.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta0.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta0.Instance.BringToFront();
                break;               
            }
        }

        private void txtNumeroEtiquetas_Enter(object sender, EventArgs e)
        {
            txtNumeroEtiquetas.SelectAll();
        }

        private void txtNumeroEtiquetas_Click(object sender, EventArgs e)
        {
            txtNumeroEtiquetas.SelectAll();
        }

        private void txtBuscar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnlEstiloEtiquetasCuerpo.Controls.Clear();
            ucEtiqueta0.Instance.Dispose();
        }
    }
}