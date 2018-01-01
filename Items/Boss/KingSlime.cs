using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class KingSlime : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("King Slime");
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
			recipe.AddIngredient(ItemID.SlimeHook, 1);
			recipe.AddIngredient(ItemID.KingSlimeMask, 1);
			recipe.AddIngredient(ItemID.KingSlimeTrophy, 1);
			recipe.AddIngredient(ItemID.RoyalGel, 1);
			recipe.AddIngredient(ItemID.SlimySaddle, 1);
			recipe.AddIngredient(ItemID.SlimeStaff, 1);
			recipe.AddIngredient(ItemID.Solidifier);
			recipe.AddIngredient(ItemID.NinjaHood);
			recipe.AddIngredient(ItemID.NinjaShirt);
			recipe.AddIngredient(ItemID.NinjaPants);
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
