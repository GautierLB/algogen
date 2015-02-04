using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAlgoGen
{
    class Population
    {
        private Individu[] individus;
        private Individu[] nouveauxIndividus;
        private int tauxMutation;
        private int crossOver;
        private int nbGenerations;

        /* TODO PREMIERE GENERATION */

        public Population()
        {
            this.tauxMutation = 10;
            this.crossOver = 60;
            this.nbGenerations = 1;
            this.createPopulation();

        }

        private void createPopulation()
        {
            for (int i = 0; i < 10; i++)
            {
                this.individus[i] = new Individu();
            }
        }


        /* TODO SELECTION */

        public void Selection()
        {
            Individu[] temp = new Individu[6];
            for (int i = 0; i < 6; i++)
            {
                int noteMax = 0;
                for (int j = 0; j < 10; j++)
                {
                    this.individus[j].getNotation();
                }
            }
        }

        /* TODO SURVIE*/

        public void Survie()
        {
            for (int i = 0; i < 10; i++)
            {
                if (this.individus[i].getNotation() < this.nouveauxIndividus[i].getNotation())
                {
                    this.individus[i] = this.nouveauxIndividus[i];
                }
            }

        }

        /* TODO NOMBRE GENERATIONS */

        public void nouvelleGeneration()
        {
            this.nbGenerations++;
            this.Selection();
            this.Survie();
        }
    
    }
}
