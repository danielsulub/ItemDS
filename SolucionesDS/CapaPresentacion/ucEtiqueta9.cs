using DevExpress.XtraEditors;

namespace CapaPresentacion
{
    public partial class ucEtiqueta9 : XtraUserControl
    {

        private static ucEtiqueta9 _instance;

        public static ucEtiqueta9 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEtiqueta9();
                return _instance;
            }
        }

        public void setDatos(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }
        public ucEtiqueta9()
        {
            InitializeComponent();
        }
    }
}
