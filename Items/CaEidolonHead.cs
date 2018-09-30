using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class CaEidolonHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adult Eidolon Head");
			Tooltip.SetDefault("Summons an Adult Eidolon Wyrm");
		}
		public override void SetDefaults()
		{
			item.width = 182;
			item.height = 90;
			item.maxStack = 20;
			item.value = 27000000;
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
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, calamityMod.NPCType("EidolonWyrmHeadHuge"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}