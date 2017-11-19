using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.GameContent.Events;

namespace MiniBossNPC.NPCs
{
	[AutoloadHead]
	public class RareCreature : ModNPC
	{
		public override string Texture
		{
			get
			{
				return "MiniBossNPC/NPCs/RareCreature";
			}
		}

		public override string[] AltTextures
		{
			get
			{
				return new string[] { "MiniBossNPC/NPCs/RareCreature_Alt_1" };
			}
		}

		public override bool Autoload(ref string name)
		{
			name = "Rare Creature Collecter";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rare Creature Collecter");
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.DyeTrader;
		}

        public override bool CanTownNPCSpawn(int numTownNPCs, int money) //Whether or not the conditions have been met for this town NPC to be able to move into town.
        {
            if (NPC.downedBoss1)  //so after the EoC is killed
            {
                return true;
            }
            return false;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)    //Allows you to define special conditions required for this town NPC's house
        {
            return true;  //so when a house is available the npc will  spawn
        }

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(3))
			{
				case 0:
					return "Taneleer Tivan";
				case 1:
					return "Benicio del Toro";
				case 2:
					return "Grevious";
				default:
					return "Totally not recoloured Dye Trader";
			}
		}

		public override void FindFrame(int frameHeight)
		{
			/*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
		}

		public override string GetChat()
		{
			int dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
			if (dyeTrader >= 0 && Main.rand.Next(7) == 0)
			{
				return "Me and " + Main.npc[dyeTrader].GivenName + " look pretty simular, don't you think?";
			}
			int witchDoctor = NPC.FindFirstNPC(NPCID.WitchDoctor);
			if (witchDoctor >= 0 && Main.rand.Next (7) == 0)
			{
				return "That " + Main.npc[witchDoctor].GivenName + " would make a fine addition to my collection.";
			}		
			switch (Main.rand.Next(6))
			{
				case 0:
					return "Over the eons I've collected many millions of rare creatures. The things I sell to you are just duplicates.";
				case 1:
					return "I really need to gt rid of these things they're breeding like crazy!";
				case 2:
					return "You know, I would like to have some of those golden critters... wait, you're not going to give them to me? Suite yourself.";
				case 3:
					return "You know, that Cthulhu I keep hearing about would make a fine addition to my collection.";
				case 4:
					return "Hello There.";
				default:
					return "I bring you only the rarest creature from the lands of Terraria. Only creatures from Terraria.";	
			}
		}



		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28].Value;
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("CrabClaw"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("CrabClaw2"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("GiantShell"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("GiantShell2"));
			nextSlot++;				
			shop.item[nextSlot].SetDefaults(mod.ItemType("SalHead"));
			nextSlot++;	
			shop.item[nextSlot].SetDefaults(mod.ItemType("SalHead2"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("SalHead3"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("SalHead4"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("SalHead5"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("SalHead6"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("SalHead7"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("SalHead8"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("SalHead9"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Pinky"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("BrideHead"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("GroomHead"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("DoctorHead"));
			nextSlot++;
			if (NPC.downedGoblins)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("GoblinHead"));
				nextSlot++;	
			}
			if (NPC.downedBoss3)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("SlimeyKey"));
				nextSlot++;	
			}	
			if (Main.hardMode)
			{	
				shop.item[nextSlot].SetDefaults(mod.ItemType("LostHead"));
				nextSlot++;	
				shop.item[nextSlot].SetDefaults(mod.ItemType("NymphHead"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("TimSkull"));
				nextSlot++;	
				shop.item[nextSlot].SetDefaults(mod.ItemType("RainbowSlime"));
				nextSlot++;	
				shop.item[nextSlot].SetDefaults(mod.ItemType("MimicCharm"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("MothHead"));
				nextSlot++;	
			}				
			if (NPC.downedPlantBoss)
			{	
				shop.item[nextSlot].SetDefaults(mod.ItemType("RuneSkull"));
				nextSlot++;		
				shop.item[nextSlot].SetDefaults(mod.ItemType("CommandoSkull"));
				nextSlot++;			
				shop.item[nextSlot].SetDefaults(mod.ItemType("TacticalSkull"));				
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("SniperSkull"));
				nextSlot++;					
			}	
		}	
		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 20;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 30;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = mod.ProjectileType("WizardThing");
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}
