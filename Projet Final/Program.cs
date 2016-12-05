using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int papier, verre, plastique, ferraille, terre;

            papier = 1003;
            verre = 857;
            plastique = 3456;
            ferraille = 457;
            terre = 639;
            CCentreTri centre = new CCentreTri(papier, verre, plastique, ferraille, terre);
            //CPrincipale principale = new CPrincipale();

        }
    }
}


//------------------------- la fonctione crée 100 centre de tri avec des capacité différente selon le nombre paire ou non ----------------------------

//int papier, verre, plastique, ferraille, terre;
//            for (int i = 1; i<nbCentreTri; i++)
//            {

//                if (i % 2 == 0)
//                {
//                    papier = 1003;
//                    verre = 857;
//                    plastique = 3456;
//                    ferraille = 457;
//                    terre = 639;
//                    CCentreTri centre = new CCentreTri(papier, verre, plastique, ferraille, terre);



//                }
//                else
//                {
//                    papier = 3067;
//                    verre = 2456;
//                    plastique = 561;
//                    ferraille = 2658;
//                    terre = 8234;
//                    CCentreTri centre = new CCentreTri(papier, verre, plastique, ferraille, terre);

//                }
//            }
