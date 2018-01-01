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
			DisplayName.SetDefault("Undead, Sideways Head");
			Tooltip.SetDefault("Summons a Undeadipede");
		}
		public override void SetDefaults()
		{
			item.width = 58;
			item.height = 44;
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
			Mod gRealm = ModLoader.GetMod("GRealm");
			if (gRealm != null)
			{
				NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, gRealm.NPCType("UndeadipedeHead"));
				Main.PlaySound(SoundID.Roar, player.position, 0);
				return true;
			}
			return false;
		}
	}
}