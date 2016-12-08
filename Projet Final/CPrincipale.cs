﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class CPrincipale
    {
        Random r;
        public Queue<CCentreTri> QueueCentreTri;
        public CPrincipale()
        {
            r = new Random();
            QueueCentreTri = new Queue<CCentreTri>();
            initialisation();
            déroulement();
        }
        private void initialisation()
        {
            bool verif = true;
            int vaisseau = 0, centre = 0; ;
            while (verif)
            {
                Console.WriteLine("Combien de vaisseaux ? \n1-100 \n2-200 \n3-300 \n4-400 \n5-500");
                switch (Console.ReadLine())
                {
                    case "1":
                        vaisseau = 100;
                        verif = false;
                        break;
                    case "2":
                        vaisseau = 200;
                        verif = false;
                        break;
                    case "3":
                        vaisseau = 300;
                        verif = false;
                        break;
                    case "4":
                        vaisseau = 400;
                        verif = false;
                        break;
                    case "5":
                        vaisseau = 500;
                        verif = false;
                        break;
                    default:
                        Console.WriteLine("Entrée invalide");
                        break;
                }
            }
            verif = true;
            while (verif)
            {
                Console.WriteLine("Combien de Centres de tri ? \n1-10 \n2-20 \n3-30 \n4-40 \n5-50");
                switch (Console.ReadLine())
                {
                    case "1":
                        centre = 10;
                        verif = false;
                        break;
                    case "2":
                        centre = 20;
                        verif = false;
                        break;
                    case "3":
                        centre = 30;
                        verif = false;
                        break;
                    case "4":
                        centre = 40;
                        verif = false;
                        break;
                    case "5":
                        centre = 50;
                        verif = false;
                        break;
                    default:
                        Console.WriteLine("Entrée invalide");
                        break;
                }
            }
            creationcentre(Convert.ToInt32(centre));
            creationVaisseau(Convert.ToInt32(vaisseau));
        }
        private void creationVaisseau(int nbVaisseau)
        {
            int nbCargo = 0, nbLeger = 0;
            nbCargo = r.Next(nbVaisseau);
            nbLeger = nbVaisseau - nbCargo;
            for (int i = 0; i < nbCargo; i++)
            {
                CVaisseauCargo vaisseau = new CVaisseauCargo();
                int restant = vaisseau.CapaciteMax;
                vaisseau.Papier = r.Next(restant); restant -= vaisseau.Papier;
                vaisseau.Plastique = r.Next(restant); restant -= vaisseau.Plastique;
                vaisseau.Terre = r.Next(restant); restant -= vaisseau.Terre;
                vaisseau.Verre = r.Next(restant); restant -= vaisseau.Verre;
                vaisseau.Ferraille = restant;
                QueueCentreTri.Peek().QueueVaisseauPlein.Enqueue(vaisseau);
            }
            for (int i = 0; i < nbLeger; i++)
            {
                CVaisseauLeger vaisseau = new CVaisseauLeger();
                int restant = vaisseau.CapaciteMax;
                vaisseau.Papier = r.Next(restant); restant -= vaisseau.Papier;
                vaisseau.Plastique = r.Next(restant); restant -= vaisseau.Plastique;
                vaisseau.Terre = r.Next(restant); restant -= vaisseau.Terre;
                vaisseau.Verre = r.Next(restant); restant -= vaisseau.Verre;
                vaisseau.Ferraille = restant;
                QueueCentreTri.Peek().QueueVaisseauPlein.Enqueue(vaisseau);
            }
        }

        private void creationcentre(int nbCentreTri)
        {
            int papier, verre, plastique, ferraille, terre;
            for (int i = 1; i <= nbCentreTri; i++)
            {

                if (i % 2 == 0)
                {
                    papier = 1003;
                    verre = 857;
                    plastique = 3456;
                    ferraille = 457;
                    terre = 639;
                    CCentreTri centre = new CCentreTri(papier, verre, plastique, ferraille, terre);
                    QueueCentreTri.Enqueue(centre);



                }
                else
                {
                    papier = 3067;
                    verre = 2456;
                    plastique = 561;
                    ferraille = 2658;
                    terre = 8234;
                    CCentreTri centre = new CCentreTri(papier, verre, plastique, ferraille, terre);
                    QueueCentreTri.Enqueue(centre);

                }
            }
        }
        private void déroulement()
        {
            Queue<CVaisseau> temp = new Queue<CVaisseau>();
            foreach (CCentreTri centre in QueueCentreTri)
            {
                foreach ( CVaisseau vaisseau in temp)
                {
                    centre.QueueVaisseauPlein.Enqueue(temp.Dequeue());
                }
                foreach (CVaisseau vaisseau in centre.QueueVaisseauPlein)
                {
                    
                    centre.AjouterRessource(vaisseau.Papier, vaisseau.Verre, vaisseau.Plastique, vaisseau.Ferraille, vaisseau.Terre);
                    vaisseau.Papier = 0; vaisseau.Plastique = 0; vaisseau.Terre = 0;
                    vaisseau.Verre = 0; vaisseau.Ferraille = 0;
                    centre.QueueVaisseauVide.Enqueue(vaisseau);
                }
                foreach (CVaisseau vaisseau in centre.QueueVaisseauVide)
                {
                    temp.Enqueue(vaisseau);
                }
            }
        }

    }
}
