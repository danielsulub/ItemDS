using CapaEntidad;
using CapaNegocio;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace CapaPresentacion
{
    public partial class FrmExplorador : XtraForm
    {

        private EExplorador objEExplorador;
        private readonly NExplorador objNExplorador = new NExplorador();

        public FrmExplorador()
        {
            InitializeComponent();
        }

        private void FrmExplorador_Load(object sender, EventArgs e)
        {
            CambiarAppearanceFocused();
            ObtenerFiltroExplorador();
            if (cboFiltro.Properties.DataSource != null) EstablecerFiltroExplorador();
            txtBuscar.Focus();
            //Ocultar columnas
            //gridArticulos.Columns[7].Visible = false;
            
        }

        private void ObtenerFiltroExplorador()
        {
            cboFiltro.Properties.DataSource = null;
            cboFiltro.EditValue = null;
            cboFiltro.Properties.Columns.Clear();
            cboFiltro.Properties.ShowHeader = false;
            cboFiltro.Properties.ShowFooter = false;

            NFiltroExplorador objNFiltroExplorador = new NFiltroExplorador();
            List<EFiltroExplorador> filtros = objNFiltroExplorador.ObtenerFiltroExplorador();
            if (filtros.Count > 0)
            {
                cboFiltro.Properties.DropDownRows = (filtros.Count < 7) ? filtros.Count : 7;
                cboFiltro.Properties.DataSource = filtros;
                cboFiltro.Properties.DisplayMember = "Nombre";
                cboFiltro.Properties.ValueMember = "Codigo";
                cboFiltro.Properties.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
                EstablecerFiltroExplorador();
            }            
            else
                MostrarMensajeXtra("No existen filtro activos.");
        }

        private void EstablecerFiltroExplorador()
        {
            cboFiltro.EditValue = Convert.ToInt16(ConfigurationManager.AppSettings.Get("IdFiltroExplorador"));
        }

        private void ObtenerArticulos(string datoBuscar)
        {
            if (!string.IsNullOrWhiteSpace(datoBuscar))
            {
                List<EExplorador> articulos = objNExplorador.ObtenerArticulos(datoBuscar);
                if (articulos.Count > 0)
                {
                    grdArticulos.DataSource = articulos;
                }
                else
                    MostrarMensaje("No se encontraron artículos.");
            }            
        }

        private void MostrarMensajeXtra(string mensaje)
        {
            //Configurar el UserLookAndFeel 
            UserLookAndFeel lookAndFeelMsg = new UserLookAndFeel(this);
            lookAndFeelMsg.SkinName = "McSkin";
            lookAndFeelMsg.Style = LookAndFeelStyle.Skin;
            lookAndFeelMsg.UseDefaultLookAndFeel = false;
            //Obligar a los cuadros de mensaje utilizar lookAndFeelMsg
            XtraMessageBox.AllowCustomLookAndFeel = true;
            XtraMessageBox.Show(lookAndFeelMsg, mensaje, "ItemDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarMensaje(string mensaje)
        {

        }

        public void CambiarAppearanceFocused()
        {
            var backColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("BackColorFocus"));
            var foreColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("ForeColorFocus"));

            var backColorGridUbicacion = StringToColor(ConfigurationManager.AppSettings.Get("BackColorGridUbicacion"));
            var foreColorGridUbicacion = StringToColor(ConfigurationManager.AppSettings.Get("ForeColorGridUbicacion"));
            
            txtBuscar.Properties.AppearanceFocused.BackColor = backColorFocus;
            txtBuscar.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            cboFiltro.Properties.AppearanceFocused.BackColor = backColorFocus;
            cboFiltro.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            gridArticulos.Columns[8].AppearanceCell.BackColor = backColorGridUbicacion;
            gridArticulos.Columns[8].AppearanceCell.ForeColor = foreColorGridUbicacion;
            /*gridArticulos.Appearance.FocusedCell.BackColor = gridArticulos.Appearance.FocusedRow.BackColor;
            gridArticulos.Appearance.FocusedRow.BackColor = Color.FromArgb(0, 102, 153);*/
        }

        public static Color StringToColor(string colorStr)
        {
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            var result = (Color)cc.ConvertFromString(colorStr);
            return result;
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    txtBuscar.Text = string.Empty;
                    break;
                case 1:                    
                    ObtenerArticulos(txtBuscar.Text);
                    break;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ObtenerArticulos(txtBuscar.Text);
            }
        }
    }
}