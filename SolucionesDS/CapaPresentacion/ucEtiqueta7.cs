using DevExpress.XtraEditors;

namespace CapaPresentacion
{
    public partial class ucEtiqueta7 : XtraUserControl
    {

        private static ucEtiqueta7 _instance;

        public static ucEtiqueta7 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta7();
                return _instance;
            }
        }

        public void setDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }

        public ucEtiqueta7()
        {
            InitializeComponent();
        }
    }
}
