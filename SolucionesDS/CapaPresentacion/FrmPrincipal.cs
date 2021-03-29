using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using CapaPresentacion.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : XtraForm
    {
        private string nombreSistema = "ItemDS";
        private string nombreSkin = "McSkin";
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Tamaño del form principal: 1020, 580            
            LookAndFeel.SkinName = nombreSkin;
            CambiarAppearanceFocused();
            Text = nombreSistema;
            Tag = nombreSistema;
            pgbAvance.Visibility = BarItemVisibility.Never;
            bar1.Visible = true; //Barra de herramientas
            bar2.Visible = false; //Barra de menus
            Icon = Resources.ItemDS;
            mostrarMensaje("Hola, Bienvenido al sistema", Color.Empty);            
            
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful"); //Skin de los controles internos de la pantalla
            LookAndFeel.SkinName = "McSkin"; //Skin de la pantalla principal
            barAndDockingController1.LookAndFeel.SkinName = "McSkin";            
            pnlContenedorFrm.LookAndFeel.SkinName = UserLookAndFeel.Default.SkinName;
        }

        public void CambiarAppearanceFocused()
        {
            string backColorRGB = "255,255,192";
            string foreColorRGB = "64,64,64";

            int backColorR;
            int backColorG;
            int backColorB;

            int foreColorR;
            int foreColorG;
            int foreColorB;

            string[] coloresRGBBackColor = backColorRGB.Split(',');
            string[] coloresRGBForeColor = foreColorRGB.Split(',');

            backColorR = Convert.ToInt32(coloresRGBBackColor[0]);
            backColorG = Convert.ToInt32(coloresRGBBackColor[1]);
            backColorB = Convert.ToInt32(coloresRGBBackColor[2]);

            foreColorR = Convert.ToInt32(coloresRGBForeColor[0]);
            foreColorG = Convert.ToInt32(coloresRGBForeColor[1]);
            foreColorB = Convert.ToInt32(coloresRGBForeColor[2]);

            cboSucursal.Edit.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            cboSucursal.Edit.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);

            cboImpresora.Edit.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            cboImpresora.Edit.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);

            cboEtiqueta.Edit.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            cboEtiqueta.Edit.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);

            cboMedidaEtiqueta.Edit.AppearanceFocused.BackColor = Color.FromArgb(backColorR, backColorG, backColorB);
            cboMedidaEtiqueta.Edit.AppearanceFocused.ForeColor = Color.FromArgb(foreColorR, foreColorG, foreColorB);
        }

        private void barAndDockingController1_Changed(object sender, EventArgs e)
        {
            barAndDockingController1.LookAndFeel.SkinName = UserLookAndFeel.Default.SkinName;
            pnlContenedorFrm.LookAndFeel.SkinName = UserLookAndFeel.Default.SkinName;
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
            abrirFormulario<FrmProducto>();
        }

        private void btnDocumento_ItemClick(object sender, ItemClickEventArgs e)
        {
            abrirFormulario<FrmDocumento>();
        }

        private void btnPeriodo_ItemClick(object sender, ItemClickEventArgs e)
        {
            abrirFormulario<FrmPeriodo>();
        }

        private void btnExplorador_ItemClick(object sender, ItemClickEventArgs e)
        {
            abrirFormulario<FrmExplorador>();
        }

        private void btnPedidos_ItemClick(object sender, ItemClickEventArgs e)
        {
            abrirFormulario<FrmPedidos>();
        }

        private void btnInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            abrirFormulario<FrmInventario>();
        }

        private void btnChecadorPrecios_ItemClick(object sender, ItemClickEventArgs e)
        {
            abrirFormulario<FrmChecador>();
        }

        private void btnReportes_ItemClick(object sender, ItemClickEventArgs e)
        {
            abrirFormulario<FrmReportes>();            
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
    }
}