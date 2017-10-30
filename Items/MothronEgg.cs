using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class MothronEgg : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mothron Egg");
			Tooltip.SetDefault("Summons Mothron" + Environment.NewLine + "Can only be used during a Solar Eclipse");
		}
		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 42;
			item.maxStack = 20;
			item.value = 50000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Mothron);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}
