using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent;
using Terraria.IO;
using Terraria.ObjectData;
using Terraria.Utilities;
using Terraria.ModLoader;
 
namespace MiniBossNPC.Items.Boss
{
    public class KingSlime : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("King Slime");
			Tooltip.SetDefault("+20% throwing damage\n+20% throwing velocity\n+15% throwing crit chance\n+1 max minions\nIncreased jump height\nImmunity to the slimed debuff\nInflict slimed on enemy hits\nAll slimes become friendly");
		}
        public override void SetDefaults()
        {		
//			item.damage = 20;		
            item.width = 20;
            item.height = 20;			
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
//			item.knockBack = 2f;			
			item.expert = true;
			item.accessory = true;
//	        item.autoReuse = true;		
			item.shoot = ProjectileID.BabySlime;
            item.buffType =	BuffID.BabySlime;
        }
        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
//			player.slime = true;
//			player.AddBuff(BuffID.BabySlime, 2);
			player.maxMinions += 1;
			player.buffImmune[137] = true;
			player.thrownDamage += 0.2f;
			player.thrownCrit += 15;
			player.jumpBoost = true;
			player.thrownVelocity += 0.2f;
			MiniBossPlayer.kingSlime = true;
			player.npcTypeNoAggro[1] = true;
			player.npcTypeNoAggro[16] = true;
			player.npcTypeNoAggro[59] = true;
			player.npcTypeNoAggro[71] = true;
			player.npcTypeNoAggro[81] = true;
			player.npcTypeNoAggro[121] = true;
			player.npcTypeNoAggro[122] = true;
			player.npcTypeNoAggro[138] = true;			
			player.npcTypeNoAggro[147] = true;
			player.npcTypeNoAggro[183] = true;
			player.npcTypeNoAggro[184] = true;			
			player.npcTypeNoAggro[187] = true;
			player.npcTypeNoAggro[204] = true;
			player.npcTypeNoAggro[225] = true;			
			player.npcTypeNoAggro[244] = true;
			player.npcTypeNoAggro[302] = true;			
			player.npcTypeNoAggro[304] = true;
			player.npcTypeNoAggro[333] = true;
			player.npcTypeNoAggro[334] = true;
			player.npcTypeNoAggro[335] = true;
			player.npcTypeNoAggro[336] = true;			
			player.npcTypeNoAggro[535] = true;
			player.npcTypeNoAggro[537] = true;			
		}		
/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlimeHook, 1);
			recipe.AddIngredient(ItemID.KingSlimeMask, 1);
			recipe.AddIngredient(ItemID.KingSlimeTrophy, 1);
			recipe.AddIngredient(ItemID.RoyalGel, 1);
			recipe.AddIngredient(ItemID.SlimySaddle, 1);
			recipe.AddIngredient(ItemID.SlimeGun);
			recipe.AddIngredient(ItemID.SlimeStaff, 1);
			recipe.AddIngredient(ItemID.Solidifier);
			recipe.AddIngredient(ItemID.NinjaHood);
			recipe.AddIngredient(ItemID.NinjaShirt);
			recipe.AddIngredient(ItemID.NinjaPants);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddTile(TileID.DemonAltar);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
    }
}
