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



namespace TPAlgoGen
{
    public partial class MainWindow : Form
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string numeroGeneration;
        private Individu i1;

        public MainWindow()
        {
            numeroGeneration = "1";
            i1 = new Individu();
            InitializeComponent();
            lb_numGen.Text = numeroGeneration;
            
        }

        private void nextGen_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(numeroGeneration);
            temp++;
            numeroGeneration = temp.ToString();
            lb_numGen.Text = numeroGeneration;


            MediaPlayer mplayer;
            Boolean isPlaying;
            string strFileName;
            int nbFile = 0;

            MIDISong song = new MIDISong();
            song.AddTrack("Piste1");
            song.SetTimeSignature(0, 4, 4);
            song.SetTempo(0, 150);
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
            // et on écrit le fichier
            strFileName = "Fichier" + nbFile + ".mid";
            FileStream objWriter = File.Create(strFileName);
            objWriter.Write(dst, 0, dst.Length);
            objWriter.Close();
            objWriter.Dispose();
            objWriter = null;

            // créer fichier MIDI   a partir de l'individu
            //enregistrer le fichier




            // TODO Vérifier que tous les individus ont une notes

            // TODO lancer la génération suivante
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }


        public string GetNumeroGeneration()
        {
            return numeroGeneration;
        }

        public string SetNumeroGeneration(String value)
        {
            numeroGeneration = value;
            OnPropertyChanged(numeroGeneration);
            return numeroGeneration;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     


    }
}
