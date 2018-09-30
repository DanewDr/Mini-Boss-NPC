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
    public class EyeOfCthulhu : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eye Of Cthulhu");
			Tooltip.SetDefault("Grants a Cthulhui dash\nGrants a scope (see rifle/sniper scope)\nHide accesory to disable\nImmunity to pre-harmode eyes\nReleases homing eyes when hit");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
			item.expert = true;
			item.accessory = true;			
        }
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.dash = 2;
            if (!hideVisual)
			{
				player.scope = true;
			}
			MiniBossPlayer.eoC = true;
			player.npcTypeNoAggro[2] = true;
			player.npcTypeNoAggro[5] = true;
			player.npcTypeNoAggro[190] = true;
			player.npcTypeNoAggro[191] = true;
			player.npcTypeNoAggro[192] = true;
			player.npcTypeNoAggro[193] = true;
			player.npcTypeNoAggro[194] = true;
			player.npcTypeNoAggro[317] = true;
			player.npcTypeNoAggro[318] = true;				
		}		
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CorruptSeeds, 2);
			recipe.AddIngredient(ItemID.Binoculars, 1);
			recipe.AddIngredient(ItemID.UnholyArrow, 10);
			recipe.AddIngredient(ItemID.DemoniteOre, 10);
			recipe.AddIngredient(ItemID.EyeMask, 1);
			recipe.AddIngredient(ItemID.EoCShield);
			recipe.AddIngredient(ItemID.EyeofCthulhuTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("MonsterTooth"), 1);
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("EyeMonolith"), 1);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("Eyeshot"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("DemonLens"), 1);
			}
			if (MiniBossNPC.Calamity != null)
			{
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("TeardropCleaver"));				
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("VictoryShard"), 2);
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge3"));				
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge4"));								
			}
			recipe.AddTile(TileID.DemonAltar);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}