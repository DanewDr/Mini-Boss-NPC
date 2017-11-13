using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class PaladinPlate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Paladin Plate");
			Tooltip.SetDefault("Summons a Paladin" + Environment.NewLine + "Will try to run away if not in the dungeon");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 22;
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
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.Paladin);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}
