using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class LunaticCultist : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunatic Cultist");
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
			recipe.AddIngredient(ItemID.BossMaskCultist, 1);
			recipe.AddIngredient(ItemID.AncientCultistTrophy);

			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("NebulaEmblem"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("SolarEmblem"));
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("Ancient"));
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("StardustEmblem"));
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("VortexEmblem"));
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("AncientLight"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("AncientFlame"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("AncientSpark"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("AncientFrost"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("LunaticPrimeHood"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("LunaticPrimeRobe"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("LunaticPrimePants"), 1);
			}
			recipe.AddTile(TileID.LunarCraftingStation);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}