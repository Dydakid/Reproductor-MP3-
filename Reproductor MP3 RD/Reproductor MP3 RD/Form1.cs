using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_MP3_RD
{
    public partial class Form1 : Form
    {
        List<Reproduciruna> ListResproduciruna = new List<Reproduciruna>();

        //Variable global de clase Reproduciruna
        Reproduciruna CapturadeArchivo = new Reproduciruna();

        public Form1()
        {
            InitializeComponent();
        }

        private void bttAgregarCancion_Click(object sender, EventArgs e)
        {
            OpenFileDialog BusquedaDeArchivos = new OpenFileDialog();
            BusquedaDeArchivos.Multiselect = true;
            if (BusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CapturadeArchivo.Archivmp3 = BusquedaDeArchivos.SafeFileNames;
                CapturadeArchivo.Rutaarchivmp3 = BusquedaDeArchivos.FileNames;
                foreach (var Archivomp3 in CapturadeArchivo.Archivmp3)
                {
                    listCanciones.Items.Add(Archivomp3);
                }
                Reproductormp3.URL = CapturadeArchivo.Rutaarchivmp3[0];
                listCanciones.SelectedIndex = 0;
                bttPlay.Image = Properties.Resources.pausa;
            }
        }

        private void listCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductormp3.URL = CapturadeArchivo.Rutaarchivmp3[listCanciones.SelectedIndex];
            lblCancion.Text = CapturadeArchivo.Archivmp3[listCanciones.SelectedIndex];
            lblUbicacionArchivo.Text = CapturadeArchivo.Rutaarchivmp3[listCanciones.SelectedIndex];
        }

        private void bttPlay_Click(object sender, EventArgs e)
        {
            switch(CapturadeArchivo.Play)
            {
                case true:
                    Reproductormp3.Ctlcontrols.pause();
                    bttPlay.Image = Properties.Resources.boton_de_reproduccion;
                    CapturadeArchivo.Play = false;
                    break;
                case false:
                    Reproductormp3.Ctlcontrols.play();
                    bttPlay.Image = Properties.Resources.pausa;
                    CapturadeArchivo.Play = true;
                    break;
            }
        }

        private void bttStop_Click(object sender, EventArgs e)
        {
            Reproductormp3.Ctlcontrols.stop();
            bttPlay.Image = Properties.Resources.boton_de_reproduccion;
            CapturadeArchivo.Play = false;
        }

        public void RefrescarDatos()
        {
            if (Reproductormp3.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Control del tiempo de la cancion en el mactrack
                mtrackPosicion.Maximum = (int) Reproductormp3.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else
                if(Reproductormp3.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else
                if (Reproductormp3.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mtrackPosicion.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefrescarDatos();
            mtrackPosicion.Value = (int)Reproductormp3.Ctlcontrols.currentPosition;
            mtrackVolumen.Value = Reproductormp3.settings.volume;
        }

        private void Reproductormp3_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            RefrescarDatos();
        }

        private void mtrackVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductormp3.settings.volume = mtrackVolumen.Value;
        }
    }
}
