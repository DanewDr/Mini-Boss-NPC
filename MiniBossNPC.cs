using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace MiniBossNPC
{
	public class MiniBossNPC : Mod
	{
		public static Mod Instance;
		public static Mod Tremor;
		public static Mod Thorium;
		public static Mod Spirit;
		public static Mod calamityLoaded;

		public MiniBossNPC()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
		public override void PostSetupContent()
		{
			Tremor = ModLoader.GetMod("Tremor");
			Thorium = ModLoader.GetMod("ThoriumMod");
			Spirit = ModLoader.GetMod("SpiritMod");
			calamityLoaded = ModLoader.GetMod("CalamityMod");
		}		
	}
}
