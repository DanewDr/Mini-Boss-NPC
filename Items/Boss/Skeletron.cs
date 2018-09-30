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
    public class Skeletron : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skeletron");
			Tooltip.SetDefault("Imunnity to pre-hardmode skeletons and dungeon enemies");
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
			player.boneArmor = true;
			player.rangedDamage += .15f;
			player.npcTypeNoAggro[21] = true;
			player.npcTypeNoAggro[31] = true;
			player.npcTypeNoAggro[32] = true;
			player.npcTypeNoAggro[33] = true;
			player.npcTypeNoAggro[34] = true;
			player.npcTypeNoAggro[39] = true;
			player.npcTypeNoAggro[44] = true;
			player.npcTypeNoAggro[45] = true;
			player.npcTypeNoAggro[68] = true;
			player.npcTypeNoAggro[70] = true;
			player.npcTypeNoAggro[71] = true;
			player.npcTypeNoAggro[72] = true;
			player.npcTypeNoAggro[201] = true;
			player.npcTypeNoAggro[202] = true;
			player.npcTypeNoAggro[203] = true;
/*			player.npcTypeNoAggro[269] = true;
			player.npcTypeNoAggro[270] = true;
			player.npcTypeNoAggro[271] = true;
			player.npcTypeNoAggro[272] = true;
			player.npcTypeNoAggro[273] = true;
			player.npcTypeNoAggro[274] = true;
			player.npcTypeNoAggro[275] = true;
			player.npcTypeNoAggro[276] = true;
			player.npcTypeNoAggro[277] = true;
			player.npcTypeNoAggro[278] = true;
			player.npcTypeNoAggro[279] = true;
			player.npcTypeNoAggro[280] = true;
			player.npcTypeNoAggro[281] = true;
			player.npcTypeNoAggro[282] = true;
			player.npcTypeNoAggro[283] = true;
			player.npcTypeNoAggro[284] = true;
			player.npcTypeNoAggro[285] = true;
			player.npcTypeNoAggro[286] = true;
			player.npcTypeNoAggro[287] = true;
			player.npcTypeNoAggro[288] = true;
			player.npcTypeNoAggro[289] = true;
			player.npcTypeNoAggro[290] = true;
			player.npcTypeNoAggro[291] = true;
			player.npcTypeNoAggro[292] = true;
			player.npcTypeNoAggro[293] = true;*/
			player.npcTypeNoAggro[294] = true;
			player.npcTypeNoAggro[295] = true;
			player.npcTypeNoAggro[296] = true;
		}
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SkeletronHand, 1);
			recipe.AddIngredient(ItemID.BookofSkulls, 1);
			recipe.AddIngredient(ItemID.SkeletronMask, 1);
			recipe.AddIngredient(ItemID.BoneGlove);
			recipe.AddIngredient(ItemID.SkeletronTrophy);
/*			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("TearsofDeath"), 3);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("CursedSkull"), 3);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("Bone"), 1);
			}
			if (MiniBossNPC.Calamity != null)
			{
//				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge17"));				
			}
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}