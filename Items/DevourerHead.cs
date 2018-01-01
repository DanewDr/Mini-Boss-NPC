using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class DevourerHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Devourer Head");
			Tooltip.SetDefault("Summons a Devourer");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 38;
			item.maxStack = 20;
			item.value = 20000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.DevourerHead);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}