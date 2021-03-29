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
    public partial class ucEtiqueta5 : XtraUserControl
    {

        private static ucEtiqueta5 _instance;

        public static ucEtiqueta5 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta5();
                return _instance;
            }
        }

        public void setDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }

        public ucEtiqueta5()
        {
            InitializeComponent();
        }
    }
}
