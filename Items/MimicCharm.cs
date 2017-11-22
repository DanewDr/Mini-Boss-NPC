using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class MimicCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mimic Charm");
			Tooltip.SetDefault("Summons a Mimic\nSpawns a different Mimic depending on where you are");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(15, 4));			
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 44;
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
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.Mimic);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;	
		}
	}
}