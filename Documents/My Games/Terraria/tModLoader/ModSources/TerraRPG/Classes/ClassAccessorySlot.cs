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
using TerraRPG.Accessories;
using TerraRPG;


namespace TerraRPG.Classes
{
	public class RPGClasseAcessory : ModAccessorySlot
	{
		public override string FunctionalTexture => "TerraRPG/Assets/StartEmblem";
		public override bool DrawVanitySlot => false;
		public override bool DrawDyeSlot => false;
		public override string FunctionalBackgroundTexture => "Terraria/Images/Inventory_Back7"; 
		public override string VanityBackgroundTexture => "Terraria/Images/Inventory_Back11";

		public override bool CanAcceptItem(Item checkItem, AccessorySlotType classe)
		{
			if (classe == AccessorySlotType.FunctionalSlot && checkItem.GetGlobalItem<ClassGlobalItem>().isClasse)
            {
				return true;
			}
			
			return false;
		}
		public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
		{
			if (item.GetGlobalItem<ClassGlobalItem>().isClasse)
				return true;

			return false;

		}        public override void OnMouseHover(AccessorySlotType classe)
		{
			switch (classe)
			{
				case AccessorySlotType.FunctionalSlot:
					Main.hoverItemName = "Class";
					break;
			}
		}
	}
}
