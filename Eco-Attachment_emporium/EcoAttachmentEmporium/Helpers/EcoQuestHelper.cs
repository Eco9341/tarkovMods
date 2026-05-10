using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Utils;
using SPTarkov.Server.Core.Services;
using WTTServerCommonLib.Helpers;

namespace EcoAttachmentEmporium.Helpers
{
    [Injectable]
    public class EcoQuestHelper(DatabaseService  databaseService, ISptLogger<EcoQuestHelper> logger, QuestHelper questHelper)
    {

        // Define weapon IDs
        // ReSharper disable InconsistentNaming
        // ReSharper disable IdentifierTypo
        //snipers
        private const string AC_TX = "6917d89b54f5f109c106c1ee";
        private const string AC_TX_FDE = "69187ee78568323f8204aaf3";
        private const string AC_TX_Red = "69187ee78568323f8204aaf9";
        private const string AC_TX_GREEN = "691897048568323f8204ab0d";
        private const string USPSA_50cal = "695c42816dd1786b89029345";
        private const string WARN_METAL = "6925eae6b1f1b81dcf03db66";
        
        //shotguns
        private const string BP12 = "69d9435106dc0abe0209b658";
        private const string BP12_GEN2 = "69de7d7e9d80cc5c037bd276";
        private const string B1301 = "68fc9d35a95c0e57110beeab";
        private const string B1301_FDE = "68fe896c2b85e5d74c05a5ae";
        private const string B1301_GREEN = "68fe896c2b85e5d74c05a5af";
        
        //smg
        private const string PPK20 = "6930aaa9374b0cca3302d7c0";
        private const string VPO185 = "6992dc7e206da73f74008a8b";
        
        //pistols
        private const string AMT_HARDBALLER = "692acecad829da17240a60c3";
        private const string MK22_HUSHPUPPY = "695ece27f990bb6426070873";
        
        //rifles 
        private const string AK12K = "6986381b39678ae84203ff81";
        private const string AK12M1 = "68ed85275e9a77cf70058337";
        private const string AK12SK = "697f70958da76618a106499c";
        private const string AK74_NO_ROD = "68e1040726e57f736103f02c";
        private const string AK105_NO_ROD = "68d96442d7aac8a7a904db00";
        private const string AS_1 = "6978e7e796e988db77009efb";
        private const string AS_2 = "6979236eae0108cfe6061282";
        private const string AUG_300BLK = "69d44e3d9e11b4757df438ad";
        private const string BRN180 = "6902633fbfd8894b780f71b5";
        private const string BRN180_FDE = "6905291a7241fdf3f504b306";
        private const string AK_KOCHEVNIK = "693c5deb2e28b0b1e304ad40";
        private const string AK_KOCHEVNIK_FDE = "693db6b02539fba19b0c1390";
        private const string LR300 = "6951d6f528342dc818053a6c";
        private const string LR300_FDE = "6952f4c9065baefc31060c87";
        private const string NORINCO_M305A = "69093530ce2a0e0cfe00d861";
        private const string AK105_SAG = "69c6c3ceb74c2d039e07b269";
        private const string SAK21 = "699593bac8e1efb03709e24c";
        private const string SAK21_BLACK = "6995c26e24a63048dd09aae1";
        private const string SL8 = "699c3be62219dbbf5d075a04";
        private const string SR1 = "68dec580d8cef922540a65c6";
        private const string SR1_FDE = "68e1040726e57f736103f027";
        private const string TT_TR1 = "6999a28e24f9ef4d100d2ed2";
        private const string ZASTAVA_M19 = "68e6df79cf0bb22665098f60";
        private const string ZASTAVA_M19_FDE = "68e84293bc3a402bbb07e11d";
        private const string PSA_JAKL = "69f8ca293e7fb663aa6097ea";
        private const string PSA_JAKL_FDE = "69f8e41d3e7fb663aa6097f0";
        private const string PSA_JAKL_HONEYB = "69f9ca041336df7edb6708ab";
        private const string BRO_COMMANDO= "69fb5f225f919280cea5c17c";
        private const string COBALT_KINETICS= "69fb5f225f919280cea5c17c";
        private const string THOMPSON_TOKAREV= "69ff690473bcef4c7fbb4cee";
        
        //dmr
        private const string M700_AUTO = "6923adaa56bff0144c0a9aa3";
        
        // Weapon Mods
        
