using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class IceGem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Gem");
			Tooltip.SetDefault("Summons the Ice Queen\nWill run away during the day");
		}
		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 20;
			item.maxStack = 20;
			item.value = 100000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.IceQueen);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}