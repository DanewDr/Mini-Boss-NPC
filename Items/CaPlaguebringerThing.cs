using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class CaPlaguebringerThing : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plaguebringer Antenna");
			Tooltip.SetDefault("Summons a Plaguebringer");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 16;
			item.maxStack = 20;
			item.value = 6000;
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
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, calamityMod.NPCType("PlaguebringerShade"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}