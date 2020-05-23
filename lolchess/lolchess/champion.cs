using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lolchess
{
    class Champion
    {
        public short BFSword = 0;
        public short RecurveBow = 0;
        public short ChainVest = 0;
        public short NegatronCloak = 0;
        public short NeedlesslyLargeRod = 0;
        public short TearOfTheGoddess = 0;
        public short GiantsBelt = 0;
        public short Spatula = 0;
        public short SparringGloves = 0;

        public Champion(){
            this.coreItem = new Item.CombItem[3] { 0, 0, 0} ;       
        
        }


        public void SetEquipItem(Item.CombItem item1)
        {
            this.coreItem[0] = item1;
        }
        
        public void SetEquipItem(Item.CombItem item1, Item.CombItem item2)
        {
            this.coreItem[0] = item1;
            this.coreItem[1] = item2;
        }

        public void SetEquipItem(Item.CombItem item1, Item.CombItem item2, Item.CombItem item3) {
            this.coreItem[0] = item1;
            this.coreItem[1] = item2;
            this.coreItem[2] = item3;
        }

        public Item.CombItem[] coreItem {
            get; set;
        }

        public void BaseItemCalc() {
            for (int i = 0; i < 3; i++)
            {
                if (this.coreItem[i] != null) {
                    Dismantle(this.coreItem[i]);
                }
            }
         }

        public void Dismantle (Item.CombItem cItem0) {
            int[] baseItem = new int[2];
            baseItem[0] = (int)cItem0 / 10;
            baseItem[1] = (int)cItem0 % 10;
            
            for (int i = 0; i < 2; i++) {
                switch (baseItem[i]) {
                    case (int)Item.BaseItem.BFSword : this.BFSword++;
                        break;
                    case (int)Item.BaseItem.RecurveBow:
                        this.RecurveBow++;
                        break;
                    case (int)Item.BaseItem.ChainVest:
                        this.BFSword++;
                        break;
                    case (int)Item.BaseItem.NegatronCloak:
                        this.BFSword++;
                        break;
                    case (int)Item.BaseItem.NeedlesslyLargeRod:
                        this.NeedlesslyLargeRod++;
                        break;
                    case (int)Item.BaseItem.TearOfTheGoddess:
                        this.TearOfTheGoddess++;
                        break;
                    case (int)Item.BaseItem.GiantsBelt:
                        this.BFSword++;
                        break;
                    case (int)Item.BaseItem.Spatula:
                        this.Spatula++;
                        break;
                    case (int)Item.BaseItem.SparringGloves:
                        this.SparringGloves++;
                        break;

                }
             }
        }
    }
}
