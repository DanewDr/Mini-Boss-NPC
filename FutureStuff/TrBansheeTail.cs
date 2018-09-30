using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.FutureStuff
{
	public class TrBansheeTail : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Banshee Tail");
			Tooltip.SetDefault("Summons a Banshee");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 48;
			item.maxStack = 20;
			item.value = 507;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if (tremor != null)
			{
				NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, tremor.NPCType("Banshee"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}