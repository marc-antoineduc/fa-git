using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class CCentreTri
    {
        List<CMatière> ListPapier, Listverre, ListPlastique, ListFeraille, ListTerre;
        int CapacitePapier, CapaciteVerre, CapacitePlastique, CapaciteFerraille, CapaciteTerre;
        public CCentreTri(int CapacitePapier, int CapaciteVerre, int CapacitePlastique, int CapaciteFerraille, int CapaciteTerre)
        {
<<<<<<< HEAD

            this.CapacitePapier = CapacitePapier; this.CapaciteTerre = CapaciteTerre; this.CapaciteVerre = CapaciteVerre;this.CapacitePlastique = CapacitePlastique; this.CapaciteFerraille = CapaciteFerraille;
            ListPapier = new List<CMatière>();
            Listverre = new List<CMatière>();
            ListPlastique = new List<CMatière>();
            ListFeraille = new List<CMatière>();
            ListTerre = new List<CMatière>();
=======
>>>>>>> origin/master
            //Console.WriteLine(CapacitePapier + CapaciteVerre + CapacitePlastique + CapaciteFerraille + CapaciteTerre);
            Dechargement(CapacitePapier, CapaciteVerre, CapacitePlastique, CapaciteFerraille, CapaciteTerre);
        }

        // crée les stack de matieres
        public void Dechargement(int papier, int verre, int plastique, int ferraille, int terre)
        {
            
            Stack<int> stackPapier = new Stack<int>();
            Stack<int> stackVerre = new Stack<int>();
            Stack<int> stackPlastique = new Stack<int>();
            Stack<int> stackFerraille = new Stack<int>();
            Stack<int> stackTerre = new Stack<int>();

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
                
<<<<<<< HEAD

=======
            Console.WriteLine(stackPapier.Count());
            Console.WriteLine(stackVerre.Count());
            Console.WriteLine(stackPlastique.Count());
            Console.WriteLine(stackFerraille.Count());
            Console.WriteLine(stackTerre.Count());
            Console.ReadKey();
>>>>>>> origin/master
        }

        public void Dechargement()
        {


        }

        public void Chargement()
        {

        }
<<<<<<< HEAD
        
=======
>>>>>>> origin/master
    }
}
