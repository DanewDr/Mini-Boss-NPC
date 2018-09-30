using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent;
using Terraria.IO;
using Terraria.ObjectData;
using Terraria.Utilities;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class OmegaEmblem : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Omega Emblem");
			Tooltip.SetDefault("15% damage increase");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
			item.expert = true;
			item.accessory = true;
        }
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		player.meleeDamage += .15f;
		player.rangedDamage += .15f;
		player.magicDamage += .15f;
		player.minionDamage += .15f;
		player.thrownDamage += .15f;
		}
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WarriorEmblem, 1);
			recipe.AddIngredient(ItemID.RangerEmblem, 1);
			recipe.AddIngredient(ItemID.SorcererEmblem);
			recipe.AddIngredient(ItemID.SummonerEmblem);
/*			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("ThrowerEmblem"), 1);
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("AlchemistEmblem"));
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("ThrowerEmblem"));
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("ClericEmblem"));
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("BardEmblem"));
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("NinjaEmblem"));
			}
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}