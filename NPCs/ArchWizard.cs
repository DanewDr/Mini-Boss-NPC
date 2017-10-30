using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.GameContent.Events;

namespace MiniBossNPC.NPCs
{
	[AutoloadHead]
	public class ArchWizard : ModNPC
	{
		public override string Texture
		{
			get
			{
				return "MiniBossNPC/NPCs/ArchWizard";
			}
		}

		public override string[] AltTextures
		{
			get
			{
				return new string[] { "MiniBossNPC/NPCs/ArchWizard_Alt_1" };
			}
		}

		public override bool Autoload(ref string name)
		{
			name = "Arch Wizard";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arch Wizard");
			Main.npcFrameCount[npc.type] = 23;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 3;
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
			animationType = NPCID.Wizard;
		}

        public override bool CanTownNPCSpawn(int numTownNPCs, int money) //Whether or not the conditions have been met for this town NPC to be able to move into town.
        {
            if (NPC.downedGoblins)  //so after the EoC is killed
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
			switch (WorldGen.genRand.Next(6))
			{
				case 0:
					return "Danew";
				case 1:
					return "Dan";
				case 2:
					return "Fred";
				case 3:
					return "Ograf";
				case 4:
					return "Falbert";
				default:
					return "Totally not recoloured Wizard";
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
			int stylist = NPC.FindFirstNPC(NPCID.Stylist);
			if (stylist >= 0 && Main.rand.Next(7) == 0)
			{
				return "You know, I should probably go to " + Main.npc[stylist].GivenName + " and get a haircut, but maybe not yet.";
			}
			int wizard = NPC.FindFirstNPC(NPCID.Wizard);
			if (wizard >= 0 && Main.rand.Next (7)) == 0)
			{
				return "That " + Main.npc[wizard].GivenName + "has got nothing an me";
			}		
			switch (Main.rand.Next(5))
			{
				case 0:
					return "I should probably get some new robes... nah";
				case 1:
					return "I don't need these keys, you can have them for free!";
				case 2:
					return "A wizard's staff has a nob on the end";
				case 3:
					return "My wizarding powers rival even Dumbledore!";
				default:
					return "What do you mean all I do is criticise myself?";	
			}
		}

		/* 
		// Consider using this alternate approach to choosing a random thing. Very useful for a variety of use cases.
		// The WeightedRandom class needs "using Terraria.Utilities;" to use
		public override string GetChat()
		{
			WeightedRandom<string> chat = new WeightedRandom<string>();

			int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			if (partyGirl >= 0 && Main.rand.Next(4) == 0)
			{
				chat.Add("Can you please tell " + Main.npc[partyGirl].GivenName + " to stop decorating my house with colors?");
			}
			chat.Add("Sometimes I feel like I'm different from everyone else here.");
			chat.Add("What's your favorite color? My favorite colors are white and black.");
			chat.Add("What? I don't have any arms or legs? Oh, don't be ridiculous!");
			chat.Add("This message has a weight of 5, meaning it appears 5 times more often.", 5.0);
			chat.Add("This message has a weight of 0.1, meaning it appears 10 times as rare.", 0.1);
			return chat; // chat is implicitly cast to a string. You can also do "return chat.Get();" if that makes you feel better
		}
		*/

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
			if (DD2Event.DownedInvasionT1)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Tiara"));
				nextSlot++;
			}
			if (Main.hardMode)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("ShadowflameBattleStandard"));
				nextSlot++;				
				shop.item[nextSlot].SetDefaults(mod.ItemType("WyvernFeather"));
				nextSlot++;			
				shop.item[nextSlot].SetDefaults(mod.ItemType("FrozenHeart"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("ForbiddenCharm"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.NightKey);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.LightKey);
                nextSlot++;
			}
			if (NPC.downedPirates)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("PirateFlag"));
				nextSlot++;
			}
			if (NPC.downedMechBossAny)
			{	
				shop.item[nextSlot].SetDefaults(mod.ItemType("DevilTail"));
				nextSlot++;		
			}
			if (DD2Event.DownedInvasionT2)
			{	
				shop.item[nextSlot].SetDefaults(mod.ItemType("OgreBuckle"));
				nextSlot++;	
			}
			if (NPC.downedPlantBoss)
			{	
				shop.item[nextSlot].SetDefaults(mod.ItemType("MothronEgg"));
				nextSlot++;		
				shop.item[nextSlot].SetDefaults(mod.ItemType("KarateSkull"));
				nextSlot++;			
				shop.item[nextSlot].SetDefaults(mod.ItemType("PaladinPlate"));
				nextSlot++;			
			}
			if (NPC.downedHalloweenTree)			
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("DeadBranch"));
				nextSlot++;			
			}
			if (NPC.downedHalloweenKing)
			{	
				shop.item[nextSlot].SetDefaults(mod.ItemType("PumpkingButton"));
				nextSlot++;			
			}
			if (NPC.downedChristmasTree)
			{	
				shop.item[nextSlot].SetDefaults(mod.ItemType("TreeBranch"));
				nextSlot++;			
			}
			if (NPC.downedChristmasSantank)
			{	
				shop.item[nextSlot].SetDefaults(mod.ItemType("SantaHat"));
				nextSlot++;		
			}
			if (NPC.downedChristmasIceQueen)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("IceGem"));
				nextSlot++;			
			}
			if (NPC.downedMartians)
			{	
				shop.item[nextSlot].SetDefaults(mod.ItemType("MartianCore"));
				nextSlot++;			
			}
			if (NPC.downedBoss3)
			{
				shop.item[nextSlot].SetDefault(mod.ItemType("Skully"));
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
