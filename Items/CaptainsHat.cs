using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class CaptainsHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Captain's Hat");
			Tooltip.SetDefault("Summons the Pirate Captain\nWill try to run away if SPAWNED during the day");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 16;
			item.maxStack = 20;
			item.value = 140000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.PirateCaptain);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}