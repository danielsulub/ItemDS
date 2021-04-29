using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Configuration;
using System.ComponentModel;

namespace CapaPresentacion
{
    public partial class FrmDocumento : XtraForm
    {
        public FrmDocumento()
        {
            InitializeComponent();
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.ItemDS;
            ShowIcon = false;
            CambiarAppearanceFocused();
            txtBuscar.Focus();
        }

        public void CambiarAppearanceFocused()
        {
            var backColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("BackColorFocus"));
            var foreColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("ForeColorFocus"));

            txtBuscar.Properties.AppearanceFocused.BackColor = backColorFocus;
            txtBuscar.Properties.AppearanceFocused.ForeColor = foreColorFocus;
        }
        public static Color StringToColor(string colorStr)
        {
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            var result = (Color)cc.ConvertFromString(colorStr);
            return result;
        }
    }
}