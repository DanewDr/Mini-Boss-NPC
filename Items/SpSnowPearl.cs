using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class SpSnowPearl : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Snow Pearl");
			Tooltip.SetDefault("Summons a Snow Monger");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 20;
			item.value = 27000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			Mod spiritMod = ModLoader.GetMod("SpiritMod");
			if (spiritMod != null)
			{
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, spiritMod.NPCType("FrostSaucer"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}