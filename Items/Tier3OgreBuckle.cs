using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class Tier3OgreBuckle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 3 Ogre's Buckle");
			Tooltip.SetDefault("Summons a Tier 3 Ogre");
		}
		public override void SetDefaults()
		{
			item.width = 54;
			item.height = 32;
			item.maxStack = 20;
			item.value = 134000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.DD2OgreT3);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}