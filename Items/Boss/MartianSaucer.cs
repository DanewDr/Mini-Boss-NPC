using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class MartianSaucer : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Martian Saucer");
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
			recipe.AddIngredient(ItemID.LaserMachinegun, 1);
			recipe.AddIngredient(ItemID.ElectrosphereLauncher, 1);
			recipe.AddIngredient(ItemID.Xenopopper, 1);
			recipe.AddIngredient(null, "UFO");
			recipe.AddIngredient(ItemID.LaserDrill, 1);
			recipe.AddIngredient(ItemID.AntiGravityHook);
			recipe.AddIngredient(ItemID.InfluxWaver);
			recipe.AddIngredient(ItemID.ChargedBlasterCannon);
			recipe.AddIngredient(ItemID.MartianSaucerTrophy);
			if (MiniBossNPC.Tremor != null)
/*			{
				recipe.AddIngredient(MiniBossNPC.Tremor.ItemType("MartianSprayer"), 1);
			}
			if (MiniBossNPC.Thorium != null)
			{
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("LivewireCrasher"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("MoleculeStabilizer"), 1);
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("Triangle"));
				recipe.AddIngredient(MiniBossNPC.Thorium.ItemType("SuperPlasmaCannon"));
			}
			if (MiniBossNPC.Calamity != null)
			{
				recipe.AddIngredient(MiniBossNPC.Calamity.ItemType("NullificationPistol"));				
			}
			recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}