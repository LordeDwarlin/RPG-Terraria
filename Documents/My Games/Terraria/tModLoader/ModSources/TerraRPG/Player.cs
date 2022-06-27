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
using TerraRPG.Classes;
using TerraRPG.Accessories;
using TerraRPG;
using TerraRPG.Buffs;

namespace TerraRPG
{
    
	public class ClassEquip : ModPlayer
	{
        public string equippedClasse;
        public bool hasClasse = false;
        public override void ResetEffects()
        {
            hasClasse = false;
            NpcXpLife.Classe = "Default";
            if (NpcXpLife.BuffLevel is 1)
            {
                Player.AddBuff(ModContent.BuffType<Buffs.Leveling>(), 1);          
            }
            else if(NpcXpLife.BuffLevel is 0)
            {
            }
        }
    }
}