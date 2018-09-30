using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class Destroyer : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Destroyer");
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
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.DestroyerMask, 1);
			recipe.AddIngredient(ItemID.MechanicalWagonPiece);
			recipe.AddIngredient(ItemID.DestroyerTrophy);
			if (MiniBossNPC.Tremor != null)
/*			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("Destructor"), 1);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("PrintProbe"), 2);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("StrangePlating"), 5);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("LifeCell"), 5);
			}
			if (MiniBossNPC.Calamity != null)
			{
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge21"));
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("Knowledge20"));				
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}