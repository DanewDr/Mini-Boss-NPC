using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class HallowedPigronWing : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Pigron Wing");
			Tooltip.SetDefault("Summons a Pink Pigron");
		}
		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 26;
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
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.PigronHallow);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}