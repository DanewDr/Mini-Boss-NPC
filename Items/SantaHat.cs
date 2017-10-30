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
			Tooltip.SetDefault("Summons Santa NK1");
		}
		public override void SetDefaults()
		{
			item.width = 72;
			item.height = 38;
			item.maxStack = 20;
			item.value = 80000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.SantaNK1);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}