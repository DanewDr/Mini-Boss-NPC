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
    public class WallOfFlesh : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wall Of Flesh");
			Tooltip.SetDefault("Immunity to underworld enemies");
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
			player.npcTypeNoAggro[24] = true;
			player.npcTypeNoAggro[25] = true;
			player.npcTypeNoAggro[39] = true;
			player.npcTypeNoAggro[59] = true;
			player.npcTypeNoAggro[60] = true;
			player.npcTypeNoAggro[62] = true;
			player.npcTypeNoAggro[66] = true;
			player.npcTypeNoAggro[115] = true;
			player.npcTypeNoAggro[116] = true;
			player.npcTypeNoAggro[117] = true;
			player.npcTypeNoAggro[151] = true;
			player.npcTypeNoAggro[156] = true;
		}
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LaserRifle, 1);
			recipe.AddIngredient(ItemID.FleshMask, 1);
			recipe.AddIngredient(ItemID.BreakerBlade);
			recipe.AddIngredient(ItemID.WallofFleshTrophy);
			recipe.AddIngredient(ItemID.ClockworkAssaultRifle);
			recipe.AddIngredient(ItemID.Pwnhammer);
			recipe.AddIngredient(null, "OmegaEmblem");
/*			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("PieceofFlesh"), 10);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("FamineScepter"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("BallOfFlesh"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("WEye"));
			}
			if (MiniBossNPC.Calamity != null)
			{
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("MLGRune"));				
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Meowthrower"));
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge7"));				
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge18"));				
			}				
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}