using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class MartianCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Martian Core");
			Tooltip.SetDefault("Summons a Martian Saucer");
		}
		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 36;
			item.maxStack = 20;
			item.value = 110000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.MartianSaucer);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}