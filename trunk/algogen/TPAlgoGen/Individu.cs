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
                Console.WriteLine(note);
                this.notes[i] = note;
            }
        }

        public Individu(Individu parent1,Individu parent2 )
        {
            int[] parent1Notes = parent1.getNotes();
            if (parent2 != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    this.notes[i] = parent1Notes[i];
                }
                int[] parent2Notes = parent2.getNotes();
                for (int j = 10; j < 20; j++)
                {
                    this.notes[j] = parent2Notes[j];
                }
            }
            else
            {
                this.notes = parent1Notes;
            }
            this.instrument = parent1.getInstrument();
            this.Mutation();
        }

        private void Mutation()
        {
            Random rand = new Random();
            for (int i = 0; i < 21; i++)
            {
                if (rand.Next(1, 100) <= Population.getTauxMutation())
                {
                    if (i < 20)
                    {
                        this.notes[i] += rand.Next(1, 10) - 5;
                        if (this.notes[i] > 127)
                        {
                            this.notes[i] -= 127;
                        }
                        else if (this.notes[i] < 0)
                        {
                            this.notes[i] += 127;
                        }
                    }
                    else
                    {
                        this.instrument += rand.Next(1, 10) - 5;
                        if (this.instrument > 128)
                        {
                            this.instrument -= 128;
                        }
                        else if (this.instrument < 1)
                        {
                            this.instrument += 128;
                        }
                    }
                }
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
