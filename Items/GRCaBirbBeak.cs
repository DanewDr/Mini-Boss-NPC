using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MiniBossNPC.Items
{
	public class GRCaBirbBeak : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bumblebirb Beak");
			Tooltip.SetDefault("Summons a Bumblebirb Rider");
		}
		public override void SetDefaults()
		{
			item.width = 42;
			item.height = 16;
			item.maxStack = 20;
			item.value = 840000;
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
				NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, gRealm.NPCType("BumblebirbRider"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}