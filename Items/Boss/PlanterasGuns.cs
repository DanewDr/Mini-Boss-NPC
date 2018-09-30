using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items.Boss
{
	public class PlanterasGuns : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plantera's Guns");
			Tooltip.SetDefault("Currently Does Nothing");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(15, 4));			
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
			item.expert = true;
        }
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaspGun, 1);
			recipe.AddIngredient(ItemID.LeafBlower, 1);
			recipe.AddIngredient(ItemID.VenusMagnum, 1);
			recipe.AddIngredient(ItemID.GrenadeLauncher, 1);
			recipe.AddIngredient(ItemID.RocketI, 20);
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}