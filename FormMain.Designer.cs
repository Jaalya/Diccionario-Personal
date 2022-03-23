
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
            this.lbl_Idioma = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxIdioma = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.rtbIdea = new System.Windows.Forms.RichTextBox();
            this.lbl_Idea = new System.Windows.Forms.Label();
            this.lblTraduccion = new System.Windows.Forms.Label();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.gbInsertar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(190, 90);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(548, 285);
            this.dgvMostrar.TabIndex = 0;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Location = new System.Drawing.Point(27, 323);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(100, 25);
            this.bttnGuardar.TabIndex = 1;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // tbxPalabra
            // 
            this.tbxPalabra.Location = new System.Drawing.Point(13, 124);
            this.tbxPalabra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxPalabra.Name = "tbxPalabra";
            this.tbxPalabra.Size = new System.Drawing.Size(132, 22);
            this.tbxPalabra.TabIndex = 2;
            // 
            // tbxTraduccion
            // 
            this.tbxTraduccion.Location = new System.Drawing.Point(13, 170);
            this.tbxTraduccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTraduccion.Name = "tbxTraduccion";
            this.tbxTraduccion.Size = new System.Drawing.Size(132, 22);
            this.tbxTraduccion.TabIndex = 3;
            // 
            // gbInsertar
            // 
            this.gbInsertar.Controls.Add(this.lbl_Idioma);
            this.gbInsertar.Controls.Add(this.cbxTipo);
            this.gbInsertar.Controls.Add(this.cbxIdioma);
            this.gbInsertar.Controls.Add(this.lblTipo);
            this.gbInsertar.Controls.Add(this.rtbIdea);
            this.gbInsertar.Controls.Add(this.lbl_Idea);
            this.gbInsertar.Controls.Add(this.bttnGuardar);
            this.gbInsertar.Controls.Add(this.lblTraduccion);
            this.gbInsertar.Controls.Add(this.lblPalabra);
            this.gbInsertar.Controls.Add(this.tbxPalabra);
            this.gbInsertar.Controls.Add(this.tbxTraduccion);
            this.gbInsertar.Location = new System.Drawing.Point(12, 27);
            this.gbInsertar.Name = "gbInsertar";
            this.gbInsertar.Size = new System.Drawing.Size(173, 355);
            this.gbInsertar.TabIndex = 7;
            this.gbInsertar.TabStop = false;
            // 
            // lbl_Idioma
            // 
            this.lbl_Idioma.AutoSize = true;
            this.lbl_Idioma.Location = new System.Drawing.Point(10, 18);
            this.lbl_Idioma.Name = "lbl_Idioma";
            this.lbl_Idioma.Size = new System.Drawing.Size(50, 14);
            this.lbl_Idioma.TabIndex = 9;
            this.lbl_Idioma.Text = "Idioma";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Sustantivo",
            "Verbo",
            "Pronombre"});
            this.cbxTipo.Location = new System.Drawing.Point(13, 80);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(132, 22);
            this.cbxTipo.TabIndex = 10;
            // 
            // cbxIdioma
            // 
            this.cbxIdioma.FormattingEnabled = true;
            this.cbxIdioma.Items.AddRange(new object[] {
            "Ingles - Español"});
            this.cbxIdioma.Location = new System.Drawing.Point(13, 38);
            this.cbxIdioma.Name = "cbxIdioma";
            this.cbxIdioma.Size = new System.Drawing.Size(132, 22);
            this.cbxIdioma.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(13, 63);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 14);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo";
            // 
            // rtbIdea
            // 
            this.rtbIdea.Location = new System.Drawing.Point(13, 221);
            this.rtbIdea.Name = "rtbIdea";
            this.rtbIdea.Size = new System.Drawing.Size(129, 96);
            this.rtbIdea.TabIndex = 8;
            this.rtbIdea.Text = "";
            // 
            // lbl_Idea
            // 
            this.lbl_Idea.AutoSize = true;
            this.lbl_Idea.Location = new System.Drawing.Point(10, 200);
            this.lbl_Idea.Name = "lbl_Idea";
            this.lbl_Idea.Size = new System.Drawing.Size(106, 14);
            this.lbl_Idea.TabIndex = 7;
            this.lbl_Idea.Text = "Idea inverosímil";
            // 
            // lblTraduccion
            // 
            this.lblTraduccion.AutoSize = true;
            this.lblTraduccion.Location = new System.Drawing.Point(13, 153);
            this.lblTraduccion.Name = "lblTraduccion";
            this.lblTraduccion.Size = new System.Drawing.Size(73, 14);
            this.lblTraduccion.TabIndex = 6;
            this.lblTraduccion.Text = "Traducción";
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(13, 105);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(55, 14);
            this.lblPalabra.TabIndex = 5;
            this.lblPalabra.Text = "Palabra";
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
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Del";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 392);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Label lbl_Idioma;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxIdioma;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

