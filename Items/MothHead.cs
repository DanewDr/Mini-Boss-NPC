using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class MothHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MothHead");
			Tooltip.SetDefault("Summons a Moth");
		}
		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 24;
			item.maxStack = 20;
			item.value = 16000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.Moth);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}