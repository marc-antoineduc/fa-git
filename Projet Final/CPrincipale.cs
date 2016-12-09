using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class CPrincipale
    {//Classe principale.
        Random r;
        public Queue<CCentreTri> QueueCentreTri;
        public CPrincipale()
        {//fonction qui guide le déroulement
            r = new Random();
            QueueCentreTri = new Queue<CCentreTri>();
            initialisation();
            Console.WriteLine("avant le triage.");
            affichage();
            déroulement();
            Console.WriteLine("après le triage.");
            affichage();
        }
        private void initialisation()
        {//initialise le nombre de vaisseau et de centre à partir des choix de l'utilisateur.
            bool verif = true;
            int vaisseau = 0, centre = 0; ;
            while (verif)
            {
                Console.WriteLine("Combien de vaisseaux ? \n1-100 \n2-200 \n3-300 \n4-400 \n5-500");
                switch (Console.ReadLine())
                {
                    case "1":
                        vaisseau = 25;
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
        {//Fonction qui crée les vaisseaux avec le nombre choisi par l'utilisateur. le nombre de ressource maximale est fixe mais le nombre de chacune est aléatoire. 
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
        {//crée les centres et les différencie s'il sont pairs, impairs, premiers et divisibles par 5 
            int papier, verre, plastique, ferraille, terre;
            for (int i = 1; i <= nbCentreTri; i++)
            {
                if ((i % 5 == 0) && (i % 2 == 0))
                {
                    papier = 0;
                    verre = 857;
                    plastique = 0;
                    ferraille = 0;
                    terre = 639;
                    CCentreTri centre = new CCentreTri(papier, verre, plastique, ferraille, terre);
                    QueueCentreTri.Enqueue(centre);
                }
                else
                {
                    if ((i % 5 == 0) && (i % 2 != 0))
                    {
                        papier = 0;
                        verre = 2456;
                        plastique = 0;
                        ferraille = 0;
                        terre = 8234;
                        CCentreTri centre = new CCentreTri(papier, verre, plastique, ferraille, terre);
                        QueueCentreTri.Enqueue(centre);
                    }
                    else
                    {
                        if ( i == 2)
                        {
                            papier = 0;
                            verre = 0;
                            plastique = 3456;
                            ferraille = 457;
                            terre = 0;
                            CCentreTri centre = new CCentreTri(papier, verre, plastique, ferraille, terre);
                            QueueCentreTri.Enqueue(centre);
                        }
                        else
                        {
                            if (verificationNombre(i) == true)
                            {
                                papier = 0;
                                verre = 0;
                                plastique = 561;
                                ferraille = 2658;
                                terre = 0;
                                CCentreTri centre = new CCentreTri(papier, verre, plastique, ferraille, terre);
                                QueueCentreTri.Enqueue(centre);
                            }
                            else
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
                    }
                }
            }
        }
        private void déroulement()
        {//fonction qui échange les ressources des vaisseaux et les mets dans les centres de tri. si celui-ci est plein, les ressources sont transportées dans la file de vaisseau vide.
            Queue<CVaisseau> temp = new Queue<CVaisseau>(), temp2 = new Queue<CVaisseau>();
            foreach (CCentreTri centre in QueueCentreTri)
            {
                int cptVaisseauPlein = 0;
                int cptVaisseauVide = 0;
                foreach ( CVaisseau vaisseau in temp)
                {
                    centre.QueueVaisseauPlein.Enqueue(vaisseau);
                }
                temp = new Queue<CVaisseau>();
                foreach (CVaisseau vaisseau in centre.QueueVaisseauPlein)
                {
                    bool verif = false;
                    for (int i = 0; i < vaisseau.Papier; i++)
                    {
                        if (centre.AjouterRessource(1, 0, 0, 0, 0) == false)
                        {
                            temp2 = centre.ChargementVaisseauAttente("papier");
                            foreach (CVaisseau  v in temp2)
                            {
                                temp.Enqueue(v);
                                cptVaisseauPlein++;
                            }
                        }
                        verif = true;
                    }
                    for (int i = 0; i < vaisseau.Verre; i++)
                    {
                        if (centre.AjouterRessource(0, 1, 0, 0, 0) == false)
                        {
                            temp2 = centre.ChargementVaisseauAttente("verre");
                            foreach (CVaisseau v in temp2)
                            {
                                temp.Enqueue(v);
                                cptVaisseauPlein++;
                            }
                        }
                        verif = true;
                    }
                    for (int i = 0; i < vaisseau.Plastique; i++)
                    {
                        if (centre.AjouterRessource(0, 0, 1, 0, 0) == false)
                        {
                            temp2 = centre.ChargementVaisseauAttente("plastique");
                            foreach (CVaisseau v in temp2)
                            {
                                temp.Enqueue(v);
                               cptVaisseauPlein++;
                            }
                        }
                        verif = true;
                    }
                    for (int i = 0; i < vaisseau.Ferraille; i++)
                    {
                        if (centre.AjouterRessource(0, 0, 0, 1, 0) == false)
                        {
                            temp2 = centre.ChargementVaisseauAttente("ferraille");
                            foreach (CVaisseau v in temp2)
                            {
                                temp.Enqueue(v);
                                cptVaisseauPlein++;
                            }
                        }
                        verif = true;
                    }

                    for (int i = 0; i < vaisseau.Terre; i++)
                    {
                        if (centre.AjouterRessource(0, 0, 0, 0, 1) == false)
                        {
                            temp2 = centre.ChargementVaisseauAttente("terre");
                            foreach (CVaisseau v in temp2)
                            {
                                temp.Enqueue(v);
                                cptVaisseauPlein++;
                            }
                        }
                        verif = true;
                    }
                    if (verif==true)
                    {
                        vaisseau.Papier = 0; vaisseau.Plastique = 0; vaisseau.Terre = 0;
                        vaisseau.Verre = 0; vaisseau.Ferraille = 0;
                        cptVaisseauVide++;
                        centre.QueueVaisseauVide.Enqueue(vaisseau);
                    }
                }
                for (int i = 0; i < cptVaisseauPlein; i++)
                {
                    centre.QueueVaisseauVide.Dequeue();
                }
                foreach (CVaisseau vaisseau in centre.QueueVaisseauVide)
                {
                    temp.Enqueue(vaisseau);
                }
            }
        }


        public static bool verificationNombre(double n)
        // fonction qui verifie si un nombre est premier ou non
        {
            int i;
            int racine;
            bool fini;
            decimal debRacine = Convert.ToInt32(Math.Sqrt(n));
            racine = Convert.ToInt32(Math.Truncate(debRacine));
            fini = false;
            i = 3;
            if (n < 2) { fini = true; }
            else if (n != 2)
            {
                if (n % 2 == 0)
                {
                    fini = true;
                }
                else
                {
                    while ((!fini) && (i <= racine))
                    {
                        if (n % i == 0) { fini = true; }
                        else { i = i + 2; }
                    }
                }
            }
            return (!fini);
        }

        private void affichage()//petite fonction affichant les caractéristiques des centres de tri.
        { int cptCentre = 0;
            int cpt2 = 0;
            foreach (CCentreTri centre in QueueCentreTri)
            {
                cptCentre++;
                cpt2++;
                Console.WriteLine("Centre de tri "+cptCentre+"\nPapier: " + centre.nbRessource("papier")+"\nVerre: "+centre.nbRessource("verre") + "\nFerraille: "+centre.nbRessource("ferraille")+ "\nTerre: "+centre.nbRessource("terre")+ "\nPlastique: "+centre.nbRessource("plastique")+"\nNombre de vaisseaux dans la file de départ: "+centre.QueueVaisseauVide.Count+ "\n-----------------------");
                if (cpt2==5)
                {
                    Console.ReadKey(true);
                    cpt2 = 0;
                }
            }
        }
    }
}
