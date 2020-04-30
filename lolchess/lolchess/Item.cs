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
            BFSword,
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
            Deathblade = 1,
            GiantSlayer,
            GuardianAngel,
            BloodThirster,
            HextechGunblade,
            SpearOfShojin,
            ZekesHerald,
            BladeRuinedKing,
            InfinityEdge,
            RapidFirecannon = 11,
            TitansResolve,
            RunnansHurricane,
            GuinsooRageblade,
            StatikkShiv,
            ZzRotPortal,
            InfiltratorsTalons,
            LastWhisper,
            BranbleVest = 21,
            SwordBreaker,
            LocketOfTheIronSolari,
            FrozenHeart,
            RedBuff,
            RebelMedal,
            ShroudOfStillness,
            DragonsClaw = 31,
            IonicSpark,
            ChaliceOfFavor,
            Zephyr,
            CelestialOrb,
            Quicksilver,
            RabadonsDeathcap =41,
            LudensEcho,
            Morellonomicon,
            DemolitionistsCharge,
            JeweledGauntlet,
            SeraphsEmbrace = 51,
            Redemption,
            StarGuardiansCharm,
            HandOfJustice,
            WarmogsArmor = 61,
            ProtectorsChestguard,
            TrapClaw,
            ForceOfNature = 71,
            DarkStarsHeart,
            ThiefsGloves = 81
        }

        public CombItem Combination(BaseItem item1, BaseItem item2)
        {


            return CombItem.Deathblade;

        }








    }
}
