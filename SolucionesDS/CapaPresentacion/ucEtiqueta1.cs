using DevExpress.XtraEditors;

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

        public void EstablecerDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }

        public void LimpiarDatos()
        {
            lblMensaje.Text = string.Empty;            
        }

        public ucEtiqueta1()
        {
            InitializeComponent();
        }

    }
}
