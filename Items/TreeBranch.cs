using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class TreeBranch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tree Branch");
			Tooltip.SetDefault("Summons an Everscream\nWill run away if it BECOMES day");
		}
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 16;
			item.maxStack = 20;
			item.value = 28000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.Everscream);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}