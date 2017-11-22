using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class CursedHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Hammer");
			Tooltip.SetDefault("Summons a Cursed Hammer");
		}
		public override void SetDefaults()
		{
			item.width = 72;
			item.height = 74;
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
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.CursedHammer);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}