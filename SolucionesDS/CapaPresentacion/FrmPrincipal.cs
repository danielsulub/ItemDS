using CapaPresentacion.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using System.Collections.Generic;


namespace CapaPresentacion
{
    public partial class FrmPrincipal : XtraForm
    {
        private string nombreSistema = "ItemDS";        

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Tamaño del form principal: 1020, 580
            Text = nombreSistema;
            Tag = nombreSistema;
            Icon = Resources.ItemDS;

            //UserLookAndFeel.Default.SetSkinStyle(ConfigurationManager.AppSettings.Get("nombreSkin")); //Skin de los controles internos de la pantalla
            LookAndFeel.SkinName = ConfigurationManager.AppSettings.Get("nombreSkinVentana"); //Skin de la pantalla principal
            barAndDockingController1.LookAndFeel.SkinName = ConfigurationManager.AppSettings.Get("nombreSkin");
            pnlContenedorFrm.LookAndFeel.SkinName = UserLookAndFeel.Default.SkinName;
            
            CambiarAppearanceFocused();

            pgbAvance.Visibility = BarItemVisibility.Never;

            bar1.Visible = true; //Barra de herramientas
            bar3.Visible = true; //Barra de estado
            bar2.Visible = false; //Barra de menus
            string numFormulario = ConfigurationManager.AppSettings.Get("NumeroFormularioInicial");
            if (!string.IsNullOrWhiteSpace(numFormulario))
            {
                if (numFormulario.All(char.IsDigit))
                {
                    AbrirNumFormulario(Convert.ToInt16(ConfigurationManager.AppSettings.Get("NumeroFormularioInicial")));
                }
            }

            ObtenerSucursales();
            ObtenerImpresoras();
            ObtenerVersionEtiquetas();
            ObtenerMedidaEtiquetas();
            if (repositoryCboSucursal.DataSource != null) EstablecerSucursal();
            if (repositoryCboImpresora.DataSource != null) EstablecerImpresora();
            if (repositoryCboEtiqueta.DataSource != null) EstablecerVersionEtiqueta();
            if (repositoryCboMedidaEtiqueta.DataSource != null) EstablecerMedidaEtiqueta();
        }        

        public void CambiarAppearanceFocused()
        {
            var backColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("BackColorFocus"));
            var foreColorFocus = StringToColor(ConfigurationManager.AppSettings.Get("ForeColorFocus"));

            cboSucursal.Edit.AppearanceFocused.BackColor = backColorFocus;
            cboSucursal.Edit.AppearanceFocused.ForeColor = foreColorFocus;

            cboImpresora.Edit.AppearanceFocused.BackColor = backColorFocus;
            cboImpresora.Edit.AppearanceFocused.ForeColor = foreColorFocus;

            cboEtiqueta.Edit.AppearanceFocused.BackColor = backColorFocus;
            cboEtiqueta.Edit.AppearanceFocused.ForeColor = foreColorFocus;

