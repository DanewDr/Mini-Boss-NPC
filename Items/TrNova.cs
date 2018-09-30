using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class TrNova : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nova Idol");
			Tooltip.SetDefault("Summons an Nova\nWARNING: SUMMONS MOON LORD ON DEATH");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 30;
			item.maxStack = 20;
			item.value = 20000;
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
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, tremor.NPCType("NovaPillar"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}