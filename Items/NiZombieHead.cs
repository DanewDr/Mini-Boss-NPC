using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class NiZombieHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zombie Head");
			Tooltip.SetDefault("Summons a Zombie Brute");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 24;
			item.maxStack = 20;
			item.value = 11000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			Mod trueEater = ModLoader.GetMod("TrueEater");
			if (trueEater != null)
			{
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, trueEater.NPCType("BigZombie"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}