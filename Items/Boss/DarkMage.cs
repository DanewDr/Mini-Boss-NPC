using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class DarkMage : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Mage");
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
			recipe.AddIngredient(ItemID.DefenderMedal, 4);
			recipe.AddIngredient(ItemID.WarTable, 1);
			recipe.AddIngredient(ItemID.WarTableBanner, 3);
			recipe.AddIngredient(ItemID.DD2PetDragon, 1);
			recipe.AddIngredient(ItemID.BossMaskDarkMage, 1);
			recipe.AddIngredient(ItemID.DD2PetGato, 1);
			recipe.AddIngredient(ItemID.BossTrophyDarkmage);
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("DarkMageStaff"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("DarkTome"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("TabooWand"), 1);
			}
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}