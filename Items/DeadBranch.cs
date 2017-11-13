using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class DeadBranch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dead Branch");
			Tooltip.SetDefault("Summons a Mourning Wood\nWill run away if it BECOMES day");
		}
		public override void SetDefaults()
		{
			item.width = 51;
			item.height = 28;
			item.maxStack = 20;
			item.value = 60000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.MourningWood);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}