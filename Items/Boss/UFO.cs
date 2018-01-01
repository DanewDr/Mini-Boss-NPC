using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items.Boss
{
	public class UFO : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("UFO");
			Tooltip.SetDefault("");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(15, 4));			
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 32;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
			item.expert = true;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.XenoStaff, 1);
			recipe.AddIngredient(ItemID.CosmicCarKey, 1);
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}