using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class CaReaperFin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reaper Fin");
			Tooltip.SetDefault("Summons a Reaper Shark");
		}
		public override void SetDefaults()
		{
			item.width = 58;
			item.height = 44;
			item.maxStack = 20;
			item.value = 1100000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			if (calamityMod != null)
			{
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, calamityMod.NPCType("Reaper"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}