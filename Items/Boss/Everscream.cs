using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class Everscream : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Everscream");
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
			recipe.AddIngredient(ItemID.FestiveWings, 1);
			recipe.AddIngredient(ItemID.ChristmasTreeSword, 1);
			recipe.AddIngredient(ItemID.ChristmasHook, 1);
			recipe.AddIngredient(ItemID.Razorpine, 1);
			recipe.AddIngredient(ItemID.EverscreamTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("EverscreamMask"), 1);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("ChristmasCheer"), 1);		
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}