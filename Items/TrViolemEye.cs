using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class TrViolemEye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Violeum's Eye");
			Tooltip.SetDefault("Summons a Violeum");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 30;
			item.maxStack = 20;
			item.value = 120000;
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
				NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, tremor.NPCType("Violeum"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}