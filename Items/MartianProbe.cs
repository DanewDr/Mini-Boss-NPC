using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class MartianProbe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Martian Probe");
			Tooltip.SetDefault("Summons a Martian Probe");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 34;
			item.maxStack = 20;
			item.value = 400000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.MartianProbe);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}