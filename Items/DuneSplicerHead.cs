using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class DuneSplicerHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dune Splicer Head");
			Tooltip.SetDefault("Summons a Dune Splicer");
		}
		public override void SetDefaults()
		{
			item.width = 50;
			item.height = 50;
			item.maxStack = 20;
			item.value = 1;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.DuneSplicerHead);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}