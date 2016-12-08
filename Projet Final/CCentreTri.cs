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
        Stack<int> stackPapier;
        Stack<int> stackVerre;
        Stack<int> stackPlastique;
        Stack<int> stackFerraille;
        Stack<int> stackTerre;
        int CapacitePapier, CapaciteVerre, CapacitePlastique, CapaciteFerraille, CapaciteTerre;
        public CCentreTri(int CapacitePapier, int CapaciteVerre, int CapacitePlastique, int CapaciteFerraille, int CapaciteTerre)
        {
<<<<<<< HEAD
            //Console.WriteLine(CapacitePapier + CapaciteVerre + CapacitePlastique + CapaciteFerraille + CapaciteTerre);
            Dechargement(CapacitePapier, CapaciteVerre, CapacitePlastique, CapaciteFerraille, CapaciteTerre);
            
=======
            this.CapacitePapier = CapacitePapier;
            this.CapaciteVerre = CapaciteVerre;
            this.CapacitePlastique = CapacitePlastique;
            this.CapaciteFerraille = CapaciteFerraille;
            this.CapaciteTerre = CapaciteTerre;
             stackPapier = new Stack<int>();
             stackVerre = new Stack<int>();
             stackPlastique = new Stack<int>();
             stackFerraille = new Stack<int>();
             stackTerre = new Stack<int>();
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
>>>>>>> 5314f7da1769e5792dbba892947a59993793f19f
        }
        // crée les stack de matieres
        public void AjouterRessource(int papier, int verre, int plastique, int ferraille, int terre)
        {
            for (int i = 0; i < papier; i++)
            {
                stackPapier.Push(1);
            }

            for (int i = 0; i < verre; i++)
            {
                stackVerre.Push(1);
            }
            
            for (int i = 0; i < plastique; i++)
            {
                stackPlastique.Push(1);
            }
            for (int i = 0; i < ferraille; i++)
            {
                stackFerraille.Push(1);
            }

            for (int i = 0; i < terre; i++)
            {
                stackTerre.Push(1);
            }
                
            Console.WriteLine(stackPapier.Count());
            Console.WriteLine(stackVerre.Count());
            Console.WriteLine(stackPlastique.Count());
            Console.WriteLine(stackFerraille.Count());
            Console.WriteLine(stackTerre.Count());
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
