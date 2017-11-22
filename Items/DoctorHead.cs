using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniBossNPC.Items
{
	public class DoctorHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Doctor Head");
			Tooltip.SetDefault("Summons Doctor Bones\nWill try to run away during the day");
		}
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 28;
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
			NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, NPCID.DoctorBones);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}