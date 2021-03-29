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
    public partial class ucEtiqueta1 : XtraUserControl
    {
        private static ucEtiqueta1 _instance;

        public static ucEtiqueta1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta1();
                return _instance;
            }
        }

        public void setDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }

        public ucEtiqueta1()
        {
            InitializeComponent();
        }
        
    }
}
