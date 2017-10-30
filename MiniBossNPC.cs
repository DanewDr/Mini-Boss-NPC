using Terraria.ModLoader;

namespace MiniBossNPC
{
	class MiniBossNPC : Mod
	{
		public MiniBossNPC()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
