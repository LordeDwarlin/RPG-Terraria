using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Utilities;
using Terraria.ModLoader.IO;
using TerraRPG;

namespace TerraRPG
{
	public class ClassGlobalItem : GlobalItem
	{
        public bool isClasse = false;
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

    }
}
