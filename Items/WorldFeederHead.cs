using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class WorldFeederHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("World Feeder Head");
			Tooltip.SetDefault("Summons a World Feeder");
		}
		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 40;
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
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.SeekerHead);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}