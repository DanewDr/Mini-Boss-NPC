using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class SantaNK1 : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Santa-NK1");
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
			recipe.AddIngredient(ItemID.EldMelter, 1);
			recipe.AddIngredient(ItemID.ChainGun, 1);
			recipe.AddIngredient(ItemID.SantaNK1Trophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("SantaNK1Mask"), 1);
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("SpiK3Ball"), 25);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("Crumbler"), 1);
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}