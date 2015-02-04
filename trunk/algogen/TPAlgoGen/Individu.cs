using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAlgoGen
{
    class Individu
    {
        private int instrument;
        private int[] notes;
        private int notation;

        public Individu()
        {
            Random rand = new Random();
            this.notes = new int[20];
            this.instrument = rand.Next(1, 129);
            for (int i = 0; i < 20; i++)
            {
                int note = rand.Next(24, 96);
                this.notes[i] = note;

            }
        }

        public int getNotation()
        {
            return this.notation;
        }

        public void setNotation(int _notation)
        {
             this.notation = _notation;
        }

        public int[] getNotes()
        {
            return this.notes;
        }

        public int getInstrument() 
        {
            return this.instrument;
        }

    }
}
