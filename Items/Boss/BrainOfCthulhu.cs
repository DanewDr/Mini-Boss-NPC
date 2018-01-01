using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class BrainOfCthulhu : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brain Of Cthulhu");
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
			recipe.AddIngredient(ItemID.BoneRattle, 1);
			recipe.AddIngredient(ItemID.TissueSample, 10);
			recipe.AddIngredient(ItemID.CrimtaneOre, 10);
			recipe.AddIngredient(ItemID.BrainMask, 1);
			recipe.AddIngredient(ItemID.BrainOfConfusion);
			recipe.AddIngredient(ItemID.BrainofCthulhuTrophy);
			recipe.AddTile(TileID.Anvils);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}