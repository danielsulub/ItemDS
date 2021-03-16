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
    public partial class ucEtiqueta0 : XtraUserControl
    {

        private static ucEtiqueta0 _instance;

        public static ucEtiqueta0 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta0();
                return _instance;
            }
        }

        public ucEtiqueta0()
        {
            InitializeComponent();
        }

        public void setDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;            
        }
        
    }
}
