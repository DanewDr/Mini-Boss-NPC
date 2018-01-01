using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class Golem : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golem");
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
			recipe.AddIngredient(ItemID.StyngerBolt, 25);
			recipe.AddIngredient(ItemID.Stynger, 1);
			recipe.AddIngredient(ItemID.HeatRay, 1);
			recipe.AddIngredient(ItemID.Picksaw, 1);
			recipe.AddIngredient(ItemID.SunStone, 1);
			recipe.AddIngredient(ItemID.EyeoftheGolem, 1);
			recipe.AddIngredient(ItemID.PossessedHatchet, 1);
			recipe.AddIngredient(ItemID.BeetleHusk, 15);
			recipe.AddIngredient(ItemID.GolemFist, 2);
			recipe.AddIngredient(ItemID.StaffofEarth);
			recipe.AddIngredient(ItemID.GolemMask, 1);
			recipe.AddIngredient(ItemID.ShinyStone);
			recipe.AddIngredient(ItemID.GolemTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("GolemCore"), 1);
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}