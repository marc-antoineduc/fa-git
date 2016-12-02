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
            this.CapacitePapier = CapacitePapier; this.CapaciteTerre = CapaciteTerre; this.CapaciteVerre = CapaciteVerre;this.CapacitePlastique = CapacitePlastique; this.CapaciteFerraille = CapaciteFerraille;
            ListPapier = new List<CMatière>();
            Listverre = new List<CMatière>();
            ListPlastique = new List<CMatière>();
            ListFeraille = new List<CMatière>();
            ListTerre = new List<CMatière>();
        }

        public void Dechargement()
        {

        }

        public void Chargement()
        {

        }

    }
}
