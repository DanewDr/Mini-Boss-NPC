using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class SpBabyRlyheian : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Baby R'lyheian");
			Tooltip.SetDefault("Summons a R'lyheian");
		}
		public override void SetDefaults()
		{
			item.width = 46;
			item.height = 34;
			item.maxStack = 20;
			item.value = 30000;
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
				NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, spiritMod.NPCType("Rylheian"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}