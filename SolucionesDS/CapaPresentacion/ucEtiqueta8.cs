using DevExpress.XtraEditors;

namespace CapaPresentacion
{
    public partial class ucEtiqueta8 : XtraUserControl
    {

        private static ucEtiqueta8 _instance;

        public static ucEtiqueta8 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta8();
                return _instance;
            }
        }

        public void setDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }

        public ucEtiqueta8()
        {
            InitializeComponent();
        }
    }
}
