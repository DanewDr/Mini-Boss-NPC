using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class KarateSkull : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Karate Skull");
			Tooltip.SetDefault("Summons Bone Lee\nWill try to run away if not in the dungeon");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 20;
			item.maxStack = 20;
			item.value = 25000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.BoneLee);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}
