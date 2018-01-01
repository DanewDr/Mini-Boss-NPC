using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class Punpking : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pumpking");
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
			recipe.AddIngredient(ItemID.TheHorsemansBlade, 1);
			recipe.AddIngredient(ItemID.BatScepter, 1);
			recipe.AddIngredient(ItemID.BlackFairyDust, 1);
			recipe.AddIngredient(ItemID.SpiderEgg, 1);
			recipe.AddIngredient(ItemID.RavenStaff, 1);
			recipe.AddIngredient(ItemID.CandyCornRifle, 1);
			recipe.AddIngredient(ItemID.CandyCorn, 45);
			recipe.AddIngredient(ItemID.JackOLanternLauncher);
			recipe.AddIngredient(ItemID.ExplosiveJackOLantern);
			recipe.AddIngredient(ItemID.PumpkingTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("PumpkingMask"), 1);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("SnackLantern"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("PumpkinSickle"), 1);			
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}