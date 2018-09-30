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
    public class BrainOfCthulhu : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brain Of Cthulhu");
			Tooltip.SetDefault("lol\nImmunity to crimson enemies");
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
			player.crimsonRegen = true;
			player.brainOfConfusion = true;
			player.buffImmune[31] = true;
			player.AddBuff(BuffID.Spelunker, 2);
			player.AddBuff(BuffID.Hunter, 2);
			player.AddBuff(BuffID.Dangersense, 2);
			player.babyFaceMonster = true;
			player.AddBuff(BuffID.BabyFaceMonster, 2);
			player.npcTypeNoAggro[173] = true;
			player.npcTypeNoAggro[174] = true;
			player.npcTypeNoAggro[179] = true;
			player.npcTypeNoAggro[180] = true;
			player.npcTypeNoAggro[181] = true;
			player.npcTypeNoAggro[182] = true;
			player.npcTypeNoAggro[183] = true;
			player.npcTypeNoAggro[239] = true;
			player.npcTypeNoAggro[240] = true;
			player.npcTypeNoAggro[241] = true;
			player.npcTypeNoAggro[242] = true;
			player.npcTypeNoAggro[268] = true;
			player.npcTypeNoAggro[464] = true;
			player.npcTypeNoAggro[465] = true;
			player.npcTypeNoAggro[470] = true;
			player.npcTypeNoAggro[474] = true;
			player.npcTypeNoAggro[526] = true;
			player.npcTypeNoAggro[533] = true;
			player.npcTypeNoAggro[544] = true;
		}
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BoneRattle, 1);
			recipe.AddIngredient(ItemID.TissueSample, 10);
			recipe.AddIngredient(ItemID.CrimtaneOre, 10);
			recipe.AddIngredient(ItemID.BrainMask, 1);
			recipe.AddIngredient(ItemID.BrainOfConfusion);
			recipe.AddIngredient(ItemID.BrainofCthulhuTrophy);
			if (MiniBossNPC.Calamity != null)
			{
			//	recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge8"));				
			//	recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge11"));							
			}
			recipe.AddTile(TileID.DemonAltar);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}