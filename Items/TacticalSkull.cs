using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class TacticalSkull : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tactical Skull");
			Tooltip.SetDefault("Summons a Tactical Skeleton");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 22;
			item.maxStack = 20;
			item.value = 6000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.TacticalSkeleton);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}