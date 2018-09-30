using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class EterniaAccesories : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eternia Accesories");
			Tooltip.SetDefault("Currently Does Nothing");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(15, 4));	
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 28;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
			item.expert = true;
        }
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ApprenticeScarf, 1);
			recipe.AddIngredient(ItemID.SquireShield, 1);
			recipe.AddIngredient(ItemID.HuntressBuckler, 1);
			recipe.AddIngredient(ItemID.MonkBelt, 1);
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}