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
			item.width = 42;
			item.height = 48;
			item.maxStack = 20;
			item.value = 50000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.DungeonGuardian);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}