using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class CyanBeetleHusk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cyan Beetle Husk");
			Tooltip.SetDefault("Summons a Cyan Beetle");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 12;
			item.maxStack = 20;
			item.value = 2200;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.CyanBeetle);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}