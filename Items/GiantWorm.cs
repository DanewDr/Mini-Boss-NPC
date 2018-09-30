using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class GiantWorm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Giant Worm Head");
			Tooltip.SetDefault("Summons a Giant Worm");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 26;
			item.maxStack = 20;
			item.value = 60;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.GiantWormHead);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}