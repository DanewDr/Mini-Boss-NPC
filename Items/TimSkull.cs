using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class TimSkull : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tim Skull");
			Tooltip.SetDefault("Summons Tim");
		}
		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 32;
			item.maxStack = 20;
			item.value = 40000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.Tim);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}