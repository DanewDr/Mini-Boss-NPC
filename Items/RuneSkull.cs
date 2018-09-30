using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class RuneSkull : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rune Skull");
			Tooltip.SetDefault("Summons a Rune Wizard");
		}
		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 32;
			item.maxStack = 20;
			item.value = 33000;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}		
		public override bool UseItem(Player player)
		{
			NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, NPCID.RuneWizard);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}