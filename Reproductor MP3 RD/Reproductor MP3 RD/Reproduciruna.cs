using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_MP3_RD
{
    class Reproduciruna
    {
        bool play = false;
        string[] archivmp3;
        string[] rutaarchivmp3;

        public bool Play
        {
            get
            {
                return play;
            }

            set
            {
                play = value;
            }
        }

        public string[] Archivmp3
        {
            get
            {
                return archivmp3;
            }

            set
            {
                archivmp3 = value;
            }
        }

        public string[] Rutaarchivmp3
        {
            get
            {
                return rutaarchivmp3;
            }

            set
            {
                rutaarchivmp3 = value;
            }
        }
    }
}
