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


namespace TerraRPG.Global
{
    public class GlobalSystem : GlobalItem
{    public override void SetDefaults(Item item)
        {
           if (item.maxStack is 999) item.maxStack = 9999;
           item.autoReuse = true;
        }
    public override void PreUpdateVanitySet(Player player, string set)
        {
            player.extraAccessory = true;
            player.extraAccessorySlots += 1;
        }
        
    }
    }  
     public class KeySystem : ModSystem
        {
        public static ModKeybind Ability1;
        public static ModKeybind Ability2;
        public static ModKeybind AbilityUltimate;
        public static ModKeybind Menu;
    public override void Load()
        {
        Ability1 = KeybindLoader.RegisterKeybind(Mod, "Ability: 1", "num1");
        Ability2 = KeybindLoader.RegisterKeybind(Mod, "Ability: 2", "num2");
        AbilityUltimate = KeybindLoader.RegisterKeybind(Mod, "Ability: Ultimate", "num3");
}
}
