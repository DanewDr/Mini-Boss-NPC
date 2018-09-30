using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class BetsysClaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Betsy's Claw");
			Tooltip.SetDefault("Summons Betsy");
		}
		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 36;
			item.maxStack = 20;
			item.value = 440000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.DD2Betsy);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}