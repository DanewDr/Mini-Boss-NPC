using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class SalHead6 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Salamander Head");
			Tooltip.SetDefault("Summons a Salamander");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.maxStack = 20;
			item.value = 20000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.Salamander6);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}