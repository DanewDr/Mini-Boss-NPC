using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.FutureStuff
{
	public class TrDarkDruidSkull : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Druid Skull");
			Tooltip.SetDefault("Summons a Dark Druid\nWill try to run away during the day");
		}
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 26;
			item.maxStack = 20;
			item.value = 2100;
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
				NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, tremor.NPCType("DarkDruid"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}