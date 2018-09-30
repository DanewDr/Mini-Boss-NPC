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
    public class QueenBee : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Queen Bee");
			Tooltip.SetDefault("Immunity to hornets and pre-hardmode jungle enemies");
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
//			player.beePack = true;
//			player.wasp = true;
			player.bee = true;
			player.adjHoney = true;
			player.maxMinions += 2;
			player.minionDamage += .23f;
			player.AddBuff(BuffID.Honey, 2);
			player.hornet = true;
			player.AddBuff(BuffID.BabyHornet, 2);
//			player.hornetMinion = true;
//			player.AddBuff(BuffID.HornetMinion, 2);
			player.npcTypeNoAggro[42] = true;
			player.npcTypeNoAggro[43] = true;
			player.npcTypeNoAggro[51] = true;
			player.npcTypeNoAggro[52] = true;
			player.npcTypeNoAggro[56] = true;
			player.npcTypeNoAggro[58] = true;
			player.npcTypeNoAggro[176] = true;
			player.npcTypeNoAggro[204] = true;
			player.npcTypeNoAggro[210] = true;
			player.npcTypeNoAggro[211] = true;
			player.npcTypeNoAggro[219] = true;
			player.npcTypeNoAggro[231] = true;
			player.npcTypeNoAggro[232] = true;
			player.npcTypeNoAggro[233] = true;
			player.npcTypeNoAggro[234] = true;
			player.npcTypeNoAggro[235] = true;
			player.npcTypeNoAggro[236] = true;
			player.npcTypeNoAggro[237] = true;
			player.npcTypeNoAggro[476] = true;
		}
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Beenade, 5);
			recipe.AddIngredient(ItemID.HiveWand, 1);
			recipe.AddIngredient(ItemID.HoneyComb, 1);
			recipe.AddIngredient(ItemID.BeeKeeper, 1);
			recipe.AddIngredient(ItemID.BeeMask, 1);
			recipe.AddIngredient(ItemID.HiveBackpack);
			recipe.AddIngredient(ItemID.QueenBeeTrophy);
			recipe.AddIngredient(ItemID.BeeGun);
			recipe.AddIngredient(ItemID.Nectar);
			recipe.AddIngredient(ItemID.BeesKnees);
			recipe.AddIngredient(ItemID.HoneyedGoggles);
			recipe.AddIngredient(ItemID.BeeWax, 15);
/*			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("YellowPuzzleFragment"), 1);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("SweetThrow"), 1);
			}
			if (MiniBossNPC.Calamity != null)
			{
//				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge16"));				
			}
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}