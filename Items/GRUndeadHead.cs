using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class GRUndeadHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Undeadipede Head");
			Tooltip.SetDefault("Summons a Undeadipede");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 20;
			item.value = 240000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			Mod gRealm = ModLoader.GetMod("GRealm");
			if (gRealm != null)
			{
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, gRealm.NPCType("UndeadipedeHead"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}