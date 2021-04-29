using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Configuration;
using System.ComponentModel;

namespace CapaPresentacion
{
    public partial class FrmPeriodo : XtraForm
    {
        public FrmPeriodo()
        {
            InitializeComponent();
        }

        private void FrmPeriodo_Load(object sender, EventArgs e)
        {
            CambiarAppearanceFocused();
            txtFechaInicio.DateTime = DateTime.Now;
            txtFechaFin.DateTime = DateTime.Now;
            txtFechaFin.Focus();
        }

        public void CambiarAppearanceFocused()
        {
            var backColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("BackColorFocus"));
            var foreColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("ForeColorFocus"));

            txtFechaInicio.Properties.AppearanceFocused.BackColor = backColorFocus;
            txtFechaInicio.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            txtFechaFin.Properties.AppearanceFocused.BackColor = backColorFocus;
            txtFechaFin.Properties.AppearanceFocused.ForeColor = foreColorFocus;
        }

        public static Color StringToColor(string colorStr)
        {
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            var result = (Color)cc.ConvertFromString(colorStr);
            return result;
        }
    }
}