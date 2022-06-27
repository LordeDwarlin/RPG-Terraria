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
using TerraRPG;
using TerraRPG.Accessories;
using TerraRPG.Classes;

namespace TerraRPG.Accessories
{
 public class EmblemRPG2 : ModItem
 {
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Summoner Class");
        Item.rare = ItemRarityID.Master;
    }
    public override void SetDefaults()
    {
        Item.width = 10;
        Item.height = 10;
        Item.value = 2500;
        Item.rare = ItemRarityID.Master;
        Item.accessory = true;
        Item.maxStack = 1;
        Item.GetGlobalItem<ClassGlobalItem>().isClasse = true;    
    }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
        var  LevelSummoner = NpcXpLife.SummonerLevel;
        var Stat2 = 0.5 * NpcXpLife.SummonerLevel;
        TooltipLine StatusSum1 = new TooltipLine(Mod, "Status1", "Class Level: "+ LevelSummoner);
        TooltipLine StatusSum2 = new TooltipLine(Mod, "Status2","Defense is increased +:" + LevelSummoner +
                                                            "\nYour max life is increased +" +LevelSummoner+"%" +
                                                            "\nDamage reduction is increased +" + Stat2+"%");
    StatusSum1.OverrideColor = new Color(255, 215, 0);
    StatusSum2.OverrideColor = new Color(50, 250, 50);
    tooltips.Add(item: StatusSum1);
    tooltips.Add(item: StatusSum2);

    }
        public override void UpdateEquip(Player player)
        {
        player.statDefense += NpcXpLife.SummonerLevel;
        player.statLifeMax2 -= ((NpcXpLife.SummonerLevel * player.statLifeMax2)/100);
        player.maxMinions += NpcXpLife.SummonerLevel/2;
        player.endurance += 0.005f * NpcXpLife.SummonerLevel;
        NpcXpLife.Classe = "Summoner";
        }
        public override void AddRecipes()
    {
        CreateRecipe()
        .AddIngredient(ItemID.DirtBlock, 1)
        .Register();
    }
            public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            if (player.GetModPlayer<ClassEquip>().hasClasse == true)
                return false;

            if (!modded)
                return false;

            return base.CanEquipAccessory(player, slot, modded);
        }
    }
} 