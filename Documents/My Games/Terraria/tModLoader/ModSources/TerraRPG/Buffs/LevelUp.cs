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


namespace TerraRPG.Buffs
{
public class Leveling : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LevelUp");
            Description.SetDefault("Level Up!");
        }
    }
}
