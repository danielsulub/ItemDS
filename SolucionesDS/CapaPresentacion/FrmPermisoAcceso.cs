using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPermisoAcceso : XtraForm
    {
        public FrmPermisoAcceso()
        {
            InitializeComponent();
        }

        private void FrmPermisoAcceso_Load(object sender, EventArgs e)
        {
            CambiarAppearanceFocused();
            txtUsuario.Focus();
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

            txtUsuario.Properties.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            txtUsuario.Properties.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);

            txtPassword.Properties.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            txtPassword.Properties.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);
        }
    }
}