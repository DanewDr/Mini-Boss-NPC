using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class WallOfFlesh : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wall Of Flesh");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
			item.expert = true;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LaserRifle, 1);
			recipe.AddIngredient(ItemID.FleshMask, 1);
			recipe.AddIngredient(ItemID.BreakerBlade);
			recipe.AddIngredient(ItemID.WallofFleshTrophy);
			recipe.AddIngredient(ItemID.ClockworkAssaultRifle);
			recipe.AddIngredient(ItemID.Pwnhammer);
			recipe.AddIngredient(null, "OmegaEmblem");
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("PieceofFlesh"), 10);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("FamineScepter"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("BallOfFlesh"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("WEye"));
			}
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}