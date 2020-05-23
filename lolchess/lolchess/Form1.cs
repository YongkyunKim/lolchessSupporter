using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lolchess
{
    public partial class Form1 : Form
    {
        Champion champGraves = new Champion();
        Champion champMalphite = new Champion();
        Champion champBlitzCrank = new Champion();
        Champion champEzreal = new Champion();
        Champion champVi = new Champion();
        Champion champChoGath = new Champion();
        Champion champJinx = new Champion();
        Champion champMisFortune = new Champion();

        Champion champShen = new Champion();
        Champion champJayce = new Champion();
        Champion champKarma = new Champion();
        Champion champKassadin = new Champion();
        Champion champIrelia = new Champion();
        Champion champKayle = new Champion();
        Champion champWukong = new Champion();
        Champion champLulu = new Champion();


        Deck deckBlasterBrawler = new Deck();
        Deck deckManaReaverValkyrie = new Deck();




        public Form1()
        {
            InitializeComponent();

            champJinx.SetEquipItem(Item.CombItem.GiantSlayer, Item.CombItem.Deathblade, Item.CombItem.LastWhisper);
            champJinx.BaseItemCalc();
            champMisFortune.SetEquipItem(Item.CombItem.Quicksilver, Item.CombItem.SeraphsEmbrace, Item.CombItem.Morellonomicon);
            champMisFortune.BaseItemCalc();
            
            deckBlasterBrawler.SetCoreChampion(champGraves,champMalphite,champBlitzCrank,champEzreal,champVi,champChoGath,champJinx,champMisFortune);
            deckBlasterBrawler.TotalBaseItem();


            deckManaReaverValkyrie.SetCoreChampion(champShen, champJayce, champKarma, champKassadin, champKayle, champIrelia, champWukong, champLulu, champMisFortune);




        }

        private void button1_Click(object sender, EventArgs e)
        {

                            
           
        }

   

    }
}
