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
    public class EaterOfWorlds : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eater Of Worlds");
			Tooltip.SetDefault("+20% melee speed\n+15% movement speed\n+17% damage reduction\n+75% mining speed\nImmunity to pre-hardmode worms and corruption enemies");
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
			player.meleeSpeed += 0.2f;
			player.moveSpeed += 0.15f;
			player.endurance += .17f;
			player.eater = true;
			player.AddBuff(BuffID.BabyEater, 2);
			player.pickSpeed =+ 1.5f;
			player.npcTypeNoAggro[6] = true;
			player.npcTypeNoAggro[7] = true;
			player.npcTypeNoAggro[10] = true;
			player.npcTypeNoAggro[39] = true;
			player.npcTypeNoAggro[47] = true;
			player.npcTypeNoAggro[57] = true;
			player.npcTypeNoAggro[79] = true;
			player.npcTypeNoAggro[81] = true;
			player.npcTypeNoAggro[83] = true;
			player.npcTypeNoAggro[94] = true;
			player.npcTypeNoAggro[101] = true;
			player.npcTypeNoAggro[112] = true;
			player.npcTypeNoAggro[117] = true;
			player.npcTypeNoAggro[121] = true;
			player.npcTypeNoAggro[168] = true;
			player.npcTypeNoAggro[170] = true;
			player.npcTypeNoAggro[473] = true;
			player.npcTypeNoAggro[513] = true;				
			player.npcTypeNoAggro[525] = true;
			player.npcTypeNoAggro[533] = true;
			player.npcTypeNoAggro[543] = true;
		}
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EatersBone, 1);
			recipe.AddIngredient(ItemID.ShadowScale, 10);
			recipe.AddIngredient(ItemID.DemoniteOre, 10);
			recipe.AddIngredient(ItemID.EaterMask, 1);
			recipe.AddIngredient(ItemID.WormScarf);
			recipe.AddIngredient(ItemID.EaterofWorldsTrophy);
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("EoWSpear"), 1);
			}
			if (MiniBossNPC.Calamity != null)
			{
//				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge9"));				
//				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge12"));				
			}
			recipe.AddTile(TileID.DemonAltar);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}