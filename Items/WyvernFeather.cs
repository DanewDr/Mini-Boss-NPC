using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class WyvernFeather : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wyvern Feather");
			Tooltip.SetDefault("Summons a Wyvern");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 68;
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
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.WyvernHead);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}