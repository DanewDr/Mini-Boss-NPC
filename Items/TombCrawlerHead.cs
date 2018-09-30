using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class TombCrawlerHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tomb Crawler Head");
			Tooltip.SetDefault("Summons a Tomb Crawler");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 36;
			item.maxStack = 20;
			item.value = 6;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.TombCrawlerHead);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}