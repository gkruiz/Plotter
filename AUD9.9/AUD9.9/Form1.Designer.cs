namespace AUD9._9
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDiseoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erroresLexicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cubo3d1 = new AUD9._9.cubo3d();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.planta1 = new AUD9._9.planta();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.elevacion1 = new AUD9._9.elevacion();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.perfil1 = new AUD9._9.perfil();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ejecutarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compilarToolStripMenuItem,
            this.mostrarDiseoToolStripMenuItem,
            this.erroresLexicosToolStripMenuItem,
            this.tokensToolStripMenuItem});
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            // 
            // compilarToolStripMenuItem
            // 
            this.compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            this.compilarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.compilarToolStripMenuItem.Text = "Compilar";
            this.compilarToolStripMenuItem.Click += new System.EventHandler(this.compilarToolStripMenuItem_Click);
            // 
            // mostrarDiseoToolStripMenuItem
            // 
            this.mostrarDiseoToolStripMenuItem.Name = "mostrarDiseoToolStripMenuItem";
            this.mostrarDiseoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.mostrarDiseoToolStripMenuItem.Text = "Mostrar Dise;o";
            // 
            // erroresLexicosToolStripMenuItem
            // 
            this.erroresLexicosToolStripMenuItem.Name = "erroresLexicosToolStripMenuItem";
            this.erroresLexicosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.erroresLexicosToolStripMenuItem.Text = "Errores Lexicos";
            // 
            // tokensToolStripMenuItem
            // 
            this.tokensToolStripMenuItem.Name = "tokensToolStripMenuItem";
            this.tokensToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tokensToolStripMenuItem.Text = "Tokens";
            this.tokensToolStripMenuItem.Click += new System.EventHandler(this.tokensToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem,
            this.manualTecnicoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // manualTecnicoToolStripMenuItem
            // 
            this.manualTecnicoToolStripMenuItem.Name = "manualTecnicoToolStripMenuItem";
            this.manualTecnicoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualTecnicoToolStripMenuItem.Text = "Manual Tecnico";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 595);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(501, 547);
            this.textBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(519, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 595);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.elementHost1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modelo 3D";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(-1, 1);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(719, 572);
            this.elementHost1.TabIndex = 3;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cubo3d1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.elementHost2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Planta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(1, 2);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(720, 560);
            this.elementHost2.TabIndex = 1;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost2_ChildChanged);
            this.elementHost2.Child = this.planta1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.elementHost3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(724, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Elevacion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(4, 4);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(717, 559);
            this.elementHost3.TabIndex = 0;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.elevacion1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.elementHost4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(724, 569);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Perfil";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // elementHost4
            // 
            this.elementHost4.Location = new System.Drawing.Point(0, 7);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(721, 556);
            this.elementHost4.TabIndex = 0;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = this.perfil1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDiseoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erroresLexicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualTecnicoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private cubo3d cubo3d1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private planta planta1;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private elevacion elevacion1;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private perfil perfil1;
    }
}

