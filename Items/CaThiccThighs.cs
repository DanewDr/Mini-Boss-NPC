using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class CaThiccThighs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thicc Thighs");
			Tooltip.SetDefault("Summons a Cloud Elemental");
		}
		public override void SetDefaults()
		{
			item.width = 46;
			item.height = 42;
			item.maxStack = 20;
			item.value = 88000;
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
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, calamityMod.NPCType("ThiccWaifu"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}