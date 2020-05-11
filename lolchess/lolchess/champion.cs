using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lolchess
{
    class champion
    {
        Item.CombItem[] CoreItem = new Item.CombItem[3];


        public champion()
        {

        }

        public void equipItem(Item.CombItem item1)
        {
            this.CoreItem[0] = item1;
        }
        
        public void equipItem(Item.CombItem item1, Item.CombItem item2)
        {
            this.CoreItem[0] = item1;
            this.CoreItem[1] = item2;
        }

        public void equipItem(Item.CombItem item1, Item.CombItem item2, Item.CombItem item3) {
            this.CoreItem[0] = item1;
            this.CoreItem[1] = item2;
            this.CoreItem[2] = item3;
        }


    }
   
    class championList
    {
        champion champAhri = new champion();
        
    
    
    }




}
