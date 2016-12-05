using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class CCentreTri
    {
        public CCentreTri(int CapacitePapier, int CapaciteVerre, int CapacitePlastique, int CapaciteFerraille, int CapaciteTerre)
        {
            //Console.WriteLine(CapacitePapier + CapaciteVerre + CapacitePlastique + CapaciteFerraille + CapaciteTerre);
            Dechargement(CapacitePapier, CapaciteVerre, CapacitePlastique, CapaciteFerraille, CapaciteTerre);
        }

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
                
            Console.WriteLine(stackPapier.Count());
            Console.WriteLine(stackVerre.Count());
            Console.WriteLine(stackPlastique.Count());
            Console.WriteLine(stackFerraille.Count());
            Console.WriteLine(stackTerre.Count());
            Console.ReadKey();
        }

        public void Dechargement()
        {


        }

        public void Chargement()
        {

        }
    }
}
