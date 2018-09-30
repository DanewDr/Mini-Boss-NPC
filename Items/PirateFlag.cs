using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class PirateFlag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pirate Flag");
			Tooltip.SetDefault("Summons the Flying Dutchman");
		}
		public override void SetDefaults()
		{
			item.width = 46;
			item.height = 66;
			item.maxStack = 20;
			item.value = 2500;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.PirateShip);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}