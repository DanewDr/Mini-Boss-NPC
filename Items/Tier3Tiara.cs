using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class Tier3Tiara : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 3 Dark Mage's Tiara");
			Tooltip.SetDefault("Summons a Tier 3 Dark Mage");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 10;
			item.maxStack = 20;
			item.value = 88000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.DD2DarkMageT3);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}