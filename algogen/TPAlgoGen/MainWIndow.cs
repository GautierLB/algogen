﻿using System;
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
        private string numeroGeneration;
        private int CurrentlyPlaying;

        private Individu[] individus =  new Individu[10];


        MediaPlayer mplayer;
        Boolean isPlaying;
        string strFileName;
        int nbFile = 0;

        public MainWindow()
        {
           

            // Création de la 1ere génération d'individu
            numeroGeneration = "1";
            for (int i = 0; i < 10;i++ )
            {
                individus[i] = new Individu();
            }

            InitializeComponent();
            lb_numGen.Text = numeroGeneration;


            mplayer = new MediaPlayer();
           // mplayer.MediaEnded += mplayer_MediaEnded;
            isPlaying = false;
            
        }

        private void nextGen_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(numeroGeneration);
            temp++;
            numeroGeneration = temp.ToString();
            lb_numGen.Text = numeroGeneration;


           
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

            mplayer.Open(new Uri(strFileName, UriKind.Relative));
            nbFile++;
            isPlaying = true;
            mplayer.Play();

            // créer fichier MIDI   a partir de l'individu
            //enregistrer le fichier




            // TODO Vérifier que tous les individus ont une notes

            // TODO lancer la génération suivante
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

   

        public string GetNumeroGeneration()
        {
            return numeroGeneration;
        }

        public MainWindow SetNumeroGeneration(String value)
        {
            numeroGeneration = value;
            return this;
        }

     
/*Quand On click sur un bouton Play, on récupère son numéro qui servirons d'identifiant */
        private void Play_Click(object sender, EventArgs e)
        {

            if (isPlaying == true)
            {
                isPlaying = false;
                mplayer.Stop();
                
            }
            else
            {

                /* GET ID BUTTON */
                CurrentlyPlaying = int.Parse((string)((Button)sender).Tag) - 1;


                MIDISong song = new MIDISong();
                song.AddTrack("Piste" + CurrentlyPlaying);
                song.SetTimeSignature(0, 4, 4);
                song.SetTempo(0, 150);


                int[] notes = individus[CurrentlyPlaying].getNotes();
                int instru = individus[CurrentlyPlaying].getInstrument();

                for (int a = 0; a < 20; a++)
                {
                    song.AddNote(0, 0, notes[a], 12);
                }
                song.SetChannelInstrument(0, 0, instru);

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

                mplayer.Open(new Uri(strFileName, UriKind.Relative));
                nbFile++;
                isPlaying = true;
                mplayer.Play();
            }
        }


   

    }
}