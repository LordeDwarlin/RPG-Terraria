using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Linq;
using System.Collections.Generic;
using Terraria.GameContent.Creative;
using Terraria.Net;
using Microsoft.Xna.Framework;
using System;
using Terraria.ObjectData;
using Terraria.UI;
using Terraria.ModLoader.IO;
using System.IO;
using TerraRPG;
using TerraRPG.Accessories;
using TerraRPG.Classes;
using Terraria.GameInput;
using static Terraria.ModLoader.ModContent;
using Terraria.Audio;
using Terraria.DataStructures;
using TerraRPG.Buffs;


namespace TerraRPG
{
	public  class NpcXpLife : GlobalNPC
	{
        public static int XP, XXP, TankXXP, SummonerXXP;
        public static int Level = 1;
        public static int TankLevel = 1;
        public static int StaLevel= 1;
        public static int SummonerLevel = 1;
        public static string Classe = "Default";
        public static string Leveliu = "Level Up!";

        public static int BuffLevel = 0;


        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void OnKill(NPC npc)
        {
            if(npc.boss is true)
            {
            XP = ((npc.lifeMax + npc.defense + npc.damage)/8);
            }
            else if(npc.boss is false)
            {
            XP = ((npc.lifeMax + npc.defense + npc.damage)/10);
            }
            XXP = XXP + XP;
        if(TankLevel != StaLevel)
        {
        SoundEngine.PlaySound(SoundID.Thunder);
        Player.OverheadMessage Leveliu;
        BuffLevel = 1;
        StaLevel = TankLevel;
        }
        if (Classe is "Tank")
        {
            TankXXP =TankXXP + XP;
        if (TankXXP >= 0 && TankXXP <=10000)
        {
            TankLevel = 1;
        }
        else if (TankXXP >= 10001 && TankXXP <=50000)
        {
            TankLevel = 2;
        }
        else if (TankXXP >= 50001 && TankXXP<=100000)
        {
            TankLevel = 3;
        }
        else if (TankXXP >= 100001 && TankXXP<=150000)
        {
            TankLevel = 4;
        }
         else if (TankXXP >= 150001 && TankXXP<=200000)
        {
            TankLevel = 5;
        }
        else if (TankXXP >= 200001 && TankXXP<=300000)
        {
            TankLevel = 6;
        }
         else if (TankXXP >= 300001 && TankXXP<=400000)
        {
            TankLevel = 7;
        }
        else if (TankXXP >= 400001 && TankXXP<=500000)
        {
            TankLevel = 8;
        }
         else if (TankXXP >= 500001 && TankXXP<=600000)
        {
            TankLevel = 9;
        }
        else if (TankXXP >= 600001 && TankXXP<=700000)
        {
            TankLevel = 10;
        }
        else if (TankXXP >= 600001 && TankXXP<=800000)
        {
            TankLevel = 11;
        }
        else if (TankXXP >= 800001 && TankXXP<=900000)
        {
            TankLevel = 12;
        }
        else if (TankXXP >= 900001 && TankXXP<=1000000)
        {
            TankLevel = 13;
        }
         else if (TankXXP >= 1000001 && TankXXP<=1100000)
        {
            TankLevel = 14;
        }
         else if (TankXXP >= 1100001 && TankXXP<=1200000)
        {
            TankLevel = 15;
        }
        else if (TankXXP >= 1200001 && TankXXP<=1300000)
        {
            TankLevel = 16;
        }
         else if (TankXXP >= 1300001 && TankXXP<=1400000)
        {
            TankLevel = 17;
        }
        else if (TankXXP >= 1400001 && TankXXP<=1500000)
        {
            TankLevel = 18;
        }
         else if (TankXXP >= 1500001 && TankXXP<=1600000)
        {
            TankLevel = 19;
        }
         else if (TankXXP >= 1600001 && TankXXP<=1700000)
        {
            TankLevel = 20;
        }
        }

        if (Classe is "Summoner")
        {
        SummonerXXP = SummonerXXP + XP;
        if (SummonerXXP >= 0 && SummonerXXP <=10000)
        {
            SummonerLevel = 1;
        }
        else if (SummonerXXP >= 10001 && SummonerXXP <=50000)
        {
            SummonerLevel = 2;
        }
        else if (SummonerXXP >= 50001 && SummonerXXP<=100000)
        {
            SummonerLevel = 3;
        }
        else if (SummonerXXP >= 100001 && SummonerXXP<=150000)
        {
            SummonerLevel = 4;
        }
         else if (SummonerXXP >= 150001 && SummonerXXP<=200000)
        {
            SummonerLevel = 5;
        }
        else if (SummonerXXP >= 200001 && SummonerXXP<=300000)
        {
            SummonerLevel = 6;
        }
         else if (SummonerXXP >= 300001 && SummonerXXP<=400000)
        {
            SummonerLevel = 7;
        }
        else if (SummonerXXP >= 400001 && SummonerXXP<=500000)
        {
            SummonerLevel = 8;
        }
         else if (SummonerXXP >= 500001 && SummonerXXP<=600000)
        {
            SummonerLevel = 9;
        }
        else if (SummonerXXP >= 600001 && SummonerXXP<=700000)
        {
            SummonerLevel = 10;
        }
        else if (SummonerXXP >= 600001 && SummonerXXP<=800000)
        {
            SummonerLevel = 11;
        }
        else if (SummonerXXP >= 800001 && SummonerXXP<=900000)
        {
            SummonerLevel = 12;
        }
        else if (SummonerXXP >= 900001 && SummonerXXP<=1000000)
        {
            SummonerLevel = 13;
        }
         else if (SummonerXXP >= 1000001 && SummonerXXP<=1100000)
        {
            SummonerLevel = 14;
        }
         else if (SummonerXXP >= 1100001 && SummonerXXP<=1200000)
        {
            SummonerLevel = 15;
        }
        else if (SummonerXXP >= 1200001 && SummonerXXP<=1300000)
        {
            SummonerLevel = 16;
        }
         else if (SummonerXXP >= 1300001 && SummonerXXP<=1400000)
        {
            SummonerLevel = 17;
        }
        else if (SummonerXXP >= 1400001 && SummonerXXP<=1500000)
        {
            SummonerLevel = 18;
        }
         else if (SummonerXXP >= 1500001 && SummonerXXP<=1600000)
        {
            SummonerLevel = 19;
        }
         else if (SummonerXXP >= 1600001 && SummonerXXP<=1700000)
        {
            SummonerLevel = 20;
        }
        }

        }
    }
    
}