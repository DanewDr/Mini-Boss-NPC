using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class CaYoungEidolonHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Juvenile Eidolon Head");
			Tooltip.SetDefault("Summons a Juvenile Eidolon Wyrm");
		}
		public override void SetDefaults()
		{
			item.width = 126;
			item.height = 84;
			item.maxStack = 20;
			item.value = 11000000;
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
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, calamityMod.NPCType("EidolonWyrmHead"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}