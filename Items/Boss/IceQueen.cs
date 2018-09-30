using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class IceQueen : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Queen");
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
			recipe.AddIngredient(ItemID.ReindeerBells, 1);
			recipe.AddIngredient(ItemID.BabyGrinchMischiefWhistle, 1);
			recipe.AddIngredient(ItemID.SnowmanCannon, 1);
			recipe.AddIngredient(ItemID.NorthPole, 1);
			recipe.AddIngredient(ItemID.BlizzardStaff, 1);
			recipe.AddIngredient(ItemID.IceQueenTrophy);
/*			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("IceQueenMask"), 1);
			}
			if (MiniBossNPC.Calamity != null)
			{
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("EndothermicEnergy"), 30);				
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}