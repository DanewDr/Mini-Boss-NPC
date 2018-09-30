using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class ShadowflameBattleStandard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadowflame Battle Standard");
			Tooltip.SetDefault("Summons a Goblin Summoner" + Environment.NewLine + "Can only be used during a Goblin Invasion");
		}
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 20;
			item.value = 40000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.GoblinSummoner);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}