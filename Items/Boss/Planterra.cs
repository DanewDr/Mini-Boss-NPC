using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class Planterra : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plantera");
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
			recipe.AddIngredient(ItemID.PygmyStaff, 1);
			recipe.AddIngredient(ItemID.TempleKey, 1);
			recipe.AddIngredient(ItemID.FlowerPow, 1);
			recipe.AddIngredient(ItemID.ThornHook, 1);			
			recipe.AddIngredient(ItemID.PlanteraMask, 1);
			recipe.AddIngredient(ItemID.SporeSac);
			recipe.AddIngredient(ItemID.PlanteraTrophy);
			recipe.AddIngredient(ItemID.TheAxe);
			recipe.AddIngredient(null, "PlanterasGuns");
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("EssenseofJungle"), 2);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("PlanteraBloom"), 1);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("BloomWeave"), 1);
				recipe.AddIngredient(null, "Vuvuzela", 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("VerdantOrnament"), 1);			
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}