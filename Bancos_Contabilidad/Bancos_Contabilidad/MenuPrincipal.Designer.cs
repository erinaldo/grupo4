namespace Bancos_Contabilidad
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.conciliacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeResultadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreContableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasivosFijosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activosFijosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 23);
            this.toolStripMenuItem3.Text = "Estado de cuenta";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItem1.Text = "Estados financieros";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem2.Text = "Reportes";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItem4.Text = "Conciliacion";
            // 
            // conciliacionToolStripMenuItem
            // 
            this.conciliacionToolStripMenuItem.Name = "conciliacionToolStripMenuItem";
            this.conciliacionToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.conciliacionToolStripMenuItem.Text = "Conciliacion";
            // 
            // transaccionalesToolStripMenuItem
            // 
            this.transaccionalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conciliacionToolStripMenuItem});
            this.transaccionalesToolStripMenuItem.Name = "transaccionalesToolStripMenuItem";
            this.transaccionalesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.transaccionalesToolStripMenuItem.Text = "Transaccionales";
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.actividadesToolStripMenuItem.Text = "Cuentas";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadesToolStripMenuItem,
            this.transaccionalesToolStripMenuItem});
            this.procesosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesosToolStripMenuItem.Image")));
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.procesosToolStripMenuItem.Text = "Bancos";
            // 
            // estadoDeResultadosToolStripMenuItem1
            // 
            this.estadoDeResultadosToolStripMenuItem1.Name = "estadoDeResultadosToolStripMenuItem1";
            this.estadoDeResultadosToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.estadoDeResultadosToolStripMenuItem1.Text = "Estado de resultados";
            // 
            // cierreContableToolStripMenuItem
            // 
            this.cierreContableToolStripMenuItem.Name = "cierreContableToolStripMenuItem";
            this.cierreContableToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cierreContableToolStripMenuItem.Text = "Cierre contable";
            // 
            // autorizacionesToolStripMenuItem
            // 
            this.autorizacionesToolStripMenuItem.Name = "autorizacionesToolStripMenuItem";
            this.autorizacionesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.autorizacionesToolStripMenuItem.Text = "Autorizaciones";
            // 
            // transaccionesToolStripMenuItem1
            // 
            this.transaccionesToolStripMenuItem1.Name = "transaccionesToolStripMenuItem1";
            this.transaccionesToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.transaccionesToolStripMenuItem1.Text = "Transacciones";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesToolStripMenuItem1,
            this.autorizacionesToolStripMenuItem,
            this.cierreContableToolStripMenuItem,
            this.estadoDeResultadosToolStripMenuItem1});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.transaccionesToolStripMenuItem.Text = "Transaccionales";
            // 
            // ordenDeCompraToolStripMenuItem
            // 
            this.ordenDeCompraToolStripMenuItem.Name = "ordenDeCompraToolStripMenuItem";
            this.ordenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ordenDeCompraToolStripMenuItem.Text = "Orden de compra";
            this.ordenDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ordenDeCompraToolStripMenuItem_Click);
            // 
            // cuentasPorPagarToolStripMenuItem
            // 
            this.cuentasPorPagarToolStripMenuItem.Name = "cuentasPorPagarToolStripMenuItem";
            this.cuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cuentasPorPagarToolStripMenuItem.Text = "Cuentas por pagar";
            // 
            // planillaToolStripMenuItem
            // 
            this.planillaToolStripMenuItem.Name = "planillaToolStripMenuItem";
            this.planillaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.planillaToolStripMenuItem.Text = "Planilla";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planillaToolStripMenuItem,
            this.cuentasPorPagarToolStripMenuItem,
            this.ordenDeCompraToolStripMenuItem,
            this.pasivosFijosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.alumnosToolStripMenuItem.Text = "Gastos";
            // 
            // pasivosFijosToolStripMenuItem
            // 
            this.pasivosFijosToolStripMenuItem.Name = "pasivosFijosToolStripMenuItem";
            this.pasivosFijosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.pasivosFijosToolStripMenuItem.Text = "Pasivos Fijos";
            this.pasivosFijosToolStripMenuItem.Click += new System.EventHandler(this.pasivosFijosToolStripMenuItem_Click);
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por cobrar";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // cuotaToolStripMenuItem
            // 
            this.cuotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.cuentasPorCobrarToolStripMenuItem,
            this.activosFijosToolStripMenuItem});
            this.cuotaToolStripMenuItem.Name = "cuotaToolStripMenuItem";
            this.cuotaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cuotaToolStripMenuItem.Text = "Ingresos";
            // 
            // activosFijosToolStripMenuItem
            // 
            this.activosFijosToolStripMenuItem.Name = "activosFijosToolStripMenuItem";
            this.activosFijosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.activosFijosToolStripMenuItem.Text = "Activos Fijos";
            this.activosFijosToolStripMenuItem.Click += new System.EventHandler(this.activosFijosToolStripMenuItem_Click);
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuotaToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.catalogosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("catalogosToolStripMenuItem.Image")));
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.catalogosToolStripMenuItem.Text = "Contabilidad";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 320);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem conciliacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeResultadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cierreContableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activosFijosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasivosFijosToolStripMenuItem;
    }
}

