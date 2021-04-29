using DevExpress.XtraEditors;

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
