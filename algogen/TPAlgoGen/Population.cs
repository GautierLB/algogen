﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAlgoGen
{
    class Population
    {
        private Individu[] individus = new Individu[10];
        private static int tauxMutation = 60 ;
        private static int crossOver = 60;
        private int nbGenerations;


        public Population()
        {
            this.nbGenerations = 1;
            this.createPopulation();
        }

        private void createPopulation()
        {
            for (int boucle = 0; boucle < 10; boucle++)
            {
                 //sleep for the random in the creation
                System.Threading.Thread.Sleep(20);
                this.individus[boucle] = new Individu();
  
            }
        }


        /* TODO SELECTION */

        public void Classement()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (this.individus[j + 1].getNotation() < this.individus[j].getNotation())
                    {
                        Individu t = this.individus[j + 1];
                        this.individus[j + 1] = this.individus[j];
                        this.individus[j] = t;
                    }
                }
            }
        }

        public Individu[] Selection()
        {
            Individu[] newPop = new Individu[10];
           
            for (int k = 0; k < 10; k++)
            {
                System.Threading.Thread.Sleep(20);
                Random rand = new Random();
                Individu parent = this.findParent();
                if (rand.Next(1, 100) <= Population.crossOver)
                {
                    Individu parent2 = this.findParent();
                    newPop[k] = new Individu(parent, parent2);
                }
                else
                {
                    newPop[k] = new Individu(parent, null);
                }
            }
            this.individus = newPop;
            return this.individus;
        }
       

        private Individu findParent()
        {
            Random rand = new Random();
            int random = rand.Next(1, 55);
            Individu parent = null;
            if (random > 0 && random <= 11)
            {
                parent = this.individus[0];
            }
            else if (random > 11 && random <= 20)
            {
                parent = this.individus[1];
            }
            else if (random > 20 && random <= 28)
            {
                parent = this.individus[2];
            }
            else if (random > 28 && random <= 35)
            {
                parent = this.individus[3];
            }
            else if (random > 35 && random <= 41)
            {
                parent = this.individus[4];
            }
            else if (random > 41 && random <= 46)
            {
                parent = this.individus[5];
            }
            else if (random > 46 && random <= 50)
            {
                parent = this.individus[6];
            }
            else if (random > 50 && random <= 53)
            {
                parent = this.individus[7];
            }
            else if (random > 53 && random <= 55)
            {
                parent = this.individus[8];
            }
            else if (random > 55 && random <= 56)
            {
                parent = this.individus[9];
            }
            return parent;
        }


        public Population nouvelleGeneration()
        {
            this.nbGenerations++;
            this.Selection();
          

            return this;
        }
    
        public Individu[] getIndividus()
        {
            return this.individus;
        }

        public int getNbGenerations()
        {
            return nbGenerations;
        }


        public static int getTauxMutation()
        {
            return Population.tauxMutation;
        }
    }
}
