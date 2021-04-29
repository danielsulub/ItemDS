
namespace CapaPresentacion
{
    partial class FrmPermisoAcceso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.pnlFondo = new DevExpress.XtraEditors.PanelControl();
            this.groNombrePermiso = new DevExpress.XtraEditors.GroupControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuarioNombre = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario_ = new DevExpress.XtraEditors.LabelControl();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.ButtonEdit();
            this.txtUsuario = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFondo)).BeginInit();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groNombrePermiso)).BeginInit();
            this.groNombrePermiso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlFondo.Controls.Add(this.groNombrePermiso);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1016, 444);
            this.pnlFondo.TabIndex = 0;
            // 
            // groNombrePermiso
            // 
            this.groNombrePermiso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groNombrePermiso.Controls.Add(this.lblPassword);
            this.groNombrePermiso.Controls.Add(this.lblUsuario);
            this.groNombrePermiso.Controls.Add(this.lblUsuarioNombre);
            this.groNombrePermiso.Controls.Add(this.lblUsuario_);
            this.groNombrePermiso.Controls.Add(this.btnAceptar);
            this.groNombrePermiso.Controls.Add(this.txtPassword);
            this.groNombrePermiso.Controls.Add(this.txtUsuario);
            this.groNombrePermiso.Location = new System.Drawing.Point(285, 118);
            this.groNombrePermiso.Name = "groNombrePermiso";
            this.groNombrePermiso.Size = new System.Drawing.Size(418, 185);
            this.groNombrePermiso.TabIndex = 0;
            this.groNombrePermiso.Text = "Nombre permiso";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(79, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(79, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(36, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblUsuarioNombre
            // 
            this.lblUsuarioNombre.Location = new System.Drawing.Point(178, 42);
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.Size = new System.Drawing.Size(75, 13);
            this.lblUsuarioNombre.TabIndex = 4;
            this.lblUsuarioNombre.Text = "Nombre usuario";
            // 
            // lblUsuario_
            // 
            this.lblUsuario_.Location = new System.Drawing.Point(79, 42);
            this.lblUsuario_.Name = "lblUsuario_";
            this.lblUsuario_.Size = new System.Drawing.Size(90, 13);
            this.lblUsuario_.TabIndex = 3;
            this.lblUsuario_.Text = "Permiso al usuario:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(259, 142);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Autorizar";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(178, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "Clear", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Limpiar password", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(178, 70);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "Clear", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Limpiar usuario", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtUsuario.Size = new System.Drawing.Size(156, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // FrmPermisoAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 444);
            this.Controls.Add(this.pnlFondo);
            this.Name = "FrmPermisoAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso restringido";
            this.Load += new System.EventHandler(this.FrmPermisoAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFondo)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groNombrePermiso)).EndInit();
            this.groNombrePermiso.ResumeLayout(false);
            this.groNombrePermiso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlFondo;
        private DevExpress.XtraEditors.GroupControl groNombrePermiso;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuarioNombre;
        private DevExpress.XtraEditors.LabelControl lblUsuario_;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.ButtonEdit txtPassword;
        private DevExpress.XtraEditors.ButtonEdit txtUsuario;
    }
}