using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class PirateWeaponry : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pirate Loot");
			Tooltip.SetDefault("Currently Does Nothing");
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
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GreedyRing, 1);
			recipe.AddIngredient(ItemID.CoinGun, 1);
			recipe.AddIngredient(ItemID.PirateStaff, 1);
			recipe.AddIngredient(ItemID.Cutlass, 1);
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}