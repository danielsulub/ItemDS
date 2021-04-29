using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using System.Collections.Generic;
using CapaEntidad;
using CapaNegocio;

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

            CambiarAppearanceFocused();
            LlenarFiltroProductos();
            ObtenerVersionEtiquetas();
            txtBuscar.Focus();
        }

        private void LlenarFiltroProductos()
        {
            cboFiltro.Properties.Items.Add("Sap");
            cboFiltro.Properties.Items.Add("Código interno");
            cboFiltro.Properties.Items.Add("Fabricante");
            EstablecerFiltroProductos();
        }

        private void EstablecerFiltroProductos()
        {
            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings.Get("IdFiltroProductos")))
            {
                cboFiltro.SelectedIndex = Convert.ToSByte(ConfigurationManager.AppSettings.Get("IdFiltroProductos"));
            }
        }

        private void ObtenerVersionEtiquetas()
        {
            cboVersionEtiqueta.Properties.DataSource = null;
            cboVersionEtiqueta.EditValue = null;
            cboVersionEtiqueta.Properties.Columns.Clear();

            NVersionEtiqueta objNVersionEtiqueta = new NVersionEtiqueta();
            List<EVersionEtiqueta> versionesEtiqueta = objNVersionEtiqueta.ObtenerVersionEtiqueta(Convert.ToInt16(ConfigurationManager.AppSettings.Get("IdSociedad")));
            if (versionesEtiqueta.Count > 0)
            {
                cboVersionEtiqueta.Properties.DropDownRows = (versionesEtiqueta.Count < 7) ? versionesEtiqueta.Count : 7;
                cboVersionEtiqueta.Properties.DataSource = versionesEtiqueta;
                cboVersionEtiqueta.Properties.DisplayMember = "Nombre";
                cboVersionEtiqueta.Properties.ValueMember = "IdVersionEtiqueta";
                cboVersionEtiqueta.Properties.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
                EstablecerVersionEtiqueta();
            }
            else
                MessageBox.Show("No existen etiquetas para la sociedad actual.");
        }

        private void EstablecerVersionEtiqueta()
        {
            cboVersionEtiqueta.EditValue = Convert.ToInt16(ConfigurationManager.AppSettings.Get("IdVersionEtiqueta"));
        }


        public void CambiarAppearanceFocused()
        {
            var backColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("BackColorFocus"));
            var foreColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("ForeColorFocus"));

            txtBuscar.Properties.AppearanceFocused.BackColor = backColorFocus;
            txtBuscar.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            txtNumeroEtiquetas.Properties.AppearanceFocused.BackColor = backColorFocus;
            txtNumeroEtiquetas.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            cboFiltro.Properties.AppearanceFocused.BackColor = backColorFocus;
            cboFiltro.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            cboVersionEtiqueta.Properties.AppearanceFocused.BackColor = backColorFocus;
            cboVersionEtiqueta.Properties.AppearanceFocused.ForeColor = foreColorFocus;
        }

        public static Color StringToColor(string colorStr)
        {
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            var result = (Color)cc.ConvertFromString(colorStr);
            return result;
        }

        private void MostrarVersionEtiqueta(short valorEtiqueta)
        {
            switch (valorEtiqueta)
            {
                case 0:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta1.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta1.Instance);
                        ucEtiqueta1.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta1.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta1.Instance.BringToFront();
                    break;
                case 1:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta2.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta2.Instance);
                        ucEtiqueta2.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta2.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta2.Instance.BringToFront();
                    break;
                case 2:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta3.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta3.Instance);
                        ucEtiqueta3.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta3.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta3.Instance.BringToFront();
                    break;
                case 3:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta4.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta4.Instance);
                        ucEtiqueta4.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta4.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta4.Instance.BringToFront();
                    break;
                case 4:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta5.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta5.Instance);
                        ucEtiqueta5.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta5.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta5.Instance.BringToFront();
                    break;
                case 5:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta6.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta6.Instance);
                        ucEtiqueta6.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta6.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta6.Instance.BringToFront();
                    break;
                case 6:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta7.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta7.Instance);
                        ucEtiqueta7.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta7.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta7.Instance.BringToFront();
                    break;
                case 7:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta8.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta8.Instance);
                        ucEtiqueta8.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta8.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta8.Instance.BringToFront();
                    break;
                case 8:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta9.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta9.Instance);
                        ucEtiqueta9.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta9.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta9.Instance.BringToFront();
                    break;
                case 9:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta10.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta10.Instance);
                        ucEtiqueta10.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta10.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta10.Instance.BringToFront();
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MostrarDatosEtiqueta(Convert.ToInt16(cboVersionEtiqueta.EditValue));
        }

        private void cboVersionEtiqueta_EditValueChanged(object sender, EventArgs e)
        {
            if (cboVersionEtiqueta.Properties.DataSource != null)
            {
                MostrarVersionEtiqueta(Convert.ToInt16(cboVersionEtiqueta.EditValue));
                LimpiarDatos();                
            }
        }

        private void LimpiarDatos()
        {
            if (pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta1.Instance)) ucEtiqueta1.Instance.LimpiarDatos();
            if (pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta2.Instance)) ucEtiqueta2.Instance.LimpiarDatos();
        }

        private void FrmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            pnlEstiloEtiquetasCuerpo.Controls.Clear();
            //LimpiarDatos();
        }

        private void MostrarDatosEtiqueta(short valorEtiqueta)
        {
            switch (valorEtiqueta)
            {
                case 0:
                    ucEtiqueta1.Instance.EstablecerDatos(txtBuscar.Text.Trim());
                    break;
                case 1:
                    ucEtiqueta2.Instance.EstablecerDatos(txtBuscar.Text.Trim());
                    break;
            }
        }

        private void txtBuscar_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:

                    break;
                case 1:
                    
                    break;
            }
        }
    }
}