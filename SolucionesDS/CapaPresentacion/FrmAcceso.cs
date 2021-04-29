using CapaEntidad;
using CapaNegocio;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace CapaPresentacion
{
    public partial class FrmAcceso : XtraForm
    {

        public FrmAcceso()
        {
            InitializeComponent();
        }

        private void FrmAcceso_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Properties.Resources.ItemDS;
            ShowIcon = false;

            UserLookAndFeel.Default.SetSkinStyle(ConfigurationManager.AppSettings.Get("nombreSkin")); //Skin de los controles internos de la pantalla
            LookAndFeel.SkinName = ConfigurationManager.AppSettings.Get("nombreSkinVentana"); //Skin de la pantalla principal            
            pnlFondo.LookAndFeel.SkinName = UserLookAndFeel.Default.SkinName;

            CambiarAppearanceFocused();            

            ObtenerSociedades();
            if (cboSociedad.Properties.DataSource != null)
            {
                EstablecerSociedad();
            }

            ObtenerGestores();
            if (cboGestor.Properties.DataSource != null)
            {
                EstablecerGestor();                
            }

            if (cboSociedad.EditValue != null & cboGestor.EditValue != null)
            {
                if (cboSucursal.Properties.DataSource != null)
                {                    
                    EstablecerSucursal();                    
                }
            }

            EstablecerDatosAcceso();
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Focus();
            }
            else
            {
                btnAceptar.Focus();
            }

            CargarConfiguracionInicial();
        }

        private void cboSociedad_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:

                    break;
                case 1:
                    ObtenerSociedades();
                    cboSucursal.Properties.DataSource = null;
                    cboSucursal.EditValue = null;
                    cboSucursal.Properties.Columns.Clear();
                    break;
            }
        }

        private void cboGestor_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    break;
                case 1:
                    ObtenerGestores();
                    cboSucursal.Properties.DataSource = null;
                    cboSucursal.EditValue = null;
                    cboSucursal.Properties.Columns.Clear();
                    break;
            }
        }

        private void cboSucursal_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    break;
                case 1:
                    if (cboSociedad.Properties.DataSource != null & cboGestor.Properties.DataSource != null)
                    {
                        if (cboSociedad.EditValue != null & cboGestor.EditValue != null)
                        {
                            ObtenerSucursales(Convert.ToInt16(cboSociedad.EditValue), Convert.ToInt16(cboGestor.EditValue));
                        }
                    }
                    break;
            }
        }

        private void txtUsuario_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    break;
                case 1:
                    txtUsuario.Text = string.Empty;
                    break;
            }

        }

        private void txtPassword_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    txtPassword.Text = string.Empty;
                    break;
            }
        }

        private void cboSociedad_EditValueChanged(object sender, EventArgs e)
        {
            if (cboSociedad.Properties.DataSource != null & cboGestor.Properties.DataSource != null)
            {
                if (cboSociedad.EditValue != null & cboGestor.EditValue != null)
                {                    
                    ObtenerSucursales(Convert.ToInt16(cboSociedad.EditValue), Convert.ToInt16(cboGestor.EditValue));                    
                }
            }
        }

        private void cboGestor_EditValueChanged(object sender, EventArgs e)
        {
            if (cboSociedad.Properties.DataSource != null & cboGestor.Properties.DataSource != null)
            {
                if (cboSociedad.EditValue != null & cboGestor.EditValue != null)
                {                    
                    ObtenerSucursales(Convert.ToInt16(cboSociedad.EditValue), Convert.ToInt16(cboGestor.EditValue));                    
                }
            }
        }

        private void cboSucursal_EditValueChanged(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void GuardarConfiguracionXml()
        {
            string valorNuevo = Convert.ToString("miValor");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "[key_appSettings]")
                            node.Attributes[1].Value = valorNuevo;
                    }
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
            Console.WriteLine(ConfigurationManager.AppSettings.Get("[key_appSettings]"));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            chkRecordarDatosAcceso.IsOn = false;
            txtUsuario.Focus();
        }               

        private void ObtenerSociedades()
        {
            cboSociedad.Properties.DataSource = null;
            cboSociedad.EditValue = null;
            cboSociedad.Properties.Columns.Clear();

            NSociedades objNSociedades = new NSociedades();
            List<ESociedades> sociedades = objNSociedades.ObtenerSociedades();
            if (sociedades.Count > 0)
            {
                cboSociedad.Properties.DropDownRows = (sociedades.Count < 7) ? sociedades.Count : 7;
                cboSociedad.Properties.DataSource = sociedades;
                cboSociedad.Properties.DisplayMember = "Nombre";
                cboSociedad.Properties.ValueMember = "IdSociedad";
                cboSociedad.Properties.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            }
            else
                MostrarMensajeXtra("No existen sociedades activas.");
        }

        private void ObtenerGestores()
        {
            cboGestor.Properties.DataSource = null;
            cboGestor.EditValue = null;
            cboGestor.Properties.Columns.Clear();

            NGestores objNGestores = new NGestores();
            List<EGestores> gestores = objNGestores.ObtenerGestores();
            if (gestores.Count > 0)
            {
                cboGestor.Properties.DropDownRows = (gestores.Count < 7) ? gestores.Count : 7;
                cboGestor.Properties.DataSource = gestores;
                cboGestor.Properties.DisplayMember = "Nombre";
                cboGestor.Properties.ValueMember = "Codigo";
                cboGestor.Properties.Columns.Add(new LookUpColumnInfo("IdGestor", "Número"));
                cboGestor.Properties.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            }
            else
                MostrarMensajeXtra("No existen gestores activos.");
        }

        private void ObtenerSucursales(short idSociedad, short idGestor)
        {
            cboSucursal.Properties.DataSource = null;
            cboSucursal.EditValue = null;
            cboSucursal.Properties.Columns.Clear();

            NSucursales objNSucursales = new NSucursales();
            List<ESucursales> sucursales = objNSucursales.ObtenerSucursales(idSociedad, idGestor);            
            if (sucursales == null) { return; }
            if (sucursales.Count > 0)
            {
                cboSucursal.Properties.DropDownRows = (sucursales.Count < 7) ? sucursales.Count : 7;
                cboSucursal.Properties.DataSource = sucursales;
                cboSucursal.Properties.DisplayMember = "Nombre";
                cboSucursal.Properties.ValueMember = "Codigo";
                cboSucursal.Properties.Columns.Add(new LookUpColumnInfo("Codigo", "Número"));
                cboSucursal.Properties.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            }
            else
                MostrarMensajeXtra("No existen sucursales activas en esa sociedad con ese gestor.");
        }

        private void EstablecerSociedad()
        {
            if (cboSociedad.Properties.DataSource != null)
            {
                string IdSociedad = ConfigurationManager.AppSettings.Get("IdSociedad");
                if (!string.IsNullOrWhiteSpace(IdSociedad))
                {                    
                    cboSociedad.EditValue = Convert.ToInt16(IdSociedad);                    
                }
            }
        }

        private void EstablecerGestor()
        {
            if (cboGestor.Properties.DataSource != null)
            {
                string IdGestor = ConfigurationManager.AppSettings.Get("IdGestor");
                if (!string.IsNullOrWhiteSpace(IdGestor))
                {
                    cboGestor.EditValue = Convert.ToInt16(IdGestor);
                }
            }
        }

        private void EstablecerSucursal()
        {
            if (cboSucursal.Properties.DataSource != null)
            {
                string CodigoSucursal = ConfigurationManager.AppSettings.Get("CodigoSucursal");
                if (!string.IsNullOrWhiteSpace(CodigoSucursal))
                {
                    cboSucursal.EditValue = CodigoSucursal;
                }
            }
        }

        private void EstablecerDatosAcceso()
        {
            txtUsuario.Text = ConfigurationManager.AppSettings.Get("Usuario");
            txtPassword.Text = ConfigurationManager.AppSettings.Get("Password");
            chkRecordarDatosAcceso.IsOn = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("RecordarDatosAcceso"));
        }

        private bool ValidarUsuario(string usuario, string password, short idSociedad)
        {
            bool usuarioValido = false;
            try
            {
                NUsuarios objNUsuarios = new NUsuarios();
                usuarioValido = objNUsuarios.ValidarUsuario(usuario, password, idSociedad);
                return usuarioValido;
            }
            catch (Exception ex)
            {
                MostrarMensajeXtra("Error inesperado: " + ex.Message);
                return usuarioValido;
            }
        }        

        private bool ExisteCambioConexBDSociedad(short idSociedad, short idGestor)
        {
            bool existeCambioConexion = false;
            try
            {
                NSucursales objNSucursal = new NSucursales();
                existeCambioConexion = objNSucursal.ExisteCambioConexBDSociedad(idSociedad, idGestor);
                return existeCambioConexion;
            }
            catch (Exception ex)
            {
                MostrarMensajeXtra("Error inesperado: " + ex.Message);
                return existeCambioConexion;
            }
        }

        public bool EstablecerNuevaConexionBDSociedad(short idSociedad, short idGestor)
        {
            bool nvaConexion = false;
            try
            {
                NSucursales objNSucursal = new NSucursales();
                nvaConexion = objNSucursal.EstablecerNuevaConexionBDSociedad(idSociedad, idGestor);
                return nvaConexion;
            }
            catch (Exception ex)
            {
                MostrarMensajeXtra("Error inesperado: " + ex.Message);
                return nvaConexion;
            }
        }

        private void IniciarSesion()
        {
            if (cboSociedad.EditValue == null)
            {
                MostrarMensajeXtra("Favor de seleccionar una sociedad.");
                cboSociedad.Focus();
                return;
            }

            if (cboGestor.EditValue == null)
            {
                MostrarMensajeXtra("Favor de seleccionar un gestor.");
                cboGestor.Focus();
                return;
            }

            if (cboSucursal.EditValue == null)
            {
                MostrarMensajeXtra("Favor de seleccionar una sucursal.");
                cboSucursal.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MostrarMensajeXtra("Favor de escribir un nombre de usuario.");
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MostrarMensajeXtra("Favor de escribir el password de usuario.");
                txtPassword.Focus();
                return;
            }


            if (ValidarUsuario(txtUsuario.Text, txtPassword.Text, Convert.ToInt16(cboSociedad.EditValue)))
            {
                short idSociedad = Convert.ToInt16(cboSociedad.EditValue);
                short idGestor = Convert.ToInt16(cboGestor.EditValue);
                if (ExisteCambioConexBDSociedad(idSociedad, idGestor))
                {
                    EstablecerNuevaConexionBDSociedad(idSociedad, idGestor);
                }
                RecordarConfiguracion(chkRecordarDatosAcceso.IsOn);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MostrarMensajeXtra("Nombre de usuario o contraseña incorrecta.");
            }
        }

        private void CargarConfiguracionInicial()
        {
            cboGestor.Tag = ConfigurationManager.AppSettings.Get("IdGestor");
            cboSociedad.Tag = ConfigurationManager.AppSettings.Get("IdSociedad");
            cboSucursal.Tag = ConfigurationManager.AppSettings.Get("CodigoSucursal");
            txtUsuario.Tag = ConfigurationManager.AppSettings.Get("Usuario");
            txtPassword.Tag = ConfigurationManager.AppSettings.Get("Password");
            chkRecordarDatosAcceso.Tag = ConfigurationManager.AppSettings.Get("RecordarDatosAcceso");
        }

        private void RecordarConfiguracion(bool recordar)
        {
            try
            {
                bool cambioconfig = false;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (Convert.ToString(cboSociedad.Tag) != Convert.ToString(cboSociedad.EditValue) || Convert.ToString(cboGestor.Tag) != Convert.ToString(cboGestor.EditValue) || Convert.ToString(cboSucursal.Tag) != Convert.ToString(cboSucursal.EditValue))
                {
                    config.AppSettings.Settings["IdSociedad"].Value = Convert.ToString(cboSociedad.EditValue);
                    config.AppSettings.Settings["IdGestor"].Value = Convert.ToString(cboGestor.EditValue);
                    config.AppSettings.Settings["CodigoSucursal"].Value = Convert.ToString(cboSucursal.EditValue);
                    cambioconfig = true;
                }

                if (recordar == true)
                {
                    if (Convert.ToString(txtUsuario.Tag) != Convert.ToString(txtUsuario.Text) || Convert.ToString(txtPassword.Tag) != Convert.ToString(txtPassword.Text))
                    {
                        config.AppSettings.Settings["Usuario"].Value = Convert.ToString(txtUsuario.Text);
                        config.AppSettings.Settings["Password"].Value = Convert.ToString(txtPassword.Text);
                        config.AppSettings.Settings["RecordarDatosAcceso"].Value = Convert.ToString(recordar);
                        cambioconfig = true;
                    }
                }
                else
                {
                    if (Convert.ToString(txtUsuario.Tag) != string.Empty || Convert.ToString(txtPassword.Tag) != string.Empty)
                    {
                        config.AppSettings.Settings["Usuario"].Value = string.Empty;
                        config.AppSettings.Settings["Password"].Value = string.Empty;
                        config.AppSettings.Settings["RecordarDatosAcceso"].Value = Convert.ToString(recordar);
                        cambioconfig = true;
                    }
                }

                if (cambioconfig == true)
                {
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeXtra("Error inesperado al guardar los cambios: " + ex.Message);
            }
        }        

        public void CambiarAppearanceFocused()
        {
            var backColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("BackColorFocus"));
            var foreColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("ForeColorFocus"));

            cboSociedad.Properties.AppearanceFocused.BackColor = backColorFocus;
            cboSociedad.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            cboGestor.Properties.AppearanceFocused.BackColor = backColorFocus;
            cboGestor.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            cboSucursal.Properties.AppearanceFocused.BackColor = backColorFocus;
            cboSucursal.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            txtUsuario.Properties.AppearanceFocused.BackColor = backColorFocus;
            txtUsuario.Properties.AppearanceFocused.ForeColor = foreColorFocus;

            txtPassword.Properties.AppearanceFocused.BackColor = backColorFocus;
            txtPassword.Properties.AppearanceFocused.ForeColor = foreColorFocus;
        }

        public static Color StringToColor(string colorStr)
        {
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            var result = (Color)cc.ConvertFromString(colorStr);
            return result;
        }

        private void MostrarMensajeXtra(string mensaje)
        {
            //Configurar el UserLookAndFeel
            UserLookAndFeel lookAndFeelMsg = new UserLookAndFeel(this);
            lookAndFeelMsg.SkinName = "McSkin";
            lookAndFeelMsg.Style = LookAndFeelStyle.Skin;
            lookAndFeelMsg.UseDefaultLookAndFeel = false;
            //Obligar a los cuadros de mensaje utilizar lookAndFeelMsg
            XtraMessageBox.AllowCustomLookAndFeel = true;
            XtraMessageBox.Show(lookAndFeelMsg, mensaje, "ItemDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}