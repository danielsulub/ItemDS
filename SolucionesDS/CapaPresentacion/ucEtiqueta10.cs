using DevExpress.XtraEditors;

namespace CapaPresentacion
{
    public partial class ucEtiqueta10 : XtraUserControl
    {

        private static ucEtiqueta10 _instance;

        public static ucEtiqueta10 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta10();
                return _instance;
            }
        }

        public void setDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }

        public ucEtiqueta10()
        {
            InitializeComponent();
        }
    }
}
