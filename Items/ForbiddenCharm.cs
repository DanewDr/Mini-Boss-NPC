using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class ForbiddenCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forbidden Charm");
			Tooltip.SetDefault("Summons a Sand Elemental");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 26;
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
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.SandElemental);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}