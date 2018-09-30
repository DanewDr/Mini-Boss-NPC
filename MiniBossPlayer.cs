using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;

namespace MiniBossNPC
{
	public class MiniBossPlayer : ModPlayer
	{
		public static bool kingSlime = false;
		public static bool eoC = false;
		
		public override void ResetEffects()
		{
			kingSlime = false;
			eoC = false;
		}			

		public override void UpdateDead()
		{
			kingSlime = false;
			eoC = false;
		}
		
		public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
		{
			if (kingSlime)
			{
				if (Main.rand.Next(4) == 0)
				{
					target.AddBuff(BuffID.Slimed, 360, false);
				}
				else if (Main.rand.Next(2) == 0)
				{
					target.AddBuff(BuffID.Slimed, 240, false);
				}
				else
				{
					target.AddBuff(BuffID.Slimed, 120, false);
				}	
			}
			if (MiniBossNPC.Calamity != null)
			{
				if (eoC)
				{
					if (Main.rand.Next(4) == 0)
					{
						target.AddBuff(BuffID.Wet, 360, false);
					}
					else if (Main.rand.Next(2) == 0)
					{
						target.AddBuff(BuffID.Wet, 240, false);
					}
					else
					{
						target.AddBuff(BuffID.Wet, 120, false);
					}
				}					
			}
		}
		public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
		{
			if (eoC)
			{
				Projectile.NewProjectile(player.Center.X, player.Center.Y, 6 - Main.rand.Next(12), 6 - Main.rand.Next(12), mod.ProjectileType("Eye"), 16, 3f, player.whoAmI);
				Projectile.NewProjectile(player.Center.X, player.Center.Y, 6 - Main.rand.Next(12), 6 - Main.rand.Next(12), mod.ProjectileType("Eye"), 16, 3f, player.whoAmI);
				Projectile.NewProjectile(player.Center.X, player.Center.Y, 6 - Main.rand.Next(12), 6 - Main.rand.Next(12), mod.ProjectileType("Eye"), 16, 3f, player.whoAmI);
			}
		}
	}
}	