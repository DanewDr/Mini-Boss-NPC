using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class Betsy : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Betsy");
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
			recipe.AddIngredient(ItemID.DefenderMedal, 30);
			recipe.AddIngredient(ItemID.DD2BetsyBow, 1);
			recipe.AddIngredient(ItemID.ApprenticeStaffT3, 1);
			recipe.AddIngredient(ItemID.BetsyWings, 1);
			recipe.AddIngredient(ItemID.DD2SquireBetsySword, 1);
			recipe.AddIngredient(ItemID.MonkStaffT3, 1);		
			recipe.AddIngredient(ItemID.BossMaskBetsy, 1);
			recipe.AddIngredient(ItemID.BossTrophyBetsy);
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("MediumRareSteak"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("DragonHeartWand"), 1);
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}