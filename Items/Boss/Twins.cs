using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class Twins : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Twins");
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
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.SoulofSight, 10);
			recipe.AddIngredient(ItemID.TwinMask, 1);
			recipe.AddIngredient(ItemID.MechanicalWheelPiece);
			recipe.AddIngredient(ItemID.RetinazerTrophy);
			recipe.AddIngredient(ItemID.SpazmatismTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("MechaSrayer"), 1);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("BlueprintTwins"), 2);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("StrangePlating"), 5);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("LifeCells"), 5);
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}