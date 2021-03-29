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
            CambiarAppearanceFocused();
            //cboEtiqueta.SelectedIndex = 1;            
            ucEtiqueta1.Instance.setDatos("ItemDS");            
            EstablecerVersionEtiqueta(1);
        }



        public void CambiarAppearanceFocused()
        {
            string backColorRGB = "255,255,192";
            string foreColorRGB = "64,64,64";
            
            int backColorR;
            int backColorG;
            int backColorB;
            
            int foreColorR;
            int foreColorG;
            int foreColorB;
            
            string[] coloresRGBBackColor = backColorRGB.Split(',');
            string[] coloresRGBForeColor = foreColorRGB.Split(',');

            backColorR = Convert.ToInt32(coloresRGBBackColor[0]);
            backColorG = Convert.ToInt32(coloresRGBBackColor[1]);
            backColorB = Convert.ToInt32(coloresRGBBackColor[2]);

            foreColorR = Convert.ToInt32(coloresRGBForeColor[0]);
            foreColorG = Convert.ToInt32(coloresRGBForeColor[1]);
            foreColorB = Convert.ToInt32(coloresRGBForeColor[2]);

            txtBuscar.Properties.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            txtBuscar.Properties.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);

            txtNumeroEtiquetas.Properties.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            txtNumeroEtiquetas.Properties.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);

            cboFiltro.Properties.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            cboFiltro.Properties.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);

            cboVersionEtiqueta.Properties.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            cboVersionEtiqueta.Properties.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);
        }

        private void EstablecerVersionEtiqueta(sbyte valorEtiqueta)
        {
            switch (valorEtiqueta)
            {
                case 1:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta1.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta1.Instance);
                        ucEtiqueta1.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta1.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta1.Instance.BringToFront();
                break;
                case 2:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta2.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta2.Instance);
                        ucEtiqueta2.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta2.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta2.Instance.BringToFront();
                    break;
                case 3:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta3.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta3.Instance);
                        ucEtiqueta3.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta3.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta3.Instance.BringToFront();
                    break;
                case 4:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta4.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta4.Instance);
                        ucEtiqueta4.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta4.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta4.Instance.BringToFront();
                    break;
                case 5:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta5.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta5.Instance);
                        ucEtiqueta5.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta5.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta5.Instance.BringToFront();
                    break;
                case 6:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta6.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta6.Instance);
                        ucEtiqueta6.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta6.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta6.Instance.BringToFront();
                    break;
                case 7:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta7.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta7.Instance);
                        ucEtiqueta7.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta7.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta7.Instance.BringToFront();
                    break;
                case 8:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta8.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta8.Instance);
                        ucEtiqueta8.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta8.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta8.Instance.BringToFront();
                    break;
                case 9:
                    if (!pnlEstiloEtiquetasCuerpo.Controls.Contains(ucEtiqueta9.Instance))
                    {
                        pnlEstiloEtiquetasCuerpo.Controls.Add(ucEtiqueta9.Instance);
                        ucEtiqueta9.Instance.Dock = DockStyle.Fill;
                        ucEtiqueta9.Instance.BringToFront();
                    }
                    else
                        ucEtiqueta9.Instance.BringToFront();
                    break;
                case 10:
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

        private void txtBuscar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnlEstiloEtiquetasCuerpo.Controls.Clear();            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ucEtiqueta1.Instance.setDatos("ItemDSX");
        }
    }
}