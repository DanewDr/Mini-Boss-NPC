using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class EyeOfCthulhu : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eye Of Cthulhu");
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
			recipe.AddIngredient(ItemID.CorruptSeeds, 2);
			recipe.AddIngredient(ItemID.Binoculars, 1);
			recipe.AddIngredient(ItemID.UnholyArrow, 10);
			recipe.AddIngredient(ItemID.DemoniteOre, 10);
			recipe.AddIngredient(ItemID.EyeMask, 1);
			recipe.AddIngredient(ItemID.EoCShield);
			recipe.AddIngredient(ItemID.EyeofCthulhuTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("MonsterTooth"), 1);
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("EyeMonolith"), 1);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("Eyeshot"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("DemonLense"), 1);
			}
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}