        public void ModifyQuests()
        {
            var quests = databaseService.GetTemplates().Quests;

            // ReSharper disable CommentTypo
            // ====================== PRAPOR QUESTS ======================

            // Punisher Part 4 (59ca264786f77445a80ed044)
            questHelper.AddWeaponsToKillCondition(quests, "59ca264786f77445a80ed044", [
                BP12, BP12_GEN2, B1301, B1301_FDE, B1301_GREEN
            ]);

            // Mall Cop (64e7b99017ab941a6f7bf9d7)
            questHelper.AddWeaponsToKillCondition(quests, "64e7b99017ab941a6f7bf9d7", [
                MK22_HUSHPUPPY, AMT_HARDBALLER
            ]);

            // Tickets, Please (64e7b9a4aac4cd0a726562cb)
            questHelper.AddWeaponsToKillCondition(quests, "64e7b9a4aac4cd0a726562cb", [
                PPK20, VPO185, THOMPSON_TOKAREV
            ]);

            // District Patrol (64e7b9bffd30422ed03dad38)
            questHelper.AddWeaponsToKillCondition(quests, "64e7b9bffd30422ed03dad38", [
                AK12K, AK12M1, AK12SK, AK74_NO_ROD, AK105_NO_ROD, AK105_SAG, AK_KOCHEVNIK, AK_KOCHEVNIK_FDE, SAK21, 
                SAK21_BLACK, ZASTAVA_M19, ZASTAVA_M19_FDE, AS_1, AS_2, AUG_300BLK, BRN180, BRN180_FDE, LR300, LR300_FDE, 
                SL8, NORINCO_M305A, SR1, SR1_FDE, TT_TR1, M700_AUTO, PSA_JAKL, PSA_JAKL_FDE, PSA_JAKL_HONEYB, BRO_COMMANDO, COBALT_KINETICS
            ]);

            // ====================== SKIER QUESTS ======================

            // Stirrup (596b455186f77457cb50eccb)
            questHelper.AddWeaponsToKillCondition(quests, "596b455186f77457cb50eccb", [
                MK22_HUSHPUPPY, AMT_HARDBALLER
            ]);

            // Silent Caliber (5c0bc91486f7746ab41857a2)
            questHelper.AddWeaponsToKillCondition(quests, "5c0bc91486f7746ab41857a2", [
                BP12, BP12_GEN2, B1301, B1301_FDE, B1301_GREEN
            ]);

            // Setup (5c1234c286f77406fa13baeb)
            questHelper.AddWeaponsToKillCondition(quests, "5c1234c286f77406fa13baeb", [
                BP12, BP12_GEN2, B1301, B1301_FDE, B1301_GREEN
            ]);

            // Connections Up North (6764174c86addd02bc033d68)
            questHelper.AddWeaponsToKillCondition(quests, "6764174c86addd02bc033d68", [
                AC_TX, AC_TX_FDE, AC_TX_GREEN, AC_TX_Red, WARN_METAL, USPSA_50cal
            ]);

            // ====================== PEACEKEEPER QUESTS ======================

            // Spa Tour Part 1 (5a03153686f77442d90e2171)
            questHelper.AddWeaponsToKillCondition(quests, "5a03153686f77442d90e2171", [
                BP12, BP12_GEN2, B1301, B1301_FDE, B1301_GREEN
            ]);

            // Worst Job (63a9b229813bba58a50c9ee5)
            questHelper.AddWeaponsToKillCondition(quests, "63a9b229813bba58a50c9ee5", [
                LR300, LR300_FDE, TT_TR1, BRN180, BRN180_FDE, PSA_JAKL, PSA_JAKL_FDE, PSA_JAKL_HONEYB, COBALT_KINETICS
            ]);

            // ====================== JAEGER QUESTS ======================

            var tarkovShooterWeapons = new[]
            {
                AC_TX, AC_TX_FDE, AC_TX_GREEN, AC_TX_Red, WARN_METAL, USPSA_50cal
            };

            // Tarkov Shooter Part 1-8 (WEAPONS)
            questHelper.AddWeaponsToKillCondition(quests, "5bc4776586f774512d07cf05", tarkovShooterWeapons); // Part 1
            questHelper.AddWeaponsToKillCondition(quests, "5bc479e586f7747f376c7da3", tarkovShooterWeapons); // Part 2
            questHelper.AddWeaponsToKillCondition(quests, "5bc47dbf86f7741ee74e93b9", tarkovShooterWeapons); // Part 3
            questHelper.AddWeaponsToKillCondition(quests, "5bc480a686f7741af0342e29", tarkovShooterWeapons); // Part 4
            questHelper.AddWeaponsToKillCondition(quests, "5bc4826c86f774106d22d88b", tarkovShooterWeapons); // Part 5
            questHelper.AddWeaponsToKillCondition(quests, "5bc4836986f7740c0152911c", tarkovShooterWeapons); // Part 6
            questHelper.AddWeaponsToKillCondition(quests, "5bc4856986f77454c317bea7", tarkovShooterWeapons); // Part 7
            questHelper.AddWeaponsToKillCondition(quests, "5bc4893c86f774626f5ebf3e", tarkovShooterWeapons); // Part 8

            // Tarkov Shooter Part 1-8 (MODS)
            
            // Part 1
            
            // Part 7


            
            // Claustrophobia (669fa3979b0ce3feae01a130)
            questHelper.AddWeaponsToKillCondition(quests, "669fa3979b0ce3feae01a130", [
                BP12, BP12_GEN2, B1301, B1301_FDE, B1301_GREEN
            ]);

            // ====================== MECHANIC QUESTS ======================

            // Psycho Sniper (5c0be13186f7746f016734aa)
            questHelper.AddWeaponsToKillCondition(quests, "5c0be13186f7746f016734aa", [
                AC_TX, AC_TX_FDE, AC_TX_GREEN, AC_TX_Red, WARN_METAL, USPSA_50cal
            ]);

            // Shooter Born in Heaven (5c0bde0986f77479cf22c2f8)
            questHelper.AddWeaponsToKillCondition(quests, "5c0bde0986f77479cf22c2f8", [
                AC_TX, AC_TX_FDE, AC_TX_GREEN, AC_TX_Red, WARN_METAL, USPSA_50cal
            ]);
        }
    }
}
