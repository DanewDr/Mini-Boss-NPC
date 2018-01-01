using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class SkeletronPrime : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SkeletronPrime");
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
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddIngredient(ItemID.SkeletronPrimeMask, 1);
			recipe.AddIngredient(ItemID.MechanicalBatteryPiece);
			recipe.AddIngredient(ItemID.DestroyerTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("PrimeBlade"), 1);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("SkeleV"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("PrintPrime"), 2);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("StrangePlating"), 5);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("LifeCell"), 5);
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}