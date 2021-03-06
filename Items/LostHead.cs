using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class LostHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lost Head");
			Tooltip.SetDefault("Summons a Lost Girl");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 26;
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
			NPC.NewNPC((int)player.Center.X - 500, (int)player.Center.Y, NPCID.LostGirl);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}