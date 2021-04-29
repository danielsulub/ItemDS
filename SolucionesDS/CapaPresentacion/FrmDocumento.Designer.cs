namespace CapaPresentacion
{
    partial class FrmDocumento
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
            this.grdDocumento = new DevExpress.XtraGrid.GridControl();
            this.gridDocumento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlEncabezado = new DevExpress.XtraEditors.PanelControl();
            this.lblBuscar = new DevExpress.XtraEditors.LabelControl();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.txtBuscar = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFondo)).BeginInit();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEncabezado)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
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
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1016, 444);
            this.pnlFondo.TabIndex = 0;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlCuerpo.Controls.Add(this.grdDocumento);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 35);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1016, 409);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // grdDocumento
            // 
            this.grdDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDocumento.Location = new System.Drawing.Point(0, 0);
            this.grdDocumento.MainView = this.gridDocumento;
            this.grdDocumento.Name = "grdDocumento";
            this.grdDocumento.Size = new System.Drawing.Size(1016, 409);
            this.grdDocumento.TabIndex = 0;
            this.grdDocumento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDocumento});
            // 
            // gridDocumento
            // 
            this.gridDocumento.ActiveFilterEnabled = false;
            this.gridDocumento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridDocumento.GridControl = this.grdDocumento;
            this.gridDocumento.Name = "gridDocumento";
            this.gridDocumento.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridDocumento.OptionsSelection.MultiSelect = true;
            this.gridDocumento.OptionsView.ShowDetailButtons = false;
            this.gridDocumento.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridDocumento.OptionsView.ShowGroupPanel = false;
            this.gridDocumento.OptionsView.ShowIndicator = false;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlEncabezado.Controls.Add(this.lblBuscar);
            this.pnlEncabezado.Controls.Add(this.btnImprimir);
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
            this.lblBuscar.Size = new System.Drawing.Size(33, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(370, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(71, 29);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "&Imprimir";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(43, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "Clear", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Limpiar búsqueda", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "Search", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Realizar búsqueda", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtBuscar.Size = new System.Drawing.Size(143, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // FrmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 444);
            this.Controls.Add(this.pnlFondo);
            this.Name = "FrmDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documento";
            this.Load += new System.EventHandler(this.FrmDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFondo)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEncabezado)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlFondo;
        private DevExpress.XtraEditors.PanelControl pnlCuerpo;
        private DevExpress.XtraEditors.PanelControl pnlEncabezado;
        private DevExpress.XtraGrid.GridControl grdDocumento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDocumento;
        private DevExpress.XtraEditors.LabelControl lblBuscar;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.ButtonEdit txtBuscar;
    }
}