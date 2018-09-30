using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class ClownBall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Clown Ball");
			Tooltip.SetDefault("Summons a Clown\nWill try to rin away during the day");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 42;
			item.maxStack = 40;
			item.value = 22000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.Clown);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}