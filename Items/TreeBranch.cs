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
			Tooltip.SetDefault("Summons an Everscream");
		}
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 16;
			item.maxStack = 20;
			item.value = 70000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Everscream);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}