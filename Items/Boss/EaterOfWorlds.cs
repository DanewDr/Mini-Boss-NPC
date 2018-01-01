using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class EaterOfWorlds : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eater Of Worlds");
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
			recipe.AddIngredient(ItemID.EatersBone, 1);
			recipe.AddIngredient(ItemID.ShadowScale, 10);
			recipe.AddIngredient(ItemID.DemoniteOre, 10);
			recipe.AddIngredient(ItemID.EaterMask, 1);
			recipe.AddIngredient(ItemID.WormScarf);
			recipe.AddIngredient(ItemID.EaterofWorldsTrophy);
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("EoWSpear"), 1);
			}
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}