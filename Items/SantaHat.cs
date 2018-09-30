using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class SantaHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Santa NK1's Hat");
			Tooltip.SetDefault("Summons Santa NK1\nWill run away if it BECOMES day");
		}
		public override void SetDefaults()
		{
			item.width = 72;
			item.height = 38;
			item.maxStack = 20;
			item.value = 26000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.SantaNK1);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}