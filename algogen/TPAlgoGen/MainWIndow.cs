using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;
using System.Windows.Media;





namespace TPAlgoGen
{
    public partial class MainWindow : Form
    {
        
        private int CurrentlyPlaying;
        private Population CurrentPopulation;



        MediaPlayer mplayer;
        Boolean isPlaying;
        string strFileName;
        int nbFile = 0;

        public MainWindow()
        {
            InitializeComponent();

            // Create the first generation of "people"
            this.CurrentPopulation = new Population();
            lb_numGen.Text =  CurrentPopulation.getNbGenerations().ToString();


            mplayer = new MediaPlayer();
           // mplayer.MediaEnded += mplayer_MediaEnded;
            isPlaying = false;
            
        }

        private void nextGen_Click(object sender, EventArgs e)
        {

            // TODO Vérifier que tous les individus ont une notes

            // TODO lancer la génération suivante
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

   


     

        private void Play_Click(object sender, EventArgs e)
        {

            if (isPlaying == true)
            {
                isPlaying = false;
                mplayer.Stop();
                
            }
            else
            {

                /* Get if from button */
                CurrentlyPlaying = int.Parse((string)((Button)sender).Tag) - 1;

                /* create the song */
                MIDISong song = new MIDISong();
                song.AddTrack("Piste" + CurrentlyPlaying);
                song.SetTimeSignature(0, 4, 4);
                song.SetTempo(0, 150);

                System.Console.Write(CurrentlyPlaying);

                /* get the note + instrumental from the individu*/
                Individu[] ind = this.CurrentPopulation.getIndividus();

                int[] notes = ind[CurrentlyPlaying].getNotes();
                int instru = ind[CurrentlyPlaying].getInstrument();

                for (int a = 0; a < 20; a++)
                {
                    System.Console.WriteLine("");
                    System.Console.Write(notes[a]);
                    song.AddNote(0, 0, notes[a], 12);
                }
                song.SetChannelInstrument(0, 0, instru);


                /* save it */
                MemoryStream ms = new MemoryStream();
                song.Save(ms);
                ms.Seek(0, SeekOrigin.Begin);
                byte[] src = ms.GetBuffer();
                byte[] dst = new byte[src.Length];
                for (int i = 0; i < src.Length; i++)
                {
                    dst[i] = src[i];
                }
                ms.Close();


                /* Create file */
                strFileName = "Fichier" + CurrentlyPlaying + ".mid";
                FileStream objWriter = File.Create(strFileName);
                objWriter.Write(dst, 0, dst.Length);
                objWriter.Close();
                objWriter.Dispose();
                objWriter = null;


                /* Play the song*/
                mplayer.Open(new Uri(strFileName, UriKind.Relative));
                nbFile++;
                isPlaying = true;
                mplayer.Play();
            }
        }


   

    }
}
