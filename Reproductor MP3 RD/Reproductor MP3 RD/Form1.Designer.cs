namespace Reproductor_MP3_RD
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.bttAgregarCancion = new System.Windows.Forms.PictureBox();
            this.bttAgregarLista = new System.Windows.Forms.PictureBox();
            this.bttAleatorio = new System.Windows.Forms.PictureBox();
            this.bttAdelante = new System.Windows.Forms.PictureBox();
            this.bttAtras = new System.Windows.Forms.PictureBox();
            this.bttStop = new System.Windows.Forms.PictureBox();
            this.bttPlay = new System.Windows.Forms.PictureBox();
            this.Reproductormp3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listCanciones = new System.Windows.Forms.ListBox();
            this.mtrackPosicion = new XComponent.SliderBar.MACTrackBar();
            this.mtrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lblCancion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUbicacionArchivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAgregarCancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAgregarLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAdelante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductormp3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Reproductor_MP3_RD.Properties.Resources.volumen;
            this.pictureBox6.Location = new System.Drawing.Point(302, 310);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // bttAgregarCancion
            // 
            this.bttAgregarCancion.Image = global::Reproductor_MP3_RD.Properties.Resources.musica;
            this.bttAgregarCancion.Location = new System.Drawing.Point(740, 12);
            this.bttAgregarCancion.Name = "bttAgregarCancion";
            this.bttAgregarCancion.Size = new System.Drawing.Size(47, 42);
            this.bttAgregarCancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttAgregarCancion.TabIndex = 12;
            this.bttAgregarCancion.TabStop = false;
            this.bttAgregarCancion.Click += new System.EventHandler(this.bttAgregarCancion_Click);
            // 
            // bttAgregarLista
            // 
            this.bttAgregarLista.Image = global::Reproductor_MP3_RD.Properties.Resources.lista_de_reproduccion;
            this.bttAgregarLista.Location = new System.Drawing.Point(793, 12);
            this.bttAgregarLista.Name = "bttAgregarLista";
            this.bttAgregarLista.Size = new System.Drawing.Size(39, 42);
            this.bttAgregarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttAgregarLista.TabIndex = 11;
            this.bttAgregarLista.TabStop = false;
            // 
            // bttAleatorio
            // 
            this.bttAleatorio.Image = global::Reproductor_MP3_RD.Properties.Resources.barajar;
            this.bttAleatorio.Location = new System.Drawing.Point(244, 291);
            this.bttAleatorio.Name = "bttAleatorio";
            this.bttAleatorio.Size = new System.Drawing.Size(52, 49);
            this.bttAleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttAleatorio.TabIndex = 10;
            this.bttAleatorio.TabStop = false;
            // 
            // bttAdelante
            // 
            this.bttAdelante.Image = global::Reproductor_MP3_RD.Properties.Resources.proximo;
            this.bttAdelante.Location = new System.Drawing.Point(186, 291);
            this.bttAdelante.Name = "bttAdelante";
            this.bttAdelante.Size = new System.Drawing.Size(52, 49);
            this.bttAdelante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttAdelante.TabIndex = 4;
            this.bttAdelante.TabStop = false;
            // 
            // bttAtras
            // 
            this.bttAtras.Image = global::Reproductor_MP3_RD.Properties.Resources.espalda;
            this.bttAtras.Location = new System.Drawing.Point(128, 291);
            this.bttAtras.Name = "bttAtras";
            this.bttAtras.Size = new System.Drawing.Size(52, 49);
            this.bttAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttAtras.TabIndex = 3;
            this.bttAtras.TabStop = false;
            // 
            // bttStop
            // 
            this.bttStop.Image = global::Reproductor_MP3_RD.Properties.Resources.detener;
            this.bttStop.Location = new System.Drawing.Point(70, 291);
            this.bttStop.Name = "bttStop";
            this.bttStop.Size = new System.Drawing.Size(52, 49);
            this.bttStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttStop.TabIndex = 1;
            this.bttStop.TabStop = false;
            this.bttStop.Click += new System.EventHandler(this.bttStop_Click);
            // 
            // bttPlay
            // 
            this.bttPlay.Image = global::Reproductor_MP3_RD.Properties.Resources.boton_de_reproduccion;
            this.bttPlay.Location = new System.Drawing.Point(12, 291);
            this.bttPlay.Name = "bttPlay";
            this.bttPlay.Size = new System.Drawing.Size(52, 49);
            this.bttPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttPlay.TabIndex = 0;
            this.bttPlay.TabStop = false;
            this.bttPlay.Click += new System.EventHandler(this.bttPlay_Click);
            // 
            // Reproductormp3
            // 
            this.Reproductormp3.Enabled = true;
            this.Reproductormp3.Location = new System.Drawing.Point(12, 12);
            this.Reproductormp3.Name = "Reproductormp3";
            this.Reproductormp3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductormp3.OcxState")));
            this.Reproductormp3.Size = new System.Drawing.Size(379, 222);
            this.Reproductormp3.TabIndex = 14;
            this.Reproductormp3.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductormp3_PlayStateChange);
            // 
            // listCanciones
            // 
            this.listCanciones.FormattingEnabled = true;
            this.listCanciones.Location = new System.Drawing.Point(441, 167);
            this.listCanciones.Name = "listCanciones";
            this.listCanciones.Size = new System.Drawing.Size(391, 173);
            this.listCanciones.TabIndex = 15;
            this.listCanciones.SelectedIndexChanged += new System.EventHandler(this.listCanciones_SelectedIndexChanged);
            // 
            // mtrackPosicion
            // 
            this.mtrackPosicion.BackColor = System.Drawing.Color.Transparent;
            this.mtrackPosicion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackPosicion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackPosicion.ForeColor = System.Drawing.Color.Gray;
            this.mtrackPosicion.IndentHeight = 6;
            this.mtrackPosicion.Location = new System.Drawing.Point(12, 240);
            this.mtrackPosicion.Maximum = 100;
            this.mtrackPosicion.Minimum = 0;
            this.mtrackPosicion.Name = "mtrackPosicion";
            this.mtrackPosicion.Size = new System.Drawing.Size(379, 25);
            this.mtrackPosicion.TabIndex = 16;
            this.mtrackPosicion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackPosicion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mtrackPosicion.TickHeight = 4;
            this.mtrackPosicion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackPosicion.TrackerColor = System.Drawing.Color.Blue;
            this.mtrackPosicion.TrackerSize = new System.Drawing.Size(10, 13);
            this.mtrackPosicion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackPosicion.TrackLineHeight = 3;
            this.mtrackPosicion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mtrackPosicion.Value = 0;
            // 
            // mtrackVolumen
            // 
            this.mtrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mtrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackVolumen.IndentHeight = 6;
            this.mtrackVolumen.Location = new System.Drawing.Point(339, 318);
            this.mtrackVolumen.Maximum = 100;
            this.mtrackVolumen.Minimum = 0;
            this.mtrackVolumen.Name = "mtrackVolumen";
            this.mtrackVolumen.Size = new System.Drawing.Size(75, 22);
            this.mtrackVolumen.TabIndex = 17;
            this.mtrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mtrackVolumen.TickHeight = 4;
            this.mtrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TrackerColor = System.Drawing.Color.Blue;
            this.mtrackVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtrackVolumen.TrackLineColor = System.Drawing.Color.Gray;
            this.mtrackVolumen.TrackLineHeight = 3;
            this.mtrackVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mtrackVolumen.Value = 0;
            this.mtrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtrackVolumen_ValueChanged);
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Location = new System.Drawing.Point(397, 62);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(13, 13);
            this.lblCancion.TabIndex = 18;
            this.lblCancion.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUbicacionArchivo
            // 
            this.lblUbicacionArchivo.AutoSize = true;
            this.lblUbicacionArchivo.Location = new System.Drawing.Point(397, 91);
            this.lblUbicacionArchivo.Name = "lblUbicacionArchivo";
            this.lblUbicacionArchivo.Size = new System.Drawing.Size(13, 13);
            this.lblUbicacionArchivo.TabIndex = 19;
            this.lblUbicacionArchivo.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(844, 352);
            this.Controls.Add(this.lblUbicacionArchivo);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.mtrackVolumen);
            this.Controls.Add(this.mtrackPosicion);
            this.Controls.Add(this.listCanciones);
            this.Controls.Add(this.Reproductormp3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.bttAgregarCancion);
            this.Controls.Add(this.bttAgregarLista);
            this.Controls.Add(this.bttAleatorio);
            this.Controls.Add(this.bttAdelante);
            this.Controls.Add(this.bttAtras);
            this.Controls.Add(this.bttStop);
            this.Controls.Add(this.bttPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reproductor MP3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAgregarCancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAgregarLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAdelante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductormp3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bttPlay;
        private System.Windows.Forms.PictureBox bttStop;
        private System.Windows.Forms.PictureBox bttAtras;
        private System.Windows.Forms.PictureBox bttAdelante;
        private System.Windows.Forms.PictureBox bttAleatorio;
        private System.Windows.Forms.PictureBox bttAgregarLista;
        private System.Windows.Forms.PictureBox bttAgregarCancion;
        private System.Windows.Forms.PictureBox pictureBox6;
        private AxWMPLib.AxWindowsMediaPlayer Reproductormp3;
        private System.Windows.Forms.ListBox listCanciones;
        private XComponent.SliderBar.MACTrackBar mtrackPosicion;
        private XComponent.SliderBar.MACTrackBar mtrackVolumen;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUbicacionArchivo;
    }
}

