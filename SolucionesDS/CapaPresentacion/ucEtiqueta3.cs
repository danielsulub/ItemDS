using DevExpress.XtraEditors;

namespace CapaPresentacion
{
    public partial class ucEtiqueta3 : XtraUserControl
    {

        private static ucEtiqueta3 _instance;

        public static ucEtiqueta3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta3();
                return _instance;
            }
        }

        public void setDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }

        public ucEtiqueta3()
        {
            InitializeComponent();
        }
    }
}
