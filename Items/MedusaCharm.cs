using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class MedusaCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Medusa Charm");
			Tooltip.SetDefault("Summons a Medusa\nWill try to run away during the day");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
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
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.Medusa);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}