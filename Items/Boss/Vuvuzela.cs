using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items.Boss
{
	public class Vuvuzela : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vuvuzela");
			Tooltip.SetDefault("Currently Does Nothing");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(15, 4));			
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
			item.expert = true;
        }
/*		public override void AddRecipes()
		{
			if (MiniBossNPC.Thorium != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("VuvuzelaYellow"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("VuvuzelaRed"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("VuvuzelaBlue"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("VuvuzelaGreen"), 1);	
				recipe.AddTile(TileID.Anvils);			
				recipe.SetResult(this);
				recipe.AddRecipe();
			}	
		}*/
    }
}