namespace CapaPresentacion
{
    partial class FrmExplorador
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
            this.pnlCuerpo = new DevExpress.XtraEditors.PanelControl();
            this.grdArticulos = new DevExpress.XtraGrid.GridControl();
            this.gridArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlEncabezado = new DevExpress.XtraEditors.PanelControl();
            this.lblBuscar = new DevExpress.XtraEditors.LabelControl();
            this.chkTipoBusqueda = new DevExpress.XtraEditors.ToggleSwitch();
            this.cboFiltro = new DevExpress.XtraEditors.LookUpEdit();
            this.txtBuscar = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFondo)).BeginInit();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEncabezado)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTipoBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlFondo.Controls.Add(this.pnlCuerpo);
            this.pnlFondo.Controls.Add(this.pnlEncabezado);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.pnlFondo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1016, 444);
            this.pnlFondo.TabIndex = 0;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlCuerpo.Controls.Add(this.grdArticulos);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 35);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1016, 409);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // grdArticulos
            // 
            this.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdArticulos.Location = new System.Drawing.Point(0, 0);
            this.grdArticulos.MainView = this.gridArticulos;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.Size = new System.Drawing.Size(1016, 409);
            this.grdArticulos.TabIndex = 0;
            this.grdArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridArticulos});
            // 
            // gridArticulos
            // 
            this.gridArticulos.GridControl = this.grdArticulos;
            this.gridArticulos.Name = "gridArticulos";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlEncabezado.Controls.Add(this.lblBuscar);
            this.pnlEncabezado.Controls.Add(this.chkTipoBusqueda);
            this.pnlEncabezado.Controls.Add(this.cboFiltro);
            this.pnlEncabezado.Controls.Add(this.txtBuscar);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1016, 35);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Location = new System.Drawing.Point(5, 11);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(32, 13);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar";
            // 
            // chkTipoBusqueda
            // 
            this.chkTipoBusqueda.Location = new System.Drawing.Point(597, 9);
            this.chkTipoBusqueda.Name = "chkTipoBusqueda";
            this.chkTipoBusqueda.Properties.OffText = "";
            this.chkTipoBusqueda.Properties.OnText = "";
            this.chkTipoBusqueda.Size = new System.Drawing.Size(95, 18);
            this.chkTipoBusqueda.TabIndex = 2;
            // 
            // cboFiltro
            // 
            this.cboFiltro.Location = new System.Drawing.Point(447, 8);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFiltro.Size = new System.Drawing.Size(143, 20);
            this.cboFiltro.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(43, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "Clear", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Limpiar búsqueda", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "Search", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Realizar búsqueda", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtBuscar.Size = new System.Drawing.Size(398, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // FrmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 444);
            this.Controls.Add(this.pnlFondo);
            this.Name = "FrmExplorador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorador";
            this.Load += new System.EventHandler(this.FrmExplorador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFondo)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEncabezado)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTipoBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlFondo;
        private DevExpress.XtraEditors.PanelControl pnlCuerpo;
        private DevExpress.XtraEditors.PanelControl pnlEncabezado;
        private DevExpress.XtraGrid.GridControl grdArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridArticulos;
        private DevExpress.XtraEditors.LabelControl lblBuscar;
        private DevExpress.XtraEditors.ToggleSwitch chkTipoBusqueda;
        private DevExpress.XtraEditors.LookUpEdit cboFiltro;
        private DevExpress.XtraEditors.ButtonEdit txtBuscar;
    }
}