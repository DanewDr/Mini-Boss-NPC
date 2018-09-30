using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class CrimsonAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson Axe");
			Tooltip.SetDefault("Summons a Crimson Axe");
		}
		public override void SetDefaults()
		{
			item.width = 62;
			item.height = 54;
			item.maxStack = 20;
			item.value = 4000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.CrimsonAxe);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}