            cboMedidaEtiqueta.Edit.AppearanceFocused.BackColor = backColorFocus;
            cboMedidaEtiqueta.Edit.AppearanceFocused.ForeColor = foreColorFocus;
        }

        private void barAndDockingController1_Changed(object sender, EventArgs e)
        {
            barAndDockingController1.LookAndFeel.SkinName = UserLookAndFeel.Default.SkinName;
            pnlContenedorFrm.LookAndFeel.SkinName = UserLookAndFeel.Default.SkinName;
        }

        private void ObtenerSucursales()
        {
            repositoryCboSucursal.DataSource = null;
            cboSucursal.EditValue = null;            
            repositoryCboSucursal.Columns.Clear();

            NSucursales objNSucursales = new NSucursales();
            List<ESucursales> sucursales = objNSucursales.ObtenerSucursales();
            if (sucursales == null) { return; }
            if (sucursales.Count > 0)
            {
                repositoryCboSucursal.DropDownRows = (sucursales.Count < 7) ? sucursales.Count : 7;
                repositoryCboSucursal.DataSource = sucursales;
                repositoryCboSucursal.DisplayMember = "Nombre";
                repositoryCboSucursal.ValueMember = "Codigo";
                repositoryCboSucursal.Columns.Add(new LookUpColumnInfo("Codigo", "Número"));
                repositoryCboSucursal.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            }
            else
                MessageBox.Show("No existen sucursales activas en esa sociedad.");
        }

        private void ObtenerImpresoras()
        {
            repositoryCboImpresora.DataSource = null;
            cboImpresora.EditValue = null;
            repositoryCboImpresora.Columns.Clear();
            repositoryCboImpresora.ShowHeader = false;
            repositoryCboImpresora.ShowFooter = false;

            NImpresoras objNImpresoras = new NImpresoras();
            List<EImpresoras> impresoras = objNImpresoras.ObtenerImpresoras();            
            if (impresoras.Count > 0)
            {
                repositoryCboImpresora.DropDownRows = (impresoras.Count < 7) ? impresoras.Count : 7;
                repositoryCboImpresora.DataSource = impresoras;
                repositoryCboImpresora.DisplayMember = "Nombre";
                repositoryCboImpresora.ValueMember = "IdImpresora";                
                repositoryCboImpresora.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            }
            else
                MessageBox.Show("No existen impresoras.");
        }

        private void ObtenerVersionEtiquetas()
        {
            repositoryCboEtiqueta.DataSource = null;
            cboEtiqueta.EditValue = null;            
            repositoryCboEtiqueta.Columns.Clear();

            NVersionEtiqueta objNVersionEtiqueta = new NVersionEtiqueta();
            List<EVersionEtiqueta> versionesEtiqueta = objNVersionEtiqueta.ObtenerVersionEtiqueta(Convert.ToInt16(ConfigurationManager.AppSettings.Get("IdSociedad")));            
            if (versionesEtiqueta.Count > 0)
            {
                repositoryCboEtiqueta.DropDownRows = (versionesEtiqueta.Count < 7) ? versionesEtiqueta.Count : 7;
                repositoryCboEtiqueta.DataSource = versionesEtiqueta;
                repositoryCboEtiqueta.DisplayMember = "Nombre";
                repositoryCboEtiqueta.ValueMember = "IdVersionEtiqueta";                
                repositoryCboEtiqueta.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            }
            else
                MessageBox.Show("No existen etiquetas para la sociedad actual.");
        }

        private void ObtenerMedidaEtiquetas()
        {
            repositoryCboMedidaEtiqueta.DataSource = null;
            cboMedidaEtiqueta.EditValue = null;
            repositoryCboMedidaEtiqueta.Columns.Clear();
            repositoryCboMedidaEtiqueta.ShowHeader = false;
            repositoryCboMedidaEtiqueta.ShowFooter = false;

            NMedidaEtiqueta objNMedidaEtiqueta = new NMedidaEtiqueta();
            List<EMedidaEtiqueta> medidaEtiquetas = objNMedidaEtiqueta.ObtenerMedidaEtiqueta();            
            if (medidaEtiquetas.Count > 0)
            {
                repositoryCboMedidaEtiqueta.DropDownRows = (medidaEtiquetas.Count < 7) ? medidaEtiquetas.Count : 7;
                repositoryCboMedidaEtiqueta.DataSource = medidaEtiquetas;
                repositoryCboMedidaEtiqueta.DisplayMember = "Nombre";
                repositoryCboMedidaEtiqueta.ValueMember = "IdMedidaEtiqueta";                
                repositoryCboMedidaEtiqueta.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            }
            else
                MessageBox.Show("No existen medida de etiquetas.");
        }

        private void EstablecerSucursal()
        {
            cboSucursal.EditValue = ConfigurationManager.AppSettings.Get("CodigoSucursal");
        }

        private void EstablecerImpresora()
        {
            cboImpresora.EditValue = Convert.ToInt16(ConfigurationManager.AppSettings.Get("IdImpresora"));
        }

        private void EstablecerVersionEtiqueta()
        {
            cboEtiqueta.EditValue = Convert.ToInt16(ConfigurationManager.AppSettings.Get("IdVersionEtiqueta"));
        }

        private void EstablecerMedidaEtiqueta()
        {
            cboMedidaEtiqueta.EditValue = Convert.ToInt16(ConfigurationManager.AppSettings.Get("IdMedidaEtiqueta"));
        }

        private void btnInicio_ItemClick(object sender, ItemClickEventArgs e)
        {
            cerrarFormulario<FrmProducto>();
            cerrarFormulario<FrmDocumento>();
            cerrarFormulario<FrmPeriodo>();
            cerrarFormulario<FrmExplorador>();
            cerrarFormulario<FrmInventario>();
            cerrarFormulario<FrmPedidos>();
            cerrarFormulario<FrmChecador>();
            cerrarFormulario<FrmReportes>();
            cerrarFormulario<FrmPermisoAcceso>();
            pnlContenedorFrm.BorderStyle = BorderStyles.Default;
            Text = Convert.ToString(Tag);
        }

        private void btnProducto_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirNumFormulario(1);
        }

        private void btnDocumento_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirNumFormulario(2);
        }

        private void btnPeriodo_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirNumFormulario(3);
        }

        private void btnExplorador_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirNumFormulario(4);
        }

        private void btnPedidos_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirNumFormulario(5);
        }

        private void btnInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirNumFormulario(6);
        }

        private void btnChecadorPrecios_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirNumFormulario(7);
        }

        private void btnReportes_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirNumFormulario(8);            
        }

        private void AbrirNumFormulario(short numFormulario)
        {
            switch (numFormulario)
            {
                case 1:
                    abrirFormulario<FrmProducto>();
                    break;
                case 2:
                    abrirFormulario<FrmDocumento>();
                    break;
                case 3:
                    abrirFormulario<FrmPeriodo>();
                    break;
                case 4:
                    abrirFormulario<FrmExplorador>();
                    break;
                case 5:
                    abrirFormulario<FrmPedidos>();
                    break;
                case 6:
                    abrirFormulario<FrmInventario>();
                    break;
                case 7:
                    abrirFormulario<FrmChecador>();
                    break;
                case 8:
                    abrirFormulario<FrmReportes>();
                    break;
            }
        }

        private void abrirFormulario<miForm>() where miForm : XtraForm, new()
        {
            XtraForm frm;
            //Busca el formulario en la colección.
            frm = pnlContenedorFrm.Controls.OfType<miForm>().FirstOrDefault();
            //Si el formulario/instancia no existe.
            if (frm == null)
            {
                frm = new miForm();
                AddOwnedForm(frm); //Nuevo borrar
                frm.TopLevel = false;
                frm.Size = Size; //frm.Size = pnlContenedorFrm.Size;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                pnlContenedorFrm.BorderStyle = BorderStyles.NoBorder;
                pnlContenedorFrm.Controls.Add(frm);
                pnlContenedorFrm.Tag = frm;
                frm.Show();
                frm.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                frm.BringToFront();
            }
            Text = Tag + "|" + frm.Text;
        }

        private void cerrarFormulario<miForm>() where miForm : XtraForm, new()
        {
            XtraForm frm;
            //Busca en la colecion el formulario.
            frm = pnlContenedorFrm.Controls.OfType<miForm>().FirstOrDefault();
            //Si el formulario/instancia existe.
            if (frm != null)
            {
                frm.Close();
                frm.Dispose();
            }
        }

        private void mostrarMensaje(string mensaje, Color colorCinta)
        {
            lblMensaje.Caption = mensaje;
            lblMensaje.ItemAppearance.Normal.BackColor = colorCinta;
            lblIVA.ItemAppearance.Normal.BackColor = colorCinta;
            bar3.BarAppearance.Normal.BackColor = colorCinta;
        }

        public static Color StringToColor(string colorStr)
        {
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            var result = (Color)cc.ConvertFromString(colorStr);
            return result;
        }
    }
}