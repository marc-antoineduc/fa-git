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
            //AjouterRessource(CapacitePapier, CapaciteVerre, CapacitePlastique, CapaciteFerraille, CapaciteTerre);
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
        // crée les stack de matieres
        public void AjouterRessource(int papier, int verre, int plastique, int ferraille, int terre)
        {
            for (int i = 0; i < papier; i++)
            {
                CPapier papier1 = new CPapier();
                stackPapier.Push(papier1);
            }

            for (int i = 0; i < verre; i++)
            {
                CVerre verre1 = new CVerre();
                stackVerre.Push(verre1);
            }
            
            for (int i = 0; i < plastique; i++)
            {
                CPlastique plastique1 = new CPlastique();
                stackPlastique.Push(plastique1);
            }
            for (int i = 0; i < ferraille; i++)
            {
                CFerraille ferraile1 = new CFerraille();
                stackFerraille.Push(ferraile1);
            }

            for (int i = 0; i < terre; i++)
            {
                CTerre terre1 = new CTerre();
                stackTerre.Push(terre1);
            }
                
            //Console.WriteLine(stackPapier.Count());
            //Console.WriteLine(stackVerre.Count());
            //Console.WriteLine(stackPlastique.Count());
            //Console.WriteLine(stackFerraille.Count());
            //Console.WriteLine(stackTerre.Count());
            //Console.ReadKey();
        }

        public void Dechargement()
        {


        }

        public void Chargement()
        {

        }
    }
}
