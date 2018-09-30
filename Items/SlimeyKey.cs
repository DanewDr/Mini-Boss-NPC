using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class SlimeyKey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy Key");
			Tooltip.SetDefault("Summons a Dungeon Slime");
		}
		public override void SetDefaults()
		{
			item.width = 44;
			item.height = 30;
			item.maxStack = 20;
			item.value = 3000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.DungeonSlime);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}