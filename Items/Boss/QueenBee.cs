using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class QueenBee : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Queen Bee");
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
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("YellowPuzzleFragment"), 1);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("SweetThrow"), 1);
			}
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}