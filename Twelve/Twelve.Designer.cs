namespace Twelve
{
    partial class frm_Twelve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Twelve));
            this.btn_ModoNormal = new System.Windows.Forms.Button();
            this.btn_ModoAgresivo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegoNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarTableroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Puntuacion = new System.Windows.Forms.Label();
            this.pbx_Tablero = new System.Windows.Forms.PictureBox();
            this.gbox_Personalizar = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Columnas = new System.Windows.Forms.NumericUpDown();
            this.nud_Filas = new System.Windows.Forms.NumericUpDown();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_Puntuacion1 = new System.Windows.Forms.Label();
            this.lbl_Best1 = new System.Windows.Forms.Label();
            this.lbl_Best = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gbx_MenuPrincipal = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Tablero)).BeginInit();
            this.gbox_Personalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Columnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Filas)).BeginInit();
            this.gbx_MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ModoNormal
            // 
            this.btn_ModoNormal.BackColor = System.Drawing.Color.White;
            this.btn_ModoNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModoNormal.BackgroundImage")));
            this.btn_ModoNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModoNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModoNormal.Location = new System.Drawing.Point(10, 19);
            this.btn_ModoNormal.Name = "btn_ModoNormal";
            this.btn_ModoNormal.Size = new System.Drawing.Size(286, 82);
            this.btn_ModoNormal.TabIndex = 0;
            this.btn_ModoNormal.UseVisualStyleBackColor = false;
            this.btn_ModoNormal.Click += new System.EventHandler(this.btn_ModoNormal_Click);
            // 
            // btn_ModoAgresivo
            // 
            this.btn_ModoAgresivo.BackColor = System.Drawing.Color.White;
            this.btn_ModoAgresivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModoAgresivo.BackgroundImage")));
            this.btn_ModoAgresivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModoAgresivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModoAgresivo.Location = new System.Drawing.Point(10, 122);
            this.btn_ModoAgresivo.Name = "btn_ModoAgresivo";
            this.btn_ModoAgresivo.Size = new System.Drawing.Size(286, 82);
            this.btn_ModoAgresivo.TabIndex = 1;
            this.btn_ModoAgresivo.UseVisualStyleBackColor = false;
            this.btn_ModoAgresivo.Click += new System.EventHandler(this.btn_ModoAgresivo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúPrincipalToolStripMenuItem,
            this.juegoNuevoToolStripMenuItem,
            this.guardarPartidaToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // menúPrincipalToolStripMenuItem
            // 
            this.menúPrincipalToolStripMenuItem.Name = "menúPrincipalToolStripMenuItem";
            this.menúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.menúPrincipalToolStripMenuItem.Text = "Menú Principal";
            this.menúPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menúPrincipalToolStripMenuItem_Click);
            // 
            // juegoNuevoToolStripMenuItem
            // 
            this.juegoNuevoToolStripMenuItem.Enabled = false;
            this.juegoNuevoToolStripMenuItem.Name = "juegoNuevoToolStripMenuItem";
            this.juegoNuevoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.juegoNuevoToolStripMenuItem.Text = "Juego Nuevo";
            this.juegoNuevoToolStripMenuItem.Click += new System.EventHandler(this.juegoNuevoToolStripMenuItem_Click);
            // 
            // guardarPartidaToolStripMenuItem
            // 
            this.guardarPartidaToolStripMenuItem.Enabled = false;
            this.guardarPartidaToolStripMenuItem.Name = "guardarPartidaToolStripMenuItem";
            this.guardarPartidaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.guardarPartidaToolStripMenuItem.Text = "Guardar Partida";
            this.guardarPartidaToolStripMenuItem.Click += new System.EventHandler(this.guardarPartidaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ffToolStripMenuItem
            // 
            this.ffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarTableroToolStripMenuItem,
            this.sonidoToolStripMenuItem});
            this.ffToolStripMenuItem.Name = "ffToolStripMenuItem";
            this.ffToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.ffToolStripMenuItem.Text = "Personalizar";
            // 
            // cambiarTableroToolStripMenuItem
            // 
            this.cambiarTableroToolStripMenuItem.Enabled = false;
            this.cambiarTableroToolStripMenuItem.Name = "cambiarTableroToolStripMenuItem";
            this.cambiarTableroToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cambiarTableroToolStripMenuItem.Text = "Cambiar tablero";
            this.cambiarTableroToolStripMenuItem.Click += new System.EventHandler(this.cambiarTableroToolStripMenuItem_Click);
            // 
            // sonidoToolStripMenuItem
            // 
            this.sonidoToolStripMenuItem.Checked = true;
            this.sonidoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sonidoToolStripMenuItem.Name = "sonidoToolStripMenuItem";
            this.sonidoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sonidoToolStripMenuItem.Text = "Sonido";
            this.sonidoToolStripMenuItem.Click += new System.EventHandler(this.sonidoToolStripMenuItem_Click);
            // 
            // lbl_Puntuacion
            // 
            this.lbl_Puntuacion.AutoSize = true;
            this.lbl_Puntuacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Puntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Puntuacion.Location = new System.Drawing.Point(122, 103);
            this.lbl_Puntuacion.Name = "lbl_Puntuacion";
            this.lbl_Puntuacion.Size = new System.Drawing.Size(61, 18);
            this.lbl_Puntuacion.TabIndex = 4;
            this.lbl_Puntuacion.Text = "Puntos";
            this.lbl_Puntuacion.Visible = false;
            // 
            // pbx_Tablero
            // 
            this.pbx_Tablero.BackColor = System.Drawing.Color.White;
            this.pbx_Tablero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Tablero.Location = new System.Drawing.Point(12, 127);
            this.pbx_Tablero.Name = "pbx_Tablero";
            this.pbx_Tablero.Size = new System.Drawing.Size(338, 357);
            this.pbx_Tablero.TabIndex = 5;
            this.pbx_Tablero.TabStop = false;
            this.pbx_Tablero.Visible = false;
            this.pbx_Tablero.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_Tablero_Paint);
            this.pbx_Tablero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_Tablero_MouseClick);
            // 
            // gbox_Personalizar
            // 
            this.gbox_Personalizar.BackColor = System.Drawing.Color.White;
            this.gbox_Personalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbox_Personalizar.BackgroundImage")));
            this.gbox_Personalizar.Controls.Add(this.btn_Cancelar);
            this.gbox_Personalizar.Controls.Add(this.label2);
            this.gbox_Personalizar.Controls.Add(this.label1);
            this.gbox_Personalizar.Controls.Add(this.nud_Columnas);
            this.gbox_Personalizar.Controls.Add(this.nud_Filas);
            this.gbox_Personalizar.Controls.Add(this.btn_Aceptar);
            this.gbox_Personalizar.Location = new System.Drawing.Point(16, 49);
            this.gbox_Personalizar.Name = "gbox_Personalizar";
            this.gbox_Personalizar.Size = new System.Drawing.Size(39, 35);
            this.gbox_Personalizar.TabIndex = 6;
            this.gbox_Personalizar.TabStop = false;
            this.gbox_Personalizar.Visible = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(37, 108);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(90, 27);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de columnas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de filas";
            // 
            // nud_Columnas
            // 
            this.nud_Columnas.Location = new System.Drawing.Point(173, 60);
            this.nud_Columnas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Columnas.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_Columnas.Name = "nud_Columnas";
            this.nud_Columnas.Size = new System.Drawing.Size(66, 20);
            this.nud_Columnas.TabIndex = 2;
            this.nud_Columnas.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nud_Filas
            // 
            this.nud_Filas.Location = new System.Drawing.Point(173, 24);
            this.nud_Filas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Filas.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Filas.Name = "nud_Filas";
            this.nud_Filas.Size = new System.Drawing.Size(66, 20);
            this.nud_Filas.TabIndex = 1;
            this.nud_Filas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.Location = new System.Drawing.Point(158, 108);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(90, 27);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 490);
            this.progressBar1.Maximum = 15;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(338, 13);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Visible = false;
            // 
            // lbl_Puntuacion1
            // 
            this.lbl_Puntuacion1.AutoSize = true;
            this.lbl_Puntuacion1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Puntuacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Puntuacion1.Location = new System.Drawing.Point(12, 102);
            this.lbl_Puntuacion1.Name = "lbl_Puntuacion1";
            this.lbl_Puntuacion1.Size = new System.Drawing.Size(104, 20);
            this.lbl_Puntuacion1.TabIndex = 19;
            this.lbl_Puntuacion1.Text = "Puntuación:";
            this.lbl_Puntuacion1.Visible = false;
            // 
            // lbl_Best1
            // 
            this.lbl_Best1.AutoSize = true;
            this.lbl_Best1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Best1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Best1.Location = new System.Drawing.Point(244, 102);
            this.lbl_Best1.Name = "lbl_Best1";
            this.lbl_Best1.Size = new System.Drawing.Size(51, 20);
            this.lbl_Best1.TabIndex = 20;
            this.lbl_Best1.Text = "Best:";
            this.lbl_Best1.Visible = false;
            // 
            // lbl_Best
            // 
            this.lbl_Best.AutoSize = true;
            this.lbl_Best.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Best.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Best.Location = new System.Drawing.Point(300, 103);
            this.lbl_Best.Name = "lbl_Best";
            this.lbl_Best.Size = new System.Drawing.Size(61, 18);
            this.lbl_Best.TabIndex = 21;
            this.lbl_Best.Text = "Puntos";
            this.lbl_Best.Visible = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Location = new System.Drawing.Point(10, 224);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(286, 82);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // gbx_MenuPrincipal
            // 
            this.gbx_MenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.gbx_MenuPrincipal.Controls.Add(this.btn_Salir);
            this.gbx_MenuPrincipal.Controls.Add(this.btn_ModoNormal);
            this.gbx_MenuPrincipal.Controls.Add(this.btn_ModoAgresivo);
            this.gbx_MenuPrincipal.Location = new System.Drawing.Point(27, 135);
            this.gbx_MenuPrincipal.Name = "gbx_MenuPrincipal";
            this.gbx_MenuPrincipal.Size = new System.Drawing.Size(307, 321);
            this.gbx_MenuPrincipal.TabIndex = 23;
            this.gbx_MenuPrincipal.TabStop = false;
            // 
            // frm_Twelve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(361, 515);
            this.Controls.Add(this.gbx_MenuPrincipal);
            this.Controls.Add(this.lbl_Best);
            this.Controls.Add(this.lbl_Best1);
            this.Controls.Add(this.lbl_Puntuacion1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_Puntuacion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbox_Personalizar);
            this.Controls.Add(this.pbx_Tablero);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 554);
            this.MinimumSize = new System.Drawing.Size(377, 554);
            this.Name = "frm_Twelve";
            this.Text = "Twelve";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Tablero)).EndInit();
            this.gbox_Personalizar.ResumeLayout(false);
            this.gbox_Personalizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Columnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Filas)).EndInit();
            this.gbx_MenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ModoAgresivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Puntuacion;
        private System.Windows.Forms.PictureBox pbx_Tablero;
        private System.Windows.Forms.ToolStripMenuItem juegoNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúPrincipalToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbox_Personalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Columnas;
        private System.Windows.Forms.NumericUpDown nud_Filas;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_Puntuacion1;
        private System.Windows.Forms.ToolStripMenuItem ffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarTableroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonidoToolStripMenuItem;
        private System.Windows.Forms.Button btn_ModoNormal;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Best1;
        private System.Windows.Forms.Label lbl_Best;
        private System.Windows.Forms.ToolStripMenuItem guardarPartidaToolStripMenuItem;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox gbx_MenuPrincipal;
    }
}

