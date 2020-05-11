using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolchess
{
    class Item
    {
        public enum BaseItem{
            BFSword = 1,
            RecurveBow,
            ChainVest,
            NegatronCloak,
            NeedlesslyLargeRod,
            TearOfTheGoddess,
            GiantsBelt,
            Spatula,
            SparringGloves
        }

        public enum CombItem{
            Deathblade = 11,
            GiantSlayer,
            GuardianAngel,
            BloodThirster,
            HextechGunblade,
            SpearOfShojin,
            ZekesHerald,
            BladeRuinedKing,
            InfinityEdge,
            RapidFirecannon = 22,
            TitansResolve,
            RunnansHurricane,
            GuinsooRageblade,
            StatikkShiv,
            ZzRotPortal,
            InfiltratorsTalons,
            LastWhisper,
            BranbleVest = 33,
            SwordBreaker,
            LocketOfTheIronSolari,
            FrozenHeart,
            RedBuff,
            RebelMedal,
            ShroudOfStillness,
            DragonsClaw = 44,
            IonicSpark,
            ChaliceOfFavor,
            Zephyr,
            CelestialOrb,
            Quicksilver,
            RabadonsDeathcap = 55,
            LudensEcho,
            Morellonomicon,
            DemolitionistsCharge,
            JeweledGauntlet,
            SeraphsEmbrace = 66,
            Redemption,
            StarGuardiansCharm,
            HandOfJustice,
            WarmogsArmor = 77,
            ProtectorsChestguard,
            TrapClaw,
            ForceOfNature = 88,
            DarkStarsHeart,
            ThiefsGloves = 99
        }

        public int Combination(BaseItem item1, BaseItem item2)
        {
            int temp = 0;
            int combResult = 0;
            if (item1 > item2)
            {
                temp = (int)item1;
                item1 = item2;
                item2 = (BaseItem)temp;
            }

            combResult = (int)item1 * 10 + (int)item2;

            return combResult;
        }

        public int Dismantle (CombItem cItem0)
        {


            
        }







    }
}
