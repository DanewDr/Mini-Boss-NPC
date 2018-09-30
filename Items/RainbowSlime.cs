using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class RainbowSlime : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rainbow Gel");
			Tooltip.SetDefault("Summons a Rainbow Slime");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 5));			
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 14;
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
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.RainbowSlime);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;	
		}
	}
}