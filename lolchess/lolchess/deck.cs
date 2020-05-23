using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolchess
{
    class Deck
    {

        short BFSword = 0;
        short RecurveBow = 0;
        short ChainVest = 0;
        short NegatronCloak = 0;
        short NeedlesslyLargeRod = 0;
        short TearOfTheGoddess = 0;
        short GiantsBelt = 0;
        short Spatula = 0;
        short SparringGloves = 0;

        public Deck() {
            this.coreChampion = new Champion[9] { null, null, null, null ,null ,null ,null ,null ,null};

        }

        public void SetCoreChampion(Champion champ1, Champion champ2, Champion champ3, Champion champ4, Champion champ5, Champion champ6, Champion champ7, Champion champ8) {
            this.coreChampion[0] = champ1;
            this.coreChampion[1] = champ2;
            this.coreChampion[2] = champ3;
            this.coreChampion[3] = champ4;
            this.coreChampion[4] = champ5;
            this.coreChampion[5] = champ6;
            this.coreChampion[6] = champ7;
            this.coreChampion[7] = champ8;
           
        }

        public void SetCoreChampion(Champion champ1, Champion champ2, Champion champ3, Champion champ4, Champion champ5, Champion champ6, Champion champ7, Champion champ8, Champion champ9)
        {
            this.coreChampion[0] = champ1;
            this.coreChampion[1] = champ2;
            this.coreChampion[2] = champ3;
            this.coreChampion[3] = champ4;
            this.coreChampion[4] = champ5;
            this.coreChampion[5] = champ6;
            this.coreChampion[6] = champ7;
            this.coreChampion[7] = champ8;
            this.coreChampion[8] = champ9;
        }

        public Champion[] coreChampion {
            get;set;
        }

        public void TotalBaseItem ()
        {
            for (int i = 0; i < 9; i++)
            {
                if (this.coreChampion[i] != null) {
                    this.BFSword += this.coreChampion[i].BFSword;
                    this.RecurveBow += this.coreChampion[i].RecurveBow;
                    this.ChainVest += this.coreChampion[i].ChainVest;
                    this.NegatronCloak += this.coreChampion[i].NegatronCloak;
                    this.NeedlesslyLargeRod += this.coreChampion[i].NeedlesslyLargeRod;
                    this.TearOfTheGoddess += this.coreChampion[i].TearOfTheGoddess;
                    this.GiantsBelt += this.coreChampion[i].GiantsBelt;
                    this.Spatula += this.coreChampion[i].Spatula;
                    this.SparringGloves += this.coreChampion[i].SparringGloves;
                }
            }
        }
       
    }

}
