using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class DukeFishron : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DukeFishron");
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
			recipe.AddIngredient(ItemID.Flairon, 1);
			recipe.AddIngredient(ItemID.TempestStaff, 1);
			recipe.AddIngredient(ItemID.FishronWings, 1);
			recipe.AddIngredient(ItemID.BubbleGun, 1);
			recipe.AddIngredient(ItemID.Tsunami, 1);		
			recipe.AddIngredient(ItemID.DukeFishronMask, 1);
			recipe.AddIngredient(ItemID.ShrimpyTruffle);
			recipe.AddIngredient(ItemID.DukeFishronTrophy);
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("Typhoon"), 1);
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}