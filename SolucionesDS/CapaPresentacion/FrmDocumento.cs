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
        }
    }
}