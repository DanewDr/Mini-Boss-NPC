using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss

{
    public class LunarPortalGun : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Portal Gun");
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
			recipe.AddIngredient(ItemID.PortalGun, 1);
			recipe.AddIngredient(ItemID.LunarOre, 30);
			recipe.AddIngredient(ItemID.SuspiciousLookingTentacle, 1);			
			recipe.AddIngredient(ItemID.GravityGlobe);
			recipe.AddTile(TileID.LunarCraftingStation);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}