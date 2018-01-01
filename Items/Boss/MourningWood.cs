using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class MourningWood : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mourning Wood");
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
			recipe.AddIngredient(ItemID.SpookyWood, 100);
			recipe.AddIngredient(ItemID.CursedSapling, 1);
			recipe.AddIngredient(ItemID.SpookyTwig, 1);
			recipe.AddIngredient(ItemID.SpookyHook, 1);
			recipe.AddIngredient(ItemID.NecromanticScroll, 1);
			recipe.AddIngredient(ItemID.StakeLauncher, 1);
			recipe.AddIngredient(ItemID.Stake, 45);
			recipe.AddIngredient(ItemID.MourningWoodTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("MourningWoodMask"), 1);
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}