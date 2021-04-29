using DevExpress.XtraEditors;

namespace CapaPresentacion
{
    public partial class ucEtiqueta2 : XtraUserControl
    {

        private static ucEtiqueta2 _instance;

        public static ucEtiqueta2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta2();
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

        public ucEtiqueta2()
        {
            InitializeComponent();
        }
    }
}
