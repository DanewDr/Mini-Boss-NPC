using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class FlyingDutchman : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flying Dutchman");
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
			recipe.AddIngredient(null, "PirateWeaponry");
			recipe.AddIngredient(ItemID.FlyingDutchmanTrophy);
			if (MiniBossNPC.Tremor != null)
			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("HandCannon"), 1);
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("PirateFlag"), 1);
				recipe.AddIngredient(ItemID.CactusSink, 1);
			}
			if (MiniBossNPC.Spirit != null)
			{
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("CaptainsRegards"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("SoulSiphon"), 1);
				recipe.AddIngredient(MiniBossNPC.Spirit.ItemType("PirateCrate"), 1);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("CannonBall"), 15);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("HandCannon"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("Tuba"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("ShipsHelm"));
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("TheJuggernaut"));
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("GreedyMagnet"));
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}