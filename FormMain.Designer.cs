
namespace Diccionario_Personal
{
    partial class FormMain
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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.tbxPalabra = new System.Windows.Forms.TextBox();
            this.tbxTraduccion = new System.Windows.Forms.TextBox();
            this.gbInsertar = new System.Windows.Forms.GroupBox();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.lblTraduccion = new System.Windows.Forms.Label();
            this.lbl_Idea = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbIdea = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.gbInsertar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(192, 27);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(548, 285);
            this.dgvMostrar.TabIndex = 0;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Location = new System.Drawing.Point(27, 242);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(100, 25);
            this.bttnGuardar.TabIndex = 1;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            // 
            // tbxPalabra
            // 
            this.tbxPalabra.Location = new System.Drawing.Point(10, 38);
            this.tbxPalabra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxPalabra.Name = "tbxPalabra";
            this.tbxPalabra.Size = new System.Drawing.Size(132, 22);
            this.tbxPalabra.TabIndex = 2;
            // 
            // tbxTraduccion
            // 
            this.tbxTraduccion.Location = new System.Drawing.Point(10, 84);
            this.tbxTraduccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTraduccion.Name = "tbxTraduccion";
            this.tbxTraduccion.Size = new System.Drawing.Size(132, 22);
            this.tbxTraduccion.TabIndex = 3;
            // 
            // gbInsertar
            // 
            this.gbInsertar.Controls.Add(this.rtbIdea);
            this.gbInsertar.Controls.Add(this.lbl_Idea);
            this.gbInsertar.Controls.Add(this.bttnGuardar);
            this.gbInsertar.Controls.Add(this.lblTraduccion);
            this.gbInsertar.Controls.Add(this.lblPalabra);
            this.gbInsertar.Controls.Add(this.tbxPalabra);
            this.gbInsertar.Controls.Add(this.tbxTraduccion);
            this.gbInsertar.Location = new System.Drawing.Point(12, 27);
            this.gbInsertar.Name = "gbInsertar";
            this.gbInsertar.Size = new System.Drawing.Size(173, 285);
            this.gbInsertar.TabIndex = 7;
            this.gbInsertar.TabStop = false;
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(10, 19);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(55, 14);
            this.lblPalabra.TabIndex = 5;
            this.lblPalabra.Text = "Palabra";
            // 
            // lblTraduccion
            // 
            this.lblTraduccion.AutoSize = true;
            this.lblTraduccion.Location = new System.Drawing.Point(10, 67);
            this.lblTraduccion.Name = "lblTraduccion";
            this.lblTraduccion.Size = new System.Drawing.Size(73, 14);
            this.lblTraduccion.TabIndex = 6;
            this.lblTraduccion.Text = "Traducción";
            // 
            // lbl_Idea
            // 
            this.lbl_Idea.AutoSize = true;
            this.lbl_Idea.Location = new System.Drawing.Point(10, 119);
            this.lbl_Idea.Name = "lbl_Idea";
            this.lbl_Idea.Size = new System.Drawing.Size(106, 14);
            this.lbl_Idea.TabIndex = 7;
            this.lbl_Idea.Text = "Idea inverosímil";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.preferenciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.preferenciasToolStripMenuItem.Text = "Preferencias";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // rtbIdea
            // 
            this.rtbIdea.Location = new System.Drawing.Point(13, 140);
            this.rtbIdea.Name = "rtbIdea";
            this.rtbIdea.Size = new System.Drawing.Size(129, 96);
            this.rtbIdea.TabIndex = 8;
            this.rtbIdea.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 331);
            this.Controls.Add(this.gbInsertar);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Diccionario Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.gbInsertar.ResumeLayout(false);
            this.gbInsertar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.TextBox tbxPalabra;
        private System.Windows.Forms.TextBox tbxTraduccion;
        private System.Windows.Forms.GroupBox gbInsertar;
        private System.Windows.Forms.Label lbl_Idea;
        private System.Windows.Forms.Label lblTraduccion;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.RichTextBox rtbIdea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

