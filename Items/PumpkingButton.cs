using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class PumpkingButton : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pumpking's Button");
			Tooltip.SetDefault("Summons the Pumpking\nWill run away during the day");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 20;
			item.maxStack = 20;
			item.value = 90000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.Pumpking);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}