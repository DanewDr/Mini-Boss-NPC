using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class BeeCostume : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bee Costume");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 55;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
			item.expert = true;
        }
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeHat);
			recipe.AddIngredient(ItemID.BeeShirt);
			recipe.AddIngredient(ItemID.BeePants);
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}