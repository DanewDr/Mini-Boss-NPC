using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss

{
    public class MoonLord : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moon Lord");
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
			recipe.AddIngredient(ItemID.Terrarian, 1);
			recipe.AddIngredient(ItemID.FireworksLauncher, 1);
			recipe.AddIngredient(ItemID.LastPrism, 1);
			recipe.AddIngredient(ItemID.SDMG, 1);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.LunarFlareBook, 1);
			recipe.AddIngredient(ItemID.MoonlordTurretStaff);
			recipe.AddIngredient(ItemID.RainbowCrystalStaff);		
			recipe.AddIngredient(ItemID.BossMaskMoonlord, 1);
			recipe.AddIngredient(ItemID.MoonLordTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("MultidimensionalFragment"), 2);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("AccursedRelic"), 1);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("LifeAndDeath"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("SonicAmplifier"), 1);			
			}
			recipe.AddTile(TileID.LunarCraftingStation);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}