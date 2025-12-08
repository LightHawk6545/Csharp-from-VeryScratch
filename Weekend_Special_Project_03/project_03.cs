using System;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Threading;

namespace Mobin_learning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ShowStoryMenu();
            DungeonAdventureBegins();
            UserChoosePath();
            InsideTheDungeon();
        }

        // ------------- STORY ENTRY POINTS -------------
        private static void DungeonAdventureBegins()
        {
            Drama("Welcome to mobin's adventure", ConsoleColor.Blue);
            Hold();

            Drama("[System] which part of the story would you like to go to?", ConsoleColor.Cyan);
            Console.WriteLine();
            Drama("[System] \"1\", From the beginning, \"2\", Choose a path,\n\"3\", Inside the dungeon, \"4\", Corren battle.", ConsoleColor.Green);

            Drama("it was a cold starry night.", ConsoleColor.Cyan);
            Hold();

            Say(coco, "we're back to it aren't we?");
            Say(mobin, "yes we are coco, we are going to the dungeon and this time\n we are finishing it.");
            Hold();

            Drama("they go to the middle of the vallan forest", ConsoleColor.Green);
            Hold();

            Say(coco, "mobin it is time, jump now!!");

            Scene("Mobin jumps from the flying dragons and coco follows his path when falling", ConsoleColor.Red);
            Hold();

            Say(mobin, "Coco be careful there is a flock of mini dragons coming to us!");
            Say(coco, "i guess we have no choice right?");
            Hold();

            Say(mobin, "Yes unleash it now!!");
            Hold();

            Drama("coco then in the sky gives mobin his sword and unleash his own", ConsoleColor.Cyan);
            Hold();

            Scene("They proceed to slay the dragons in the sky with mobin's fire sword\n and coco's ice sword", ConsoleColor.Red);
            Console.WriteLine();

            Say(mobin, "coco the ground is close, brace yourself!");
            Say(coco, "on it, grab the lamp ballons now.");
            Hold();

            Scene("Mobin and Coco open lamp ballons and reduce their fall speed with force of light", ConsoleColor.DarkYellow);
            Hold();

            Say(mobin, "oh no, do you hear that coco?");
            Say(coco, "yes it might be the vallan trex");
            Hold();

            Say(mobin, "it is about the path we choose, we might even have to fight it.");
            Hold();

            Say(mobin, "now which way to go?");
            Say(mobin, "Upper vallan, Right of vallan, The shortcut to Vistoria dungeon?", ConsoleColor.Magenta);
            Hold();
        }

        private static void UserChoosePath()
        {
            Say(mobin, "Choose your path: upper vallan, right of vallan, or the shortcut to Vistoria Dungeon?");
            Say(mobin, "Type: upper / right / shortcut");
            Console.WriteLine();

            while (true)
            {
                string choice = Console.ReadLine().Trim().ToLower();

                if (choice.Contains("upper"))
                {
                    UpperVallanForest();
                    return;
                }
                else if (choice.Contains("right"))
                {
                    RightVallanForest();
                    return;
                }
                else if (choice.Contains("short") || choice.Contains("shortcut"))
                {
                    ShortcutToDungeon();
                    return;
                }
                else
                {
                    ErrorNotAChoice();
                }
            }
        }

        private static void UpperVallanForest()
        {
            Say(coco, "Alright we'll go that way.");
            Hold();

            Drama("this place goes a longer way to Vistoria Dungeon.", ConsoleColor.Blue);
            Hold();

            Say(mobin, "coco this should be potentially safer but this is vallan.");
            Say(mobin, "there is no guarantee");
            Hold();

            Say(coco, "true i already smell a weird presence");
            Hold();

            Say(mobin, "the fact you smell something is alarming, should we trust it?");
            Hold();

            Say(coco, "it's your choice here mobin, say yes or no: (y / yes, n / no)", ConsoleColor.DarkMagenta);

            CocoTrustInstinct();

            Say(mobin, "that was such a hassle, finally we are at that the dungeon.");
            Hold();

            InsideTheDungeon();
        }

        private static void RightVallanForest()
        {
            Say(mobin, "That's quite and strange way, let's go nontheless");
            Say(coco, "you know this way isn't far from vistoria dungeon but the forest is incredibly dense here.");
            Hold();

            Say(mobin, "you're right and the trees are known to make it humid... perfect for the most dangerous animals here");
            Say(coco, "yes the -");
            Hold();

            Drama("As they were walking... before coco finished his sentence they started attacking.", ConsoleColor.Green);
            Hold();

            Say(mobin, "coco they are here! the starblood stingers, they are the second deadliest after vallan trex");
            Hold();

            Say(coco, "Mobin behind you!! a stinger!!");
            Hold();

            Drama("The stingers attack with their claws and teeth and their needles can get stuck to the body", ConsoleColor.Red);
            Drama("Making them more painful, and the needles grows in size in the body, making the wounds worse and\nparalyzing the victim and failing their vital organs", ConsoleColor.DarkGreen);
            Hold();

            Say(coco, "mobin this is not good at all!!! they are a swarm of them!!!");
            Say(coco, "mobin brace now!!!");
            Hold();

            Say(mobin, "coco come close to me quickly! we need to push them with both fire and ice");
            Say(mobin, "when i tell you attack, freeze them, when i say defend, have my back and i will mutilate them with fire." +
                " \n(type 1 to defend, and 2 to attack when prompted)", ConsoleColor.DarkMagenta);
            Hold();

            // Inform the player about the consequence
            Say(mobin, "Failing to follow Mobin's counter will result in their death and end of the story.");
            Hold();

            RightVallanHazard();

            Say(mobin, "finally here we are at the dungeon");
            Hold();

            InsideTheDungeon();
        }

        private static void ShortcutToDungeon()
        {
            Console.WriteLine();
            Say(mobin, "i guess this is the shortcut");
            Say(coco, "it is least dense and most straightforward to the dungeon");
            Hold();

            Drama("as they were walking, both of them had an odd instinct", ConsoleColor.Red);
            Hold();

            Say(mobin, "don't you think it is weird tho?");
            Say(coco, "i do, in fact, this is what makes this place great for hunting... there is no place to run");
            Hold();

            Say(mobin, "or hide anywhere...");
            Hold();

            Scene("before mobin and coco realized, their worst nightmare came true.", ConsoleColor.Green);
            Hold();

            Drama("RROOOOOAAAARRRRRR!!!!!!!", ConsoleColor.Red);
            Hold();

            Drama("The deadliest creature of all this forest has came to party in time, the...", ConsoleColor.Magenta);
            Hold();

            Say("Mobin & Coco", "The Vallan Trex!!!!!!!!");
            Hold();

            Say(mobin, "coco brace NOW!!!!! HE is going to kick us with his tail");
            Hold();

            Scene("Before they even knew it the trex kind of teleported and kicked them to the trees", ConsoleColor.Red);
            Hold();

            Scene("They need a good strategy to defeat the death itself and mobin is on to it", ConsoleColor.Green);
            Hold();

            TheVallanTrexChallenge();
        }

        private static void InsideTheDungeon()
        {
            Say(mobin, @"we are at the dungeon's entry, as before there are ""varin"" marks protecting the door");
            Say(coco, "do you have it on you? you know what i mean");
            Hold();

            Say(mobin, "yes i could find another one surprisingly");
            Say(coco, "alright, with the starblood dagger we can temporarily turn off the ancient seals.");
            Hold();

            Say(mobin, "yes we cannot remove them, as they are the most powerful seals and we can just\n open the doors for 10 seconds");
            Say(coco, "go for it, let's go in.");
            Hold();

            Drama("mobin stabs the ancient varin marks with starblood dagger and both of them...", ConsoleColor.Magenta);
            Hold();

            Say(mobin, "jump in!!!");
            Say(coco, "ahh got it!");
            Hold();

            Drama("The full dungeon name is, Vistoria Corren, meaning dungeon of the gods, and the most dangerous of all.", ConsoleColor.DarkMagenta);
            Hold();

            Scene("as they jumped in, they saw the main entrance hall filled with starblood glitter\n and fenrir lamps, it was a powerful place.", ConsoleColor.DarkCyan);
            Hold();

            Drama("The Dungeon had three parts: The main entrance hall, Corren's Terrace, and vistoria's great exit ", ConsoleColor.Magenta);
            Hold();

            MainDungeonHall();

            Drama("as they were walking inside, the sheer power hitting their faces was not explainable.", ConsoleColor.Magenta);
            Hold();

            Drama("as if a god was awakened in that terrace.", ConsoleColor.Magenta);
            Hold();

            Scene("Mobin and Coco fell to the ground and couldn't hold their heads up.", ConsoleColor.White);
            Hold();

            Say(mobin, "Oh crap… I can’t move… what is this overwhelming gravity?");
            Say(coco, "Mobin… we are being marked by Corren — the dungeon god.");
            Hold();

            Say(mobin, "That won’t end good for us...");
            Say(coco, "Oh no… I can hear those filthy creatures…");
            Hold();

            Scene("As they were overwhelmed, a number of guests joined the party.", ConsoleColor.White);
            Hold();

            TheCorrenTerrace();

            Drama("The god has finally fallen after centuries and with his collapse, the venirs crumble to the ground as well.", ConsoleColor.DarkMagenta);
            Hold();

            Drama("Mobin and Coco gather the remaining loot from the six mighty rooms of Corren’s domain, before heading toward Vistoria’s Great Exit.", ConsoleColor.Magenta);
            Hold();

            Say(mobin, "Finally, Coco boy… I see the light in Vistoria’s exit.");
            Say(coco, "Yes… and I see the dragon guard too.");
            Hold();

            Say(mobin, "He is nothing compared to the god himself.");
            Say(coco, "Then let’s take him down and go.");
            Hold();

            Say(mobin, "But wait… he’s sleeping. We can loot the three rooms here first, then leave.");
            Say(coco, "You're right.");
            Hold();

            Drama("The great doors open fully revealing treasure untouched for ages. Mobin and Coco loot all three rooms in silence.", ConsoleColor.Yellow);
            Hold();

            Drama("With the dragon still asleep, Mobin charges quietly with his divine weapon and defeats it in a single strike.", ConsoleColor.Red);
            Hold();

            Say(mobin, "Finally… we are done.");
            Say(coco, "Yes, Mobin. Let’s go outside of this dungeon now.");
            Hold();

            Say(mobin, "I’ll buy a lot of drinks with this treasure.");
            Say(coco, "And I will buy pure materials to refine the god’s starblood.");
            Hold();

            Say(mobin, "Good idea… I’ll do that too.");
            Hold();

            Drama("And like that… their adventure reaches its end.", ConsoleColor.Cyan);
            Hold();

            Drama("See you!", ConsoleColor.Yellow);
            Hold();
        }

        private static void Hold() => Console.ReadLine();

        private static string Capitalize(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Trim();
            return char.ToUpper(text[0]) + text.Substring(1);
        }

        private static void Say(string speaker, string text, ConsoleColor? color = null, ConsoleColor? colorBackground = null)
        {
            speaker = Capitalize(speaker);
            text = Capitalize(text);

            if (color != null) Console.ForegroundColor = color.Value;
            if (colorBackground != null) Console.BackgroundColor = colorBackground.Value;
            Console.WriteLine($"[{speaker}] {text}");
            Console.ResetColor();
        }

        private static void Scene(string scene, ConsoleColor? color = null, ConsoleColor? colorBackground = null)
        {
            if (color != null) Console.ForegroundColor = color.Value;
            if (colorBackground != null) Console.BackgroundColor = colorBackground.Value;
            Console.WriteLine($"* {scene} *");
            Console.ResetColor();
        }

        private static void Drama(string drama, ConsoleColor? color = null, ConsoleColor? colorBackground = null)
        {
            drama = Capitalize(drama);
            if (color != null) Console.ForegroundColor = color.Value;
            if (colorBackground != null) Console.BackgroundColor = colorBackground.Value;
            for (int i = 0; i < drama.Length; i++)
            {
                Console.Write($"{drama[i]}");
                Thread.Sleep(1);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void ErrorNotAChoice()
        {
            Say(mobin, "That wasn't a reliable choice");
            Say(mobin, "try again...");
        }

        private static int[][] fireDinasours =
        {
            new[] { 2 ,1, 1 },
            new[] { 1, 1, 1 },
            new[] { 1, 1, 1 }
        };

        private static int GetFireDinosaur(int i, int j) => fireDinasours[i][j];

        private static int[][] starbloodStingers =
        {
            new[] { 1, 2, 2, 1 },
            new[] { 2, 3 }
        };

        // Dungeon Map: [Section, Attribute]
        // Attributes: 0 = enemies, 1 = treasures, 2 = danger level, 3 = boss count

        private static int[,] dungeonMap =
        {
            // enemies, treasures, danger, bosses
            { 6,  8, 1, 0 },   // Main Entrance Hall
            { 12, 10, 6, 1 },  // Corren's Terrace
            { 2,  4, 2, 1 }    // Vistoria's Great Exit
        };

        // Jagged array for room counts
        private static int[][] dungeonRooms =
        {
            new[] { 1, 1, 1, 1 },  // Main Entrance Hall (4 rooms)
            new[] { 1, 1, 2, 1, 1 }, // Corren's Terrace (6 rooms)
            new[] { 1, 1, 1 }   // Great Exit Hall (3 rooms)
        };

        private static int GetStarbloodStingers(int i, int j) => starbloodStingers[i][j];

        private static void RightVallanHazard()
        {
            Say(mobin, "Alright coco ready? they coming to us, let's welcome them a rough time");
            Say(coco, $"yes and there are {GetStarbloodStingers(0, 0) + GetStarbloodStingers(0, 1) + GetStarbloodStingers(0, 2) + GetStarbloodStingers(0, 3)}");
            Hold();

            Say(mobin, "let's get the first wave now");
            Say(mobin, "coco, now!! Attack!! (hint: enter 2 now)", ConsoleColor.DarkYellow);

            RightVallanCounter(); // wave 1

            Say(mobin, $"brace! next wave is coming, they are {GetStarbloodStingers(1, 0) + GetStarbloodStingers(1, 1)} from behind and front");
            Say(mobin, "coco defend now!!!! (type the counter)", ConsoleColor.DarkYellow);

            RightVallanCounter(); // wave 2

            Say(coco, "mobin, those are the last forces, the other stingers called them.");
            Say(mobin, "i see them coco, those have stronger starblood essence we need a special counter.", ConsoleColor.Green);
            Hold();

            Say(mobin, @"this time we need to both attack and defend to combine forces. (type ""3"" when prompted)");
            Say(coco, "if we dont do so... those special stings are taking us away.");
            Hold();

            Say(mobin, "coco now!!!!! special counter!! (type 3 now)", ConsoleColor.Magenta);

            RightVallanSpecialCounter();

            Drama("and with that the special starblood stingers froze and melted down to the ground, both.", ConsoleColor.Green);
            Hold();
        }

        private static int deathCounter = 0;

        private static void RightVallanCounter()
        {
            string raw = Console.ReadLine().Trim().ToLower();
            bool parsed = int.TryParse(raw, out int counter);

            if (!parsed || (counter != 1 && counter != 2))
            {
                Console.WriteLine();
                Say(mobin, "oh no, i've been stung, that's not good... one more and im gone.");
                Say(coco, "im sorry mobin, *cough* i couldn't follow the counter, im also stung...");
                Hold();

                deathCounter++;

                if (deathCounter >= 2)
                {
                    Drama("[Mobin] Im sorry coco, i can't... breath... anymore...", ConsoleColor.Magenta);
                    Hold();

                    Drama("The story has ended.", ConsoleColor.Yellow);
                    Hold();

                    Environment.Exit(0);
                }

                return;
            }

            if (counter == 1)
            {
                Console.WriteLine();
                Say(coco, "freeze you stingy ice cream");
                Say(mobin, "good one coco, i'll count on you!");
                Hold();

                if (starbloodStingers.Length > 1)
                    Array.Clear(starbloodStingers[1], 0, Math.Min(2, starbloodStingers[1].Length));

                Say(mobin, $"with that leaves {GetStarbloodStingers(1, 0) + GetStarbloodStingers(1, 1)} nasty stingers");
                Say(coco, "hooray!");
                Hold();
            }
            else if (counter == 2)
            {
                Console.WriteLine();

                Say(mobin, "yes we got them, one stinger swarm down the drain");
                Say(coco, "nice attack mobin!");

                Array.Clear(starbloodStingers[0], 0, Math.Min(4, starbloodStingers[0].Length));

                Say(mobin, $"there are {GetStarbloodStingers(0, 0) + GetStarbloodStingers(0, 1) + GetStarbloodStingers(0, 2) + GetStarbloodStingers(0, 3)} left now");
                Hold();
            }
        }

        private static void RightVallanSpecialCounter()
        {
            string raw = Console.ReadLine().Trim().ToLower();
            bool parsed = int.TryParse(raw, out int counter);

            if (!parsed || counter != 3)
            {
                // immediate fail for special counter
                Drama("Mobin and coco failed the counter, coco was impaled to the tree and mobin...", ConsoleColor.White);
                Hold();

                Drama("Mobin was severely stung and needles grew in his heart and lung, leaving him paralyzed.", ConsoleColor.Magenta);
                Hold();

                Drama("The story has ended", ConsoleColor.Yellow);
                Hold();

                Environment.Exit(0);
                return;
            }

            Say(mobin, "we nailed it coco, we are ready for the dungeon i guess!");
            Say(coco, "yes!! we took down the special forces!!");
            Hold();
        }

        private static void TheVallanTrexChallenge()
        {
            Say(mobin, "alright coco, listen carefully we need to with this plan");
            Say(mobin, "right now this trex is far faster and stronger than us.");
            Hold();

            Say(coco, "what do you think we can do?");
            Say(mobin, "here is how we counter it");
            Hold();

            Say(mobin, "we will use three methods to cut its tail, legs and body.");
            Say(mobin, "if we fail at any, i dont know what will happen to us");
            Hold();

            Say(mobin, "when i said swap you will give me your sword and you take mine to confuse the trex with a special attack");
            Say(mobin, @"when i said ""Coco now!!"", we both get close together and attack it from behind to cut its legs");
            Say(mobin, @"and finally when i said ""hard counter"" we will reunite infront of it and cut its body");
            Hold();

            Say(coco, "got it mobin", ConsoleColor.Red);
            Hold();

            Drama("with this they will attack and you help them.", ConsoleColor.White);
            Hold();

            Drama("follow mobin's instruction when prompted, failing to do so will result in coco or mobin's death and story's end.", ConsoleColor.Magenta);
            Hold();

            Say(mobin, "it is charging an attack, ready up coco!!");
            Say(coco, "yes sir!");
            Hold();

            Say(mobin, "Its coming now!!! coco swap!!!!\n(type exactly \"mobin take my sword\" now)");

            VallanTrexCounter();

            Say(coco, "looks like the tail is not enough, its getting power from his upper body and legs again");
            Say(mobin, "alright coco we need the second counter before he severely kicks us to the trees");
            Hold();

            Say(coco, "there we go he is speeding up again");
            Console.WriteLine();

            Drama("RROOOAAAAAAARRR", ConsoleColor.Magenta);
            Hold();

            Say(mobin, "coco he is getting closer, second counter time....");
            Say(mobin, @"NOWWW!!! (type exactly ""coco lure the trex"")");

            VallanTrexCounter();

            Say(mobin, "time to end this theater coco boy right?");
            Say(coco, "yes mobin, let's not underestimate this half dead trex, he is still deadly.");
            Hold();

            Say(mobin, "i totally agree, he can still launch his teeth on us.");
            Say(coco, "he is making for the final attack.");
            Hold();

            Say(mobin, "ready coco boy? we cannot fail this!");
            Say(coco, "im on it!!");
            Hold();

            Say(coco, "here comes the attack!");
            Say(mobin, @"coco boy, Brace now!! (type ""hard counter"" now)");

            VallanTrexCounter();

            Say(mobin, "finally let us be on our way");

            Drama("and they get sooner there...", ConsoleColor.Yellow);
            Hold();

            InsideTheDungeon();
        }

        private static int trexStage = 1;

        private static void VallanTrexCounter()
        {
            string counter = Console.ReadLine().Trim().ToLower();
            counter = Regex.Replace(counter, @"\s+", " ");

            if (trexStage == 1)
            {
                if (counter == "mobin take my sword")
                {
                    StageOneAction();
                    trexStage = 2;
                    return;
                }
                else
                {
                    KillByTrex();
                }
            }

            if (trexStage == 2)
            {
                if (counter == "coco lure the trex")
                {
                    StageTwoAction();
                    trexStage = 3;
                    return;
                }
                else
                {
                    KillByTrex();
                }
            }
            if (trexStage == 3)
            {
                if (counter == "hard counter")
                {
                    StageThreeAction();
                    return;
                }
            }
            else
            {
                KillByTrex();
            }
        }

        private static void StageOneAction()
        {
            Console.WriteLine();
            Say(mobin, "Roger that coco boy!!");
            Hold();

            Drama("he took the sword in the sky and blinded the trex temporarily and...", ConsoleColor.Magenta);
            Hold();

            Say(mobin, "Coco cut the tails now!!!!");
            Say(coco, "aye sir!");
            Hold();

            Scene("coco cut the tail taking the trex power, preparing for next attack.", ConsoleColor.Cyan);
            Hold();
        }

        private static void StageTwoAction()
        {
            Drama("coco jumps incredibly high in the sky and performs ice stunts to lure trex upward", ConsoleColor.Cyan);
            Hold();

            Drama("right before the trex jumps to grab coco, mobin comes in action", ConsoleColor.Red);
            Hold();

            Say(mobin, "good job coco boy, the rest is on me, i'll cut the legs!!");
            Say(mobin, "take this nasty trex!!", ConsoleColor.DarkRed);
            Hold();

            Drama("mobin has cut the trex legs but it is not over");
            Hold();

            Say(coco, "now for the final show mobin.");
            Say(mobin, "yes coco boy");
            Hold();
        }

        private static void StageThreeAction()
        {
            Say(coco, "and the last hit is ours!!!");
            Say(mobin, "coco boy lend me your strength, attack with full fire force now!!");
            Hold();

            Drama("Mobin and Coco unleashed the strength fire and ice cutting the Vallan Trex in half, ending its legend...", ConsoleColor.Red);
            Hold();

            Scene("they were tired but they are yet to go to the dungeon...", ConsoleColor.DarkRed);
            Hold();

            Say(mobin, "now let's go to the dungeon right coco boy?");
            Say(coco, "im all ready for the dungeon.");
            Hold();
        }

        private static void MainDungeonHall()
        {
            Drama("As Mobin and Coco entered the main hall, they realized something odd\n and their hearts trembled with the immense Starblood essence present there.", ConsoleColor.Magenta);
            Hold();

            Say(mobin, "this place is far stronger than I ever thought it would be.");
            Hold();

            Say(coco, "you're right. The starblood level is unusual here... you will never find it outside like this.");
            Hold();

            Scene("As they were walking, they could feel an unusual presence… and many of them.", ConsoleColor.Red);
            Hold();

            Say(coco, "Mobin… you feel them right? Don't you?");
            Say(mobin, "yes… very well. The groans.");
            Hold();

            Drama("Groans are creatures with high starblood essence, almost as strong as two stingers.", ConsoleColor.DarkMagenta);
            Hold();

            Scene("Right before Mobin separated from Coco, the groans made their move and jumped on them.", ConsoleColor.DarkRed);
            Hold();

            Say(mobin, "they were hiding behind the Fenrir lamps.");
            Say(coco, "we need to attack them now!");
            Hold();

            Say(mobin, "based on what I see, there are three here… and for sure more.");
            Say(coco, "take your sword, we will have a rally of fire and ice here.");
            Hold();

            Say(mobin, "alright… here is the plan: I will zig-zag them with incredible fire speed,");
            Say(mobin, "and you summon ice spike when I tell you.");
            Hold();

            Say(coco, "ice spike needs good charging… so I'm counting on your lure, Mobin.");
            Say(mobin, "you know I'm the best for that, coco boy.");
            Hold();

            Drama("Mobin is about to attack… and you will help him.", ConsoleColor.DarkMagenta);
            Hold();

            AttackOnGroans();
        }

        private static void AttackOnGroans()
        {
            Drama("Mobin started zig-zagging with immense speed.", ConsoleColor.Red);
            Hold();

            Say(mobin, "at this speed they can still catch up… oh no, there's one right beside me!!!");
            Say(mobin, "I should mutilate this one on my right!! (type \"fire mutilate\" now)");

            if (!MobinLures("fire mutilate"))
            {
                Say(mobin, "oh no… I'm bleeding too badly, I'm gone, i won't make it.");
                Hold();
                MobinDeathGroans();
                return;
            }

            Say(mobin, "the fire mutilation never fails me.");
            Say(mobin, "I can count on Coco while I speed up to the remaining groans up front.");
            Hold();

            Drama("the next two approach from behind… and Mobin notices, but it's too late to act.", ConsoleColor.Yellow);
            Hold();

            Say(coco, "I won't let Mobin fade to these…!", ConsoleColor.Cyan);
            Say(coco, "I will save him!! (type \"ice support\")");

            if (!MobinLures("ice support"))
            {
                Say(mobin, "oh no… I'm bleeding too badly, I'm gone, i won't make it.");
                Hold();
                MobinDeathGroans();
                return;
            }

            Say(mobin, "oh coco boy… thank you. I thought I couldn't handle that.");
            Say(coco, "always here for you, Mobin.");
            Hold();

            // FINAL COUNTER
            Say(mobin, "ready up Coco boy? They are gonna see a firework of their life here!");
            Say(coco, "yes… unleash it now!!");
            Hold();

            Say(mobin, "here it goes… my special attack!!! (type \"fire anniversary\")");

            if (!MobinLures("fire anniversary"))
            {
                Drama("Before Mobin released his special attack and Coco finished charging,\n the groans knocked Mobin down, tearing him to pieces and attacking Coco as his charge broke.", ConsoleColor.White);
                Hold();

                Drama("The story ends here…", ConsoleColor.Yellow);
                Hold();
                Environment.Exit(0);
                return;
            }

            Drama("Mobin and Coco's power exploded like a firework—Coco summoning an ice spike the size of a pillar,\n and Mobin bursting with fire, reducing the groans to dust.", ConsoleColor.DarkRed);
            Hold();

            MainHallLoot();
        }

        private static void MainHallLoot()
        {
            Say(mobin, "Now we are done with the mess. Let us enjoy ourselves with some loot.");
            Say(mobin, "When I was zigzagging, I had a glimpse of these halls. Looks like we have four rooms here.");
            Hold();

            Say(coco, "Perfect, that makes a lot of treasure.");
            Say(coco, "We need all the help we can get from here.");
            Hold();

            int frontLeftRooms = dungeonRooms[0][0] + dungeonRooms[0][1];
            int rightSideRooms = dungeonRooms[0][2] + dungeonRooms[0][3];

            Say(mobin, $"I'll have {frontLeftRooms} rooms on the front left side.");
            Say(coco, $"Right side is on me which has {rightSideRooms} rooms. I will collect Groans' Starblood as well.");
            Hold();

            Drama("Half an hour later they reunite...", ConsoleColor.Yellow);
            Hold();

            Say(mobin, "Alright, we are well off and ready to go.");
            Say(coco, "Yes Mobin, we need to get all the help as the next one is no joke.");
            Hold();

            Say(mobin, "Glad you know that Coco... it's the Corren's Terrace.");
            Hold();

            Drama("And like that they go to open the great doors of Corren Terrace.", ConsoleColor.DarkMagenta);
            Hold();
        }

        private static bool MobinLures(string expected)
        {
            string input = Console.ReadLine().Trim().ToLower();
            input = Regex.Replace(input, @"\s+", " ");

            return input == expected.ToLower();
        }

        private static void MobinDeathGroans()
        {
            Drama("Mobin collapses to the floor… while deeeply wounded.", ConsoleColor.Red);
            Hold();

            Drama("Coco screams and tries to hold him… but the groans overwhelm them both.", ConsoleColor.Magenta);
            Hold();

            Drama("Their story ends here.", ConsoleColor.Yellow);
            Hold();

            Environment.Exit(0);
        }

        private static void TheCorrenTerrace()
        {
            Drama("As the Venirs each holding half the power of a Vallan Trex emerged, they did not hesitate and rushed in.", ConsoleColor.Red);
            Hold();

            Say(mobin, "They will damage us badly, Coco… get ready…");
            Say(coco, "That's gonna hurt, Mobin.");
            Hold();

            Scene("The Venirs wounded both of them, launching them into the wall.", ConsoleColor.White);
            Hold();

            Say(mobin, "Well… I can see who is casting this spell on us.");
            Say(coco, "Yes… he is at least 4 meters tall… Corren, the god himself.");
            Hold();

            Say(mobin, "We cannot fade like this… I have a plan. We need the second phase of our swords.");
            Say(coco, "That's what we trained for… so the second phase is…?");
            Hold();

            Say(mobin, "Starlava Sword… and Black Ice Sword. I will inject as much starblood as I can so should you.");
            Hold();

            Drama("The spell on both of them ended and they got up,\n but it prevents them from getting closer than 2.5 meters.", ConsoleColor.DarkMagenta);
            Hold();

            Drama("The Corren god, radiating an unbelievable amount of starblood power, nearly deafened them as he spoke.", ConsoleColor.DarkMagenta);
            Hold();

            Say("Corren", "Be gone, filthy creatures of my ground.", ConsoleColor.Black, ConsoleColor.White);
            Hold();

            Say("Corren", "I shall punish you with evaporation, Your fate is sealed.", ConsoleColor.Black, ConsoleColor.White);
            Hold();

            Scene("It was then that Corren released a massive surge of Starblood gravity — crushing his own venirs beneath him.", ConsoleColor.Red);
            Hold();

            Scene("Mobin and Coco used the seal’s force to their advantage, pushing themselves away just in time.", ConsoleColor.Green);
            Hold();

            Say(mobin, "Okay Coco… the god himself has threatened us. We cannot back off now.");
            Say(coco, "I know. Throw me your sword I’ll make it stronger than mine. You’re the one who needs to finish him at the end.");
            Hold();

            Say(mobin, "Alright, Coco… and here’s the plan while you do it.");
            Say(mobin, "We’ll need to dodge and get close to his feet to weaken him.");
            Hold();

            Say(mobin, "It's incredibly dangerous… we cannot fail.");
            Say(coco, "I get it!");
            Hold();

            CorrenPhaseOne();

            Say(mobin, "Alright Coco, we tried our first move… we're closer to him at least.");
            Hold();

            Drama("Before Coco spoke, Corren did not give them a single breath of rest.", ConsoleColor.Magenta);
            Hold();

            Drama("He opened his palm preparing an infinite aura of razor sharp Starblood to impale them.", ConsoleColor.DarkRed);
            Hold();

            CorrenPhaseTwo();

            Drama("…and like that, although they pushed hard and hit the wall again… they were alive. And Corren spoke once more.", ConsoleColor.DarkMagenta);
            Hold();

            Say(corren, "You lowly creatures… you may escape, but you will not survive.", ConsoleColor.Black, ConsoleColor.White);
            Hold();

            Say(mobin, "Alright Coco… he will see soon. And the next move is yours.");
            Say(coco, "The Black Ice… an ancient technique that can damage Corren himself.");
            Hold();

            Say(mobin, "We must use it perfectly.");
            Say(coco, "And the best usage is to blind Corren temporarily… I spent years training for this.");
            Hold();

            Drama("Corren, relentless as ever, gathered a massive aura charging an attack meant to rain Starblood bolts upon them.", ConsoleColor.Red);
            Hold();

            Say(mobin, "I’ll run to him as fast as I can… if he succeeds charging this, we're gone, Coco!");
            Say(coco, "I’m counting on you!");
            Hold();

            CorrenPhaseThree();

            Drama("From the ground erupted a black hole a force even the Corren god recognized instantly.", ConsoleColor.DarkMagenta);
            Hold();

            Drama("It flew with terrifying speed toward the god’s eyes but Corren released his raining Starblood bolts.", ConsoleColor.Red);
            Hold();

            Drama("It was Mobin’s turn to neutralize the deadly bolts…", ConsoleColor.Yellow);
            Hold();

            CorrenPhaseFour();

            Drama("Mobin bursts forward in a sudden explosion of heat droplets of lava scattering\nlike a fiery constellation as he dashes, deflecting each bolt one after another.", ConsoleColor.DarkRed);
            Hold();

            Drama("He descends, landing hard a gentle rain of harmless ember falling around him.", ConsoleColor.Red);
            Hold();

            Say(mobin, "I'm… so exhausted now…");
            Say(coco, "Thank you, Mobin… that almost had me.");
            Hold();

            Say(mobin, "It's all good, Coco boy…");
            Say(coco, "We still need to take the god down while he is weak.");
            Hold();

            Drama("The god, even with divine black ice piercing his vision, begins preparing a sealing spell.", ConsoleColor.DarkMagenta);
            Hold();

            Drama("Mobin and Coco inject the very last drops of Starblood into their swords\nand into themselves preparing for their final approach.", ConsoleColor.Yellow);
            Hold();

            Say(mobin, "Alright Coco… here is the last technique. We will defeat this god.");
            Say(coco, "Alright Mobin… as you approach, I will ignite you with Black Ice for the ultimate strike.");
            Hold();

            Say(mobin, "Here I go!!!!!");
            Hold();

            CorrenFinalPhase();

            Drama("Mobin unleashes the Glowing Black Glitters a divine fusion of fire and black ice.\n"
          + "The blade erupts into a cosmic flare, slicing through Corren’s starblood armor.", ConsoleColor.DarkRed);
            Hold();

            Drama("The god collapses, the terrace trembling, as ancient seals shatter into stardust.", ConsoleColor.Magenta);
            Hold();

            Say(coco, "Mobin… we actually did it.");
            Say(mobin, "Yes… Coco boy… the god has fallen.");
            Hold();

            Drama("The path to Vistoria's Great Exit opens before them.", ConsoleColor.Yellow);
            Hold();
        }

        private static int correnFailCount = 0;

        private static void CorrenPhaseOne()
        {
            // STEP 1 — DODGE
            Drama("The Corren god charges an attack of unimaginable power defending is impossible.", ConsoleColor.DarkMagenta);
            Hold();

            Say(mobin, "Coco! We can't get close… but we can still cooperate. We must dodge this one!");
            Say(coco, "Alright, whenever you say, Mobin!");
            Hold();

            Say(mobin, "Okay… wait…");
            Hold();

            Say(mobin, "Dodge NOW! (type \"dodge\")");
            if (!CorrenInput("dodge")) return;
        }

        private static void CorrenPhaseTwo()
        {
            Say(mobin, "Coco! He's going to turn us into a strainer we need to...");
            Say(coco, "We need to repel each other, right on time!");
            Hold();

            Say(mobin, "Exactly. That aura is unforgiving.");
            Say(coco, "We must be precise… or I don't even want to imagine what happens.");
            Hold();

            Say(mobin, "Coco! Push me on my count");
            Say(mobin, "Alright on my mark… (type \"repel\")");
            if (!CorrenInput("repel")) return;
        }

        private static void CorrenPhaseThree()
        {
            Drama("Mobin sprinted forward, using the Lava Sword to ignite his feet launching himself upward to wound the god.", ConsoleColor.Red);
            Hold();

            Scene("The god effortlessly swatted Mobin to the ground… but then Coco…", ConsoleColor.Cyan);
            Hold();

            Say(mobin, "COCO! NOW!");
            Say(coco, "I summon the cursed source of the ancients…");
            Say(coco, "The… (type \"black ice\")");
            if (!CorrenInput("black ice")) return;
        }

        private static void CorrenPhaseFour()
        {
            Say(mobin, "I cannot possibly let Coco be impaled by the bolts…");
            Say(mobin, "I have 10 seconds to act on my Lava Sword…");
            Hold();

            Say(mobin, "I need to ignite my feet with powered lava from Starblood…");
            Say(mobin, "and melt the bolts as they approach. My body is tired… but I must move now.");
            Hold();

            Say(coco, "Mobin! Run away now!!");
            Hold();

            Say(mobin, "Here it goes!!!! The… (type \"lava sword\") intervention!!");

            if (!CorrenInput("lava sword")) return;
        }

        private static void CorrenFinalPhase()
        {
            Scene("Mobin dashes with surging Starblood energy while Coco summons a massive Black Ice spell.", ConsoleColor.Red);
            Hold();

            Say(mobin, "I’ve reached him! Coco, now!!");
            Say(coco, "Yes, Mobin!!");
            Hold();

            Drama("Coco enchants Mobin’s sword coating it in glittering, shimmering Black Ice\nthat grows hotter as it touches the burning lava, forming a divine weapon.", ConsoleColor.Cyan);
            Hold();

            Say(mobin, "It's time for you to fall, Corren… Black Sword of Fire, I summon your power!!!");
            Say(mobin, "Now!!! The… (type \"glowing black glitters\")");
            if (!CorrenInput("glowing black glitters"))
            {
                CorrenFinalDeath();
                return;
            }
        }

        private static bool CorrenInput(string needed)
        {
            string input = Console.ReadLine().Trim().ToLower();

            if (input != needed)
            {
                correnFailCount++;

                Say(mobin, "Ah!! We failed that one… this is really bad.");
                Hold();

                if (correnFailCount >= 2)
                {
                    CorrenDeath();
                    return false;
                }

                return false;
            }

            return true;
        }

        private static void CorrenDeath()
        {
            Drama("As Mobin and Coco fought with all they had… Corren suddenly spoke:", ConsoleColor.DarkMagenta);
            Hold();

            Say(corren, "Bow down and vanish...", ConsoleColor.Black, ConsoleColor.White);
            Hold();

            Say(corren, "Shall you never intrude upon the gods again…", ConsoleColor.Black, ConsoleColor.White);
            Hold();

            Drama("They were caught off guard Corren’s power erased them instantly.", ConsoleColor.Red);
            Hold();

            Drama("The story has ended.", ConsoleColor.Yellow);
            Hold();

            Environment.Exit(0);
        }

        private static void CorrenFinalDeath()
        {
            Drama("As Mobin charged with his divine weapon, the god seized him mid air\n "
                + "halting Mobin’s strike before it fully awakened.", ConsoleColor.Red);
            Hold();

            Drama("Corren sealed Mobin’s body with a single gesture… and struck down Coco instantly.", ConsoleColor.DarkMagenta);
            Hold();

            Drama("As Mobin and Coco fought the god, he suddenly spoke:", ConsoleColor.Black, ConsoleColor.White);
            Drama("Corren: Bow down and vanish…", ConsoleColor.White);
            Drama("Corren: Shall you never intrude upon the gods again…", ConsoleColor.White);
            Hold();

            Drama("And with that command, their bodies dissolved into his divine energy.", ConsoleColor.Yellow);
            Hold();

            Drama("The story has ended.", ConsoleColor.Yellow);
            Hold();
            Environment.Exit(0);
        }

        private static void SaveMobin()
        {
            Say(coco, "its coming to you, brace now !!! (enter 2 now): ");

            string counter = Console.ReadLine().Trim().ToLower();
            bool saveSuccess = int.TryParse(counter, out int saveMobin);

            if (saveSuccess && saveMobin == 2)
            {
                Drama("Mobin looks behind and before he unleash his sword...", ConsoleColor.White);
                DefeatingPterodactyl();
            }
            else
            {
                Drama("Right before mobin turns, the pterodactyl knocks him to the tree and coco is alone now.", ConsoleColor.Cyan);
                MobinKnockedDown();
            }
        }

        private static void DefeatingPterodactyl()
        {
            Say(mobin, "This rock pterodactyl cannot be better than my sword...!");
            Say(mobin, "coco blind his eyes with ice, i'll jump on him and melt his neck with fire");
            Hold();

            Say(coco, "got it!");
            Hold();

            Scene("coco jumps on pterodactyl's back and freezes his eyes with ice sword, then mobin comes in action", ConsoleColor.Cyan);
            Hold();

            Say(mobin, "take this, nasty bird.");
            Hold();

            Drama("the bird's neck was melted with fire.", ConsoleColor.DarkRed);
            Hold();
        }

        private static void MobinKnockedDown()
        {
            Say(coco, "mobin... Mobin!!!! oh no he is unconscious...");
            Say(coco, "im alone with this bird now.");
            Hold();

            Drama("the bird screeches and attacks coco, coco dodged... hardly.");
            Hold();

            Say(coco, "this rock pterodactyl is weak on wings and neck");
            Say(coco, "i cant get on his neck, so i must mutilate his wings with ice");
            Hold();

            Scene("As soon as the bird attacks coco lures him with an ice attack to a giant tree nearby", ConsoleColor.Green);
            Hold();

            Say(coco, "now it cannot go back easily now, its my chance", ConsoleColor.Cyan);
            Scene("he freezes his wings and the bird falls, mutilating his neck as well", ConsoleColor.Cyan);
            Hold();

            Say(coco, "that was dangerous, but mobin is not awake yet... i'll take care of him for now");
            Hold();

            Drama("1 hour later...", ConsoleColor.DarkYellow);
            Hold();

            Say(mobin, "ahh... what the hell happened?");
            Say(coco, "you've been knocked by a pterodactyl, im sorry i couldn't help");
            Hold();

            Say(mobin, "its okay coco, you couldn't do much, my head hurts, but let's go.");
            Hold();
        }

        private static void CocoTrustInstinct()
        {
            Say(mobin, "Do you trust your smell? yes or no");

            while (true)
            {
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "y" || input == "yes")
                {
                    InstinctTrusted();
                    return;
                }
                else if (input == "n" || input == "no")
                {
                    InstinctIgnored();
                    return;
                }
                else
                {
                    ErrorNotAChoice();
                }
            }
        }

        private static void InstinctTrusted()
        {
            Say(mobin, "Alright let's be cautious");
            Say(coco, "okay this way!");
            Hold();

            Drama("a few moment after taking the same path the something out of dark attacked", ConsoleColor.Red);
            Hold();

            Say(mobin, "coco your nose was right... good thing we prepared");
            Say(coco, "i know right..., now let's get these fireblood dinosours down");
            Hold();

            Scene("mobin pulls fire sword and coco ice sword ", ConsoleColor.Cyan);
            Hold();

            Say(mobin, "defeat them from their neck they can't produce protecive blood from there.");
            Say(coco, $"got it mobin, i have froze {GetFireDinosaur(0, 0) + GetFireDinosaur(0, 1) + GetFireDinosaur(0, 2)} so far");
            Hold();

            Say(mobin, $"A wave is coming to me, this must be the last, i already defeated {GetFireDinosaur(1, 0) + GetFireDinosaur(1, 1) + GetFireDinosaur(1, 2)}");
            Hold();

            Drama("As the last wave was coming mobin and coco braced themselves", ConsoleColor.DarkYellow);
            Hold();

            Scene("They crossed swords and both fiercely attacked", ConsoleColor.DarkRed);
            Hold();

            Say(coco, $"and the last {GetFireDinosaur(2, 0) + GetFireDinosaur(2, 1) + GetFireDinosaur(2, 2)} dinosours are defeated");
            Say(mobin, $"yes, if weren't cautious their blood would have burnt us");
            Hold();
        }

        private static void InstinctIgnored()
        {
            Say(mobin, "Alright we ignore the smell, let's be cautious.");
            Say(coco, "alright then, let's take this to the hill.");
            Hold();

            Scene("they changed their path", ConsoleColor.Green);
            Hold();

            Say(mobin, "That still doesn't look good for us coco.");
            Say(coco, "you're right we're in the middle of vallan and fenrir lamps are yet to charge.");
            Hold();

            Say(mobin, "this clothes is the only thing protecting us from starblood insects of vallan beside the lamp");
            Say(coco, "yes, that aside, don't you feel something is wrong?");
            Hold();

            Say(mobin, "i do i can even feel it...");
            Say(coco, "MOBIN watch out ! ...");
            Hold();

            Drama("a rock pterodacyl is about to attack mobin, you can save him by entering 2 when prompted.", ConsoleColor.Red);
            Hold();

            SaveMobin();
        }

        private static void KillByTrex()
        {
            Drama("The Vallan Trex roars violently...", ConsoleColor.Red);
            Hold();
            Drama("Mobin was struck first, thrown into the trees with a crushing blow...", ConsoleColor.DarkRed);
            Hold();
            Drama("Coco tried to jump in, but the Trex snapped its jaws and ended him instantly.", ConsoleColor.Red);
            Hold();
            Drama("They stood no chance after failing the counter.", ConsoleColor.Magenta);
            Hold();
            Drama("The story has ended.", ConsoleColor.Yellow);
            Hold();

            Environment.Exit(0);
        }

        private static void ShowStoryMenu()
        {
            Console.WriteLine();
            Drama("Welcome to Mobin's Adventure", ConsoleColor.Blue);
            Hold();

            Drama("[System] Which part of the story would you like to go to?", ConsoleColor.Cyan);
            Console.WriteLine();

            Drama(
                "[System] \"1\" — Start from the beginning\n" +
                "         \"2\" — Choose a path\n" +
                "         \"3\" — Inside the dungeon\n" +
                "         \"4\" — Corren battle",
                ConsoleColor.Green
            );

            HandleStoryMenu();
        }

        private static void HandleStoryMenu()
        {
            while (true)
            {
                Console.Write("Enter choice (1–4): ");
                string input = Console.ReadLine().Trim();

                switch (input)
                {
                    case "1":
                        StoryFromBeginning();
                        return;

                    case "2":
                        StoryChoosePath();
                        return;

                    case "3":
                        StoryInsideDungeon();
                        return;

                    case "4":
                        StoryCorrenBattle();
                        return;

                    default:
                        Say(mobin, "That wasn't a valid option. Try again...");
                        break;
                }
            }
        }

        private static void StoryFromBeginning()
        {
            DungeonAdventureBegins();
            UserChoosePath();
            InsideTheDungeon();
        }

        private static void StoryChoosePath()
        {
            UserChoosePath();
        }

        private static void StoryInsideDungeon()
        {
            InsideTheDungeon();
        }

        private static void StoryCorrenBattle()
        {
            TheCorrenTerrace();
        }

        private const string coco = "coco";
        private const string mobin = "mobin";
        private const string corren = "corren";
    }
}