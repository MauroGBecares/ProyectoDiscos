using System;

namespace ProyectoConConexionDB
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxEstilo = new System.Windows.Forms.ComboBox();
            this.lblGustoMusical = new System.Windows.Forms.Label();
            this.lblRecitales = new System.Windows.Forms.Label();
            this.cbxRecital = new System.Windows.Forms.CheckBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInstrumentos = new System.Windows.Forms.Label();
            this.rdbNinguno = new System.Windows.Forms.RadioButton();
            this.rdbGuitarra = new System.Windows.Forms.RadioButton();
            this.rdbPiano = new System.Windows.Forms.RadioButton();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.rdbBateria = new System.Windows.Forms.RadioButton();
            this.lblBandaFavorita = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.nupCantidadDiscos = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadDiscos = new System.Windows.Forms.Label();
            this.btnMostrarResultado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rdbOtros = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(56, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(179, 33);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(241, 113);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(331, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // cbxEstilo
            // 
            this.cbxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstilo.FormattingEnabled = true;
            this.cbxEstilo.Location = new System.Drawing.Point(241, 185);
            this.cbxEstilo.Name = "cbxEstilo";
            this.cbxEstilo.Size = new System.Drawing.Size(331, 21);
            this.cbxEstilo.TabIndex = 2;
            // 
            // lblGustoMusical
            // 
            this.lblGustoMusical.BackColor = System.Drawing.Color.Transparent;
            this.lblGustoMusical.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGustoMusical.ForeColor = System.Drawing.Color.White;
            this.lblGustoMusical.Location = new System.Drawing.Point(7, 185);
            this.lblGustoMusical.Name = "lblGustoMusical";
            this.lblGustoMusical.Size = new System.Drawing.Size(223, 35);
            this.lblGustoMusical.TabIndex = 5;
            this.lblGustoMusical.Text = "Estilo musical Favorito?";
            // 
            // lblRecitales
            // 
            this.lblRecitales.BackColor = System.Drawing.Color.Transparent;
            this.lblRecitales.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecitales.ForeColor = System.Drawing.Color.White;
            this.lblRecitales.Location = new System.Drawing.Point(32, 224);
            this.lblRecitales.Name = "lblRecitales";
            this.lblRecitales.Size = new System.Drawing.Size(203, 29);
            this.lblRecitales.TabIndex = 6;
            this.lblRecitales.Text = "Estuvo en algun recital?";
            // 
            // cbxRecital
            // 
            this.cbxRecital.AutoSize = true;
            this.cbxRecital.Location = new System.Drawing.Point(241, 232);
            this.cbxRecital.Name = "cbxRecital";
            this.cbxRecital.Size = new System.Drawing.Size(15, 14);
            this.cbxRecital.TabIndex = 3;
            this.cbxRecital.UseVisualStyleBackColor = true;
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Impact", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.White;
            this.lblDatos.Location = new System.Drawing.Point(192, 74);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(107, 33);
            this.lblDatos.TabIndex = 8;
            this.lblDatos.Text = "Datos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // discosToolStripMenuItem
            // 
            this.discosToolStripMenuItem.Name = "discosToolStripMenuItem";
            this.discosToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.discosToolStripMenuItem.Text = "Discos";
            this.discosToolStripMenuItem.Click += new System.EventHandler(this.discosToolStripMenuItem_Click);
            // 
            // lblInstrumentos
            // 
            this.lblInstrumentos.BackColor = System.Drawing.Color.Transparent;
            this.lblInstrumentos.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumentos.ForeColor = System.Drawing.Color.White;
            this.lblInstrumentos.Location = new System.Drawing.Point(32, 262);
            this.lblInstrumentos.Name = "lblInstrumentos";
            this.lblInstrumentos.Size = new System.Drawing.Size(203, 29);
            this.lblInstrumentos.TabIndex = 10;
            this.lblInstrumentos.Text = "Que instrumento toca?";
            // 
            // rdbNinguno
            // 
            this.rdbNinguno.AutoSize = true;
            this.rdbNinguno.BackColor = System.Drawing.Color.Transparent;
            this.rdbNinguno.Checked = true;
            this.rdbNinguno.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNinguno.ForeColor = System.Drawing.Color.White;
            this.rdbNinguno.Location = new System.Drawing.Point(241, 264);
            this.rdbNinguno.Name = "rdbNinguno";
            this.rdbNinguno.Size = new System.Drawing.Size(73, 22);
            this.rdbNinguno.TabIndex = 4;
            this.rdbNinguno.TabStop = true;
            this.rdbNinguno.Text = "Ninguno";
            this.rdbNinguno.UseVisualStyleBackColor = false;
            // 
            // rdbGuitarra
            // 
            this.rdbGuitarra.AutoSize = true;
            this.rdbGuitarra.BackColor = System.Drawing.Color.Transparent;
            this.rdbGuitarra.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGuitarra.ForeColor = System.Drawing.Color.White;
            this.rdbGuitarra.Location = new System.Drawing.Point(241, 292);
            this.rdbGuitarra.Name = "rdbGuitarra";
            this.rdbGuitarra.Size = new System.Drawing.Size(73, 22);
            this.rdbGuitarra.TabIndex = 5;
            this.rdbGuitarra.Text = "Guitarra";
            this.rdbGuitarra.UseVisualStyleBackColor = false;
            // 
            // rdbPiano
            // 
            this.rdbPiano.AutoSize = true;
            this.rdbPiano.BackColor = System.Drawing.Color.Transparent;
            this.rdbPiano.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPiano.ForeColor = System.Drawing.Color.White;
            this.rdbPiano.Location = new System.Drawing.Point(241, 347);
            this.rdbPiano.Name = "rdbPiano";
            this.rdbPiano.Size = new System.Drawing.Size(58, 22);
            this.rdbPiano.TabIndex = 7;
            this.rdbPiano.Text = "Piano";
            this.rdbPiano.UseVisualStyleBackColor = false;
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(304, 375);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(268, 20);
            this.txtOtros.TabIndex = 8;
            this.txtOtros.TextChanged += new System.EventHandler(this.txtOtros_TextChanged);
            // 
            // rdbBateria
            // 
            this.rdbBateria.AutoSize = true;
            this.rdbBateria.BackColor = System.Drawing.Color.Transparent;
            this.rdbBateria.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBateria.ForeColor = System.Drawing.Color.White;
            this.rdbBateria.Location = new System.Drawing.Point(241, 320);
            this.rdbBateria.Name = "rdbBateria";
            this.rdbBateria.Size = new System.Drawing.Size(68, 22);
            this.rdbBateria.TabIndex = 6;
            this.rdbBateria.Text = "Bateria";
            this.rdbBateria.UseVisualStyleBackColor = false;
            // 
            // lblBandaFavorita
            // 
            this.lblBandaFavorita.BackColor = System.Drawing.Color.Transparent;
            this.lblBandaFavorita.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandaFavorita.ForeColor = System.Drawing.Color.White;
            this.lblBandaFavorita.Location = new System.Drawing.Point(23, 412);
            this.lblBandaFavorita.Name = "lblBandaFavorita";
            this.lblBandaFavorita.Size = new System.Drawing.Size(203, 29);
            this.lblBandaFavorita.TabIndex = 17;
            this.lblBandaFavorita.Text = "Banda/Artista Favorito:";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(241, 414);
            this.txtArtista.MaxLength = 40;
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(331, 20);
            this.txtArtista.TabIndex = 9;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(31, 140);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(199, 35);
            this.lblFechaNacimiento.TabIndex = 1;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(241, 145);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(331, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1119, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslFechaHora
            // 
            this.tsslFechaHora.BackColor = System.Drawing.Color.Transparent;
            this.tsslFechaHora.Name = "tsslFechaHora";
            this.tsslFechaHora.Size = new System.Drawing.Size(98, 17);
            this.tsslFechaHora.Text = "5/2/2023 22:33:43";
            // 
            // nupCantidadDiscos
            // 
            this.nupCantidadDiscos.Location = new System.Drawing.Point(480, 447);
            this.nupCantidadDiscos.Name = "nupCantidadDiscos";
            this.nupCantidadDiscos.Size = new System.Drawing.Size(53, 20);
            this.nupCantidadDiscos.TabIndex = 10;
            // 
            // lblCantidadDiscos
            // 
            this.lblCantidadDiscos.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadDiscos.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDiscos.ForeColor = System.Drawing.Color.White;
            this.lblCantidadDiscos.Location = new System.Drawing.Point(4, 444);
            this.lblCantidadDiscos.Name = "lblCantidadDiscos";
            this.lblCantidadDiscos.Size = new System.Drawing.Size(470, 29);
            this.lblCantidadDiscos.TabIndex = 22;
            this.lblCantidadDiscos.Text = "Cantidad de discos que tiene de su Banda/Artista Favorito:";
            // 
            // btnMostrarResultado
            // 
            this.btnMostrarResultado.Image = global::ProyectoConConexionDB.Properties.Resources.baseline_play_circle_black_24dp;
            this.btnMostrarResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarResultado.Location = new System.Drawing.Point(189, 496);
            this.btnMostrarResultado.Name = "btnMostrarResultado";
            this.btnMostrarResultado.Size = new System.Drawing.Size(125, 42);
            this.btnMostrarResultado.TabIndex = 11;
            this.btnMostrarResultado.Text = "Mostrar Resultado";
            this.btnMostrarResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarResultado.UseVisualStyleBackColor = true;
            this.btnMostrarResultado.Click += new System.EventHandler(this.btnMostrarResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Impact", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(787, 74);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(107, 33);
            this.lblResultado.TabIndex = 24;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(578, 115);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(527, 423);
            this.txtResultado.TabIndex = 12;
            // 
            // rdbOtros
            // 
            this.rdbOtros.AutoSize = true;
            this.rdbOtros.BackColor = System.Drawing.Color.Transparent;
            this.rdbOtros.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOtros.ForeColor = System.Drawing.Color.White;
            this.rdbOtros.Location = new System.Drawing.Point(241, 375);
            this.rdbOtros.Name = "rdbOtros";
            this.rdbOtros.Size = new System.Drawing.Size(60, 22);
            this.rdbOtros.TabIndex = 26;
            this.rdbOtros.Text = "Otros:";
            this.rdbOtros.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::ProyectoConConexionDB.Properties.Resources.HD_wallpaper__Music__1920x1080__sound__note__photos_of_musical_notes__pictures_musical_notes1;
            this.ClientSize = new System.Drawing.Size(1119, 570);
            this.Controls.Add(this.rdbOtros);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMostrarResultado);
            this.Controls.Add(this.lblCantidadDiscos);
            this.Controls.Add(this.nupCantidadDiscos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.lblBandaFavorita);
            this.Controls.Add(this.rdbBateria);
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.rdbPiano);
            this.Controls.Add(this.rdbGuitarra);
            this.Controls.Add(this.rdbNinguno);
            this.Controls.Add(this.lblInstrumentos);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.cbxRecital);
            this.Controls.Add(this.lblRecitales);
            this.Controls.Add(this.lblGustoMusical);
            this.Controls.Add(this.cbxEstilo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil Musical";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxEstilo;
        private System.Windows.Forms.Label lblGustoMusical;
        private System.Windows.Forms.Label lblRecitales;
        private System.Windows.Forms.CheckBox cbxRecital;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discosToolStripMenuItem;
        private System.Windows.Forms.Label lblInstrumentos;
        private System.Windows.Forms.RadioButton rdbNinguno;
        private System.Windows.Forms.RadioButton rdbGuitarra;
        private System.Windows.Forms.RadioButton rdbPiano;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.RadioButton rdbBateria;
        private System.Windows.Forms.Label lblBandaFavorita;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslFechaHora;
        private System.Windows.Forms.NumericUpDown nupCantidadDiscos;
        private System.Windows.Forms.Label lblCantidadDiscos;
        private System.Windows.Forms.Button btnMostrarResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rdbOtros;
    }
}

