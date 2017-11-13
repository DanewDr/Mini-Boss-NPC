using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class Skully : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dungeon Skull");
			Tooltip.SetDefault("Summons a Dungeon Guardian");
		}
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 16;
			item.maxStack = 20;
			item.value = 1000000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.DungeonGuardian);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}