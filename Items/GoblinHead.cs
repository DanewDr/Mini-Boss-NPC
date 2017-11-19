using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class GoblinHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Goblin Head");
			Tooltip.SetDefault("Summons a Goblin Scout");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
			item.maxStack = 20;
			item.value = 10000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.GoblinScout);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}