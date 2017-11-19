using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class SniperSkull : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sniper Skull");
			Tooltip.SetDefault("Summons a Skeleton Sniper");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 19;
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
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.SkeletonSniper);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}