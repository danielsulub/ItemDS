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
    public partial class ucEtiqueta6 : XtraUserControl
    {

        private static ucEtiqueta6 _instance;

        public static ucEtiqueta6 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta6();
                return _instance;
            }
        }

        public void setDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }

        public ucEtiqueta6()
        {
            InitializeComponent();
        }
    }
}
