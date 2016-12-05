using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class CVaisseau
    {
        protected string type = "";
        protected int capaciteMax = 0, papier = 0, verre = 0, plastique = 0, ferraille = 0, terre = 0;
        public CVaisseau(string type, int capaciteMax)
        {
            this.type = type; this.capaciteMax = capaciteMax;
        }
        public string Type
        {
            get { return type; }
        }
        public int CapaciteMax
        {
            get { return capaciteMax; }
        }
        public int Papier
        {
            get { return papier; }
            set { papier = value; }
        }

        public int Verre
        {
            get { return verre; }
            set { verre = value; }
        }

        public int Plastique
        {
            get { return plastique; }
            set { plastique = value; }
        }

        public int Ferraille
        {
            get { return ferraille; }
            set { ferraille = value; }
        }

        public int Terre
        {
            get { return terre; }
            set { terre = value; }
        }
        public bool placeDisponible()
        {
            bool capacite = true;
            if (papier+verre+plastique+ferraille+terre == CapaciteMax)
            {
                capacite = false;
            }
            return capacite;
        }
        public int donnerRessource(int ressource)
        {
            int var = 0;

            switch (ressource)
            {
                case 1: var = papier; papier= 0; break;
                case 2: var = plastique; plastique= 0; break;
                case 3: var = terre; terre = 0; break;
                case 4: var = verre; verre = 0; break;
                case 5: var = ferraille; ferraille = 0; break;
            }
            return var;
        }


    }
}
