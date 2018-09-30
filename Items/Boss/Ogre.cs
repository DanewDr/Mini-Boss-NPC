using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class Ogre : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ogre");
			Tooltip.SetDefault("Currently Does Nothing");
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
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DefenderMedal, 7);
			recipe.AddIngredient(null, "EterniaAccesories");
			recipe.AddIngredient(ItemID.BossMaskOgre, 1);
			recipe.AddIngredient(ItemID.BookStaff);
			recipe.AddIngredient(ItemID.BossTrophyOgre);
			recipe.AddIngredient(ItemID.DD2PhoenixBow);
			recipe.AddIngredient(ItemID.DD2SquireDemonSword);
			recipe.AddIngredient(ItemID.MonkStaffT1);
			recipe.AddIngredient(ItemID.MonkStaffT2);
			recipe.AddIngredient(ItemID.DD2PetGhost);
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("GrogBlueprint"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("OgreSnotGun"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("SnotBall"), 10);
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}