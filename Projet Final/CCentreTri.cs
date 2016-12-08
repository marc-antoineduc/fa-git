using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class CCentreTri
    {
        Queue<CVaisseau> _QueueVaisseauPlein, _QueueVaisseauVide;
        Stack<CMatière> stackPapier;
        Stack<CMatière> stackVerre;
        Stack<CMatière> stackPlastique;
        Stack<CMatière> stackFerraille;
        Stack<CMatière> stackTerre;
        int CapacitePapier, CapaciteVerre, CapacitePlastique, CapaciteFerraille, CapaciteTerre;
        public CCentreTri(int CapacitePapier, int CapaciteVerre, int CapacitePlastique, int CapaciteFerraille, int CapaciteTerre)
        {

            //Console.WriteLine(CapacitePapier + CapaciteVerre + CapacitePlastique + CapaciteFerraille + CapaciteTerre);
            
            this.CapacitePapier = CapacitePapier;
            this.CapaciteVerre = CapaciteVerre;
            this.CapacitePlastique = CapacitePlastique;
            this.CapaciteFerraille = CapaciteFerraille;
            this.CapaciteTerre = CapaciteTerre;
             stackPapier = new Stack<CMatière>();
             stackVerre = new Stack<CMatière>();
             stackPlastique = new Stack<CMatière>();
             stackFerraille = new Stack<CMatière>();
             stackTerre = new Stack<CMatière>();
            _QueueVaisseauPlein = new Queue<CVaisseau>();
            _QueueVaisseauVide = new Queue<CVaisseau>();
        }
        public Queue<CVaisseau> QueueVaisseauPlein
        {
            get { return _QueueVaisseauPlein; }
            set { _QueueVaisseauPlein = value; }
        }
        public Queue<CVaisseau> QueueVaisseauVide
        {
            get { return _QueueVaisseauVide; }
            set { _QueueVaisseauVide = value; }
        }
        public int capacitePapier
        {
            get { return CapacitePapier; }
        }
        public int capaciteVerre
        {
            get { return CapaciteVerre; }
        }
        public int capacitePlastique
        {
            get { return CapacitePlastique; }
        }
        public int capaciteFerraille
        {
            get { return CapaciteFerraille; }
        }
        public int capaciteTerre
        {
            get { return CapaciteTerre; }
        }
        // crée les stack de matieres
        public bool AjouterRessource(int papier, int verre, int plastique, int ferraille, int terre)
        {
            for (int i = 0; i < papier; i++)
            {
                CPapier papier1 = new CPapier();
                stackPapier.Push(papier1);
                if(stackPapier.Count == CapacitePapier)
                {
                    return false;
                    //RetirrerRessource(stackPapier.Count, papier1);
                }
            }

            for (int i = 0; i < verre; i++)
            {
                CVerre verre1 = new CVerre();
                stackVerre.Push(verre1);
                if (stackVerre.Count == CapaciteVerre)
                {
                    return false;
                }
            }
            
            for (int i = 0; i < plastique; i++)
            {
                CPlastique plastique1 = new CPlastique();
                stackPlastique.Push(plastique1);
                if (stackPlastique.Count == CapacitePlastique)
                {
                    return false;
                }
            }
            for (int i = 0; i < ferraille; i++)
            {
                CFerraille ferraille1 = new CFerraille();
                stackFerraille.Push(ferraille1);
                if (stackFerraille.Count == CapaciteFerraille)
                {
                    return false;
                }
            }

            for (int i = 0; i < terre; i++)
            {
                CTerre terre1 = new CTerre();
                stackTerre.Push(terre1);
                if (stackTerre.Count == CapaciteTerre )
                {
                    return false;
                }
            }
                
            //Console.WriteLine(stackPapier.Count());
            //Console.WriteLine(stackVerre.Count());
            //Console.WriteLine(stackPlastique.Count());
            //Console.WriteLine(stackFerraille.Count());
            //Console.WriteLine(stackTerre.Count());
            //Console.ReadKey();
            return true;
        }

        //public void RetirrerRessource(int RessourceFull, CMatière matiere)
        //{
        //    switch (matiere.Matiere)
        //    {
        //        case "papier":
        //            for (int i = 0; i < RessourceFull; i++)
        //            {
        //                _QueueVaisseauVide.Peek().Papier += 1;
        //                if (_QueueVaisseauVide.Peek().placeDisponible() == false)
        //                {
        //                    foreach ()
        //                                    }
        //            }
        //            break;
        //        case "verre":
        //            break;
        //        case "plastique":
        //            break;
        //        case "ferraille":
        //            break;
        //        case "terre":
        //            break;
        //    }


        //}

        public void ChargementVaisseauAttente(string matiere)


        {
            foreach (CVaisseau vaisseau in QueueVaisseauVide)
            {

                switch (matiere)
                {
                    case "papier":
                        while ((vaisseau.placeDisponible() == true)&&(stackPapier.Count != 0))
                        {
                            stackPapier.Pop();
                            vaisseau.Papier++;
                        }
                        break;
                    case "verre":
                        while ((vaisseau.placeDisponible() == true) && (stackVerre.Count != 0))
                        {
                            stackVerre.Pop();
                            vaisseau.Verre++;
                        }
                        break;
                    case "plastique":
                        while ((vaisseau.placeDisponible() == true) && (stackPlastique.Count != 0))
                        {
                            stackPlastique.Pop();
                            vaisseau.Plastique++;
                        }
                        break;
                    case "ferraille":
                        while ((vaisseau.placeDisponible() == true) && (stackFerraille.Count != 0))
                        {
                            stackFerraille.Pop();
                            vaisseau.Ferraille++;
                        }
                        break;
                    case "terre":
                        while ((vaisseau.placeDisponible() == true) && (stackTerre.Count != 0))
                        {
                            stackTerre.Pop();
                            vaisseau.Terre++;
                        }
                        break;
                }
            }
        }
    }
}
