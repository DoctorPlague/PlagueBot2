using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace PlagueBot
{
    class MyBot
    {
        DiscordClient discord;
        CommandService commands;

        Random rand;


        string[] freshestMemes = Directory.GetFiles("C:\\Discord Bot Memes");
        string[] madisonMemes = Directory.GetFiles("C:\\Madison Memes");


        public MyBot()
        {
            rand = new Random();
            #region
            /* freshestMemes = new string[]
             { 
                 "http://i.imgur.com/DhBILMN.jpg",
                 "http://i.imgur.com/b04vZ3E.jpg",
                 "http://i.imgur.com/oz8yx0a.jpg",
                 "http://i.imgur.com/AOETSzS.jpg?3",
                 "http://i.imgur.com/hLez2Nz.png",
                 "http://i.imgur.com/cBZv6Kz.jpg",
                 "https://fb-s-d-a.akamaihd.net/h-ak-xlp1/v/t1.0-0/p480x480/15940707_960978047372262_4048104958665526296_n.png?oh=e177bb7c11802e5e12a9fbef632bc19f&oe=590C75C3&__gda__=1491247815_f95fce497286fa2d6d1d05b9cf32df39",
                 "http://i.imgur.com/JcOLxzZ.jpg",
                 "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/15894881_1773901452872163_4159868373181717523_n.jpg?oh=d65fd4d49dc1e1e7c2462fac5bece5a2&oe=5916BC3F",
                 "https://fb-s-b-a.akamaihd.net/h-ak-xpl1/v/t1.0-0/p480x480/15941159_1123016941128994_1707179323262901288_n.jpg?oh=89e3d7e9b4bae1c7c9822dbf27fca815&oe=58E6B631&__gda__=1495238291_b274bde202f4c9473ab3d39579586254",
                 "https://68.media.tumblr.com/fb876870cf9448bc130f694b8909dceb/tumblr_oblfdaUgHb1svu5sgo1_540.jpg",
                 "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/15826125_957808844355849_8226451854540796902_n.jpg?oh=3c8a6d0feb9b8f5740bf97fcb33a0bc5&oe=59218CA0",
                 "https://fb-s-b-a.akamaihd.net/h-ak-xpf1/v/t1.0-0/p480x480/15741300_1886864228193780_313087082708434564_n.jpg?oh=0b1cce9ebbb4d38dd79ab368a879c6ad&oe=58E5E0F0&__gda__=1495156343_0b72cb2ffb6da89fa960a69aae58a4d2",
                 "https://fb-s-a-a.akamaihd.net/h-ak-xlt1/v/t1.0-0/s480x480/15894424_955931377876929_6231516090964914882_n.png?oh=922941b17041f334a1f035dab18a77f5&oe=591D2389&__gda__=1495232943_1cd42c23a0ce00501a81ebe35e1a2edc",
                 "https://fb-s-c-a.akamaihd.net/h-ak-xlf1/v/t1.0-0/p417x417/15894965_955926384544095_4925158591592403450_n.jpg?oh=6cd1f9bb600bcbd5bf038102c4ca9c19&oe=58DF5208&__gda__=1495448757_793052325482fa3faa7aadc458093e7b",
                 "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/15871506_953958498074217_5546857611052554970_n.jpg?oh=956e79cec2d58ac7372d1e719cca5633&oe=591C5061",
                 "https://fb-s-b-a.akamaihd.net/h-ak-xlp1/v/t1.0-0/p480x480/15826256_583015061889791_2869540063686075081_n.jpg?oh=ad822b903112b5992f365be924012838&oe=58F02590&__gda__=1491749780_3f9c98717e58ac7187d392edc0812197",
                 "https://fb-s-a-a.akamaihd.net/h-ak-xlt1/v/t1.0-0/s480x480/15822817_952748528195214_2070267422538085080_n.jpg?oh=faada8ecb40ecf4b6ec0e3de095d727e&oe=5923E353&__gda__=1491604597_57c457c890c63f7ecb3bbbf78bf5563a",
                 "http://i.imgur.com/YaD3sgz.jpg",
                 "https://fb-s-d-a.akamaihd.net/h-ak-xtp1/v/t1.0-0/s480x480/14600978_1193715734042143_2607964073366064614_n.png?oh=7bfe6df97ea6eb3d62d036a6d601a15c&oe=58FCF580&__gda__=1491426466_ed95040a1c2e57bf6f127bbe0bd46d4a",
                 "http://i.imgur.com/WWnDa3J.jpg",
                 "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/15492163_945364975600236_922349380186749685_n.jpg?oh=a8629d69db72acdb2e00c82d66245162&oe=58EB8396",
                 "https://scontent-syd2-1.xx.fbcdn.net/v/t31.0-8/15418346_381179515559030_9127388380243929950_o.png?oh=856b573ef5e5b7aec27a024b0d1cfa96&oe=58E0C04D",
                 "https://fb-s-d-a.akamaihd.net/h-ak-xtp1/v/t1.0-0/q85/p480x480/15541577_1178962788819147_1066628314987122579_n.jpg?oh=de011f33ad38de2218b5e62760eb8957&oe=58F02A85&__gda__=1492430999_534b618e174bd2a13e0bdd4ea58e15e5",
                 "https://scontent-syd2-1.xx.fbcdn.net/v/t31.0-8/s960x960/15403774_1590190350994969_4871502636608938933_o.jpg?oh=1ca88620b21625bf993cc6bb28c8afd4&oe=58FB8BB6",
                 "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/15349551_1100313596732662_4376651937393151960_n.jpg?oh=6821fa2be8e9314c30010ea7b56610e6&oe=58B08C78",
                 "https://fb-s-d-a.akamaihd.net/h-ak-xfp1/v/t1.0-0/p480x480/15380539_939502852853115_744799975066823684_n.jpg?oh=0acde40c87dd9e8215f795eea7d403d5&oe=58F15D4F&__gda__=1492449592_23cc2a7559e19b207d7d50045dfbeb1d",
                 "https://fb-s-a-a.akamaihd.net/h-ak-xpa1/v/t1.0-0/s480x480/15356681_1795015794083223_3476604207126121339_n.png?oh=0716fbd9abdab98a7f4e9c7b89ab96fd&oe=58B86FE1&__gda__=1491865891_e5b0b9ca11a016049e7e59e34f2624a8",
                 "https://68.media.tumblr.com/cc6f18f7bfb3dd194af1509659f0f6d4/tumblr_o0fqjqh1v81rc4748o1_1280.jpg",
                 "https://cdn.discordapp.com/attachments/192849926592528384/256183554730360832/image.jpg",
                 "https://cdn.discordapp.com/attachments/192849926592528384/256186534930153472/image.jpg",
                 "https://fb-s-a-a.akamaihd.net/h-ak-xat1/v/t1.0-0/s480x480/15380833_935497886586945_7842780720991969550_n.jpg?oh=91696c7404895872386945549200cc0f&oe=58BE2DA3&__gda__=1489115621_ce08d6f68005c762eca1da85b65c024f",
                 "http://i.imgur.com/7OnyAHB.png",
                 "http://i.imgur.com/Q6IJttZ.jpg",
                 "http://i.imgur.com/i1fmqxm.jpg",
                 "http://i.imgur.com/4naCBGo.png",
                 "http://i.imgur.com/SJVf6lJ.jpg",
                 "http://i.imgur.com/Ph3VPZ5.jpg",
                 "http://i.imgur.com/9wfAKGu.jpg",
                 "http://i.imgur.com/OIfjp95.jpg",
                 "http://i.imgur.com/GqnDytS.jpg",
                 "http://i.imgur.com/igl0ArE.jpg",
                 "http://i.imgur.com/ZxsftYP.jpg",
                 "http://i.imgur.com/OIxsRHG.jpg",
                 "http://i.imgur.com/HnQkkzY.jpg",
                 "http://i.imgur.com/AsW5HNZ.jpg",
                 "http://i.imgur.com/xm3T1i2.png",
                 "http://i.imgur.com/XOZ8ZxK.jpg",
                 "http://i.imgur.com/HOXFYqD.jpg",
                 "http://i.imgur.com/WgqxoAb.jpg",
                 "http://i.imgur.com/OwAkRJO.jpg",
                 "http://i.imgur.com/iYjYyRn.jpg",
                 "http://i.imgur.com/WcsFA5b.jpg",
                 "http://i.imgur.com/X7xZfdZ.jpg",
                 "http://i.imgur.com/jIzZ5DZ.jpg",
                 "http://i.imgur.com/VLDpsiC.jpg",
                 "http://i.imgur.com/cF6WdVX.jpg",
                 "http://i.imgur.com/IPBmu2a.jpg",
                 "http://i.imgur.com/l8bkDEA.jpg",
                 "http://i.imgur.com/Wthpe6N.jpg",
                 "http://i.imgur.com/7sINrFn.jpg",
                 "http://i.imgur.com/2eOUgT6.jpg",
                 "http://i.imgur.com/qvaIvP3.jpg",
                 "http://i.imgur.com/zbmkvzD.jpg",
                 "http://i.imgur.com/cmbzvlT.jpg",
                 "http://i.imgur.com/j1gfWB4.jpg",
                 "http://i.imgur.com/rxbgKGB.jpg",
                 "http://i.imgur.com/tdbHrxy.jpg",
                 "https://cdn.discordapp.com/attachments/209246465703411713/269805039629893633/1399529487827.gif"

             };
             */
            #endregion 
            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '!';
                x.AllowMentionPrefix = true;                
            });
                        
            commands = discord.GetService<CommandService>();
            
            RegisterMemeCommand();            
            RegisterDeleteCommand();                        
            RegisterCommandsCommand();            
            RegisterGoogleCommand();
            RegisterRulesCommand();            
            RegisterDecisionCommand();
            RegisterMadisonCommand();
            RegisterBanCommand();
            RegisterUnBanCommand();
            RegisterKickCommand();
            RegisterMuteCommand();
            RegisterUnMuteCommand();
            RegisterInviteCommand();
            RegisterNaziCommand();
            RegisterCalculateCommand();

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("MjY5NzY1NDA2ODg4MTY1Mzg2.C1uH5w.W1pteInpYYW26584PcubNoG83Tc", TokenType.Bot);
            });
        }
       


        private void RegisterMemeCommand()
        {
            commands.CreateCommand("meme")
                .Do(async (e) =>
                {
                    int randomMemeIndex = rand.Next(freshestMemes.Length);
                    string memeToPost = freshestMemes[randomMemeIndex];
                    await e.Channel.SendFile(memeToPost);
                });
        } 
              

        private void RegisterMadisonCommand()
        {
            commands.CreateCommand("madison")
                .Do(async (e) =>
                {
                    int randomMemeIndex = rand.Next(madisonMemes.Length);
                    string memeToPost = madisonMemes[randomMemeIndex];
                    await e.Channel.SendFile(memeToPost);
                });
        }


        private void RegisterNaziCommand()
        {
            commands.CreateCommand("nazi")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage(":joy: :joy: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :joy: :joy: :joy:\n:joy: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :joy: :joy: :joy:\n:joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :joy: :joy: :joy: :joy:\n:joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :rage: :joy: :joy: :joy: :joy:\n:joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy:\n:joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :rage: :rage: :rage: :rage: :rage: :joy: :joy:\n:joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :rage: :rage: :rage: :joy: :rage: :rage: :rage: :joy:\n:joy: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :rage: :rage: :joy: :joy: :joy: :rage: :rage: :rage:\n:rage: :rage: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :rage: :rage:\n:rage: :rage: :rage: :joy: :joy: :joy: :rage: :rage: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :joy:\n:joy: :rage: :rage: :rage: :joy: :rage: :rage: :rage: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy:\n:joy: :joy: :rage: :rage: :rage: :rage: :rage: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy:\n:joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy:\n:joy: :joy: :joy: :joy: :rage: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy:\n:joy: :joy: :joy: :joy: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy:\n:joy: :joy: :joy: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :joy:\n:joy: :joy: :joy: :joy: :joy: :joy: :joy: :joy: :rage: :rage: :joy: :joy: :joy: :joy: :joy: :joy: :joy: ");
                });
        }

        private void RegisterRulesCommand()
        {
            commands.CreateCommand("rules")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("```Rules:\nDon't spam.\nDon't post gore.\nPost content in the correct channel (please god).```");
                });
        }

        private void RegisterInviteCommand()
        {
            commands.CreateCommand("invite")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discordapp.com/api/oauth2/authorize?client_id=269765406888165386&scope=bot&permissions=0");
                });
        }        
         
        private void RegisterGoogleCommand()
        {
            commands.CreateCommand("google").Parameter("message", ParameterType.Multiple)
                .Do(async (e) =>
                {
                    await DoGoogle(e);                    
                });
        }        

        private void RegisterCommandsCommand()
        {
            commands.CreateCommand("commands").Alias(new string[] { "help", "command", "com"})
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("```Commands: !help, !rules, !calculate, !meme, !prank, !nazi, !invite, !8ball, !madison, !corey, !google (eg. !google dank memes)\n\nAdmin Commands: !ban, !kick, !mute, !unmute, !delete x (x being the number of messages to delete, between 1-100)```");
                });
        }
               
        private void RegisterBanCommand()
        {
             commands.CreateCommand("ban").Parameter("user", ParameterType.Multiple)
                .Do(async (e) =>
                {                    
                    if (e.User.ServerPermissions.Administrator == true)
                    {
                        var usernameToBan = e.Args[0];                        
                        var userToBan = e.Channel.Users.Where(input => input.Name == usernameToBan).FirstOrDefault();

                        //var message = ConstructMessage(e, googleData != null);

                        if (usernameToBan != null)
                        {
                            await e.Server.Ban(userToBan);                                                  
                        }
                    }
                });
        }

        private void RegisterCalculateCommand()
        {
            commands.CreateCommand("calculate").Parameter("equation", ParameterType.Multiple)
               .Do(async (e) =>
               {
                   long number1 = Convert.ToInt64(e.Args[0]);
                   long number2 = Convert.ToInt64(e.Args[2]);                 
                   
                   if (e.Args[1].Contains("+"))
                   {                       
                       long solution = number1 + number2;
                       string message = solution.ToString();
                       await e.Channel.SendMessage(message);
                   }                   
                   if (e.Args[1].Contains("-"))
                   {
                       long solution = number1 - number2;
                       string message = solution.ToString();
                       await e.Channel.SendMessage(message);
                   }
                   if (e.Args[1].Contains("/"))
                   {
                       long solution = number1 / number2;
                       string message = solution.ToString();
                       await e.Channel.SendMessage(message);
                   }
                   if (e.Args[1].Contains("*"))
                   {
                       long solution = number1 * number2;
                       string message = solution.ToString();
                       await e.Channel.SendMessage(message);
                   }
                   else if (!e.Args[1].Contains("*") && !e.Args[1].Contains("/") && !e.Args[1].Contains("") && !e.Args[1].Contains("+"))
                   {
                       await e.Channel.SendMessage("Here is an example of how to correctly use the calculate command: !calculate 200 + 200 Replace the plus sign with a - for subtraction, a * for multiplication and a / for division.");
                   }
               });
        }

        private void RegisterUnBanCommand()
        {
            commands.CreateCommand("ban").Parameter("user", ParameterType.Multiple)
               .Do(async (e) =>
               {
                   if (e.User.ServerPermissions.Administrator == true)
                   {
                       var usernameToUnban = e.Args[0];
                       var userToUnban = e.Channel.Users.Where(input => input.Name == usernameToUnban).FirstOrDefault();

                        //var message = ConstructMessage(e, googleData != null);

                        if (usernameToUnban != null)
                       {
                           await e.Server.Unban(userToUnban);
                       }
                   }
               });
        }

        private void RegisterKickCommand()
        {
            commands.CreateCommand("kick").Parameter("user", ParameterType.Multiple)
               .Do(async (e) =>
               {
                   if (e.User.ServerPermissions.Administrator == true)
                   {
                       var usernameToKick = e.Args[0];
                       var userToKick = e.Channel.Users.Where(input => input.Name == usernameToKick).FirstOrDefault();

                        //var message = ConstructMessage(e, googleData != null);

                        if (usernameToKick != null)
                       {
                           await userToKick.Kick();
                           await e.Channel.SendMessage(usernameToKick + " has been kicked.");
                       }
                   }
               });
        }

        private void RegisterAddRoleCommand()
        {
            commands.CreateCommand("kick").Parameter("user", ParameterType.Multiple)
               .Do(async (e) =>
               {
                   if (e.User.ServerPermissions.Administrator == true)
                   {
                       var usernameToKick = e.Args[0];
                       var userToKick = e.Channel.Users.Where(input => input.Name == usernameToKick).FirstOrDefault();

                       //var message = ConstructMessage(e, googleData != null);

                       if (usernameToKick != null)
                       {
                           await userToKick.Kick();
                           await e.Channel.SendMessage(usernameToKick + " has been kicked.");
                       }
                   }
               });
        }

        private void RegisterMuteCommand()
        {
            commands.CreateCommand("mute").Parameter("user", ParameterType.Multiple)
               .Do(async (e) =>
               {
                   var bompton = e.Server.FindChannels("Bompton").FirstOrDefault();
                   var chiraq = e.Server.FindChannels("Chiraq").FirstOrDefault();
                   var magicCity = e.Server.FindChannels("Magic City").FirstOrDefault();
                   var theBando = e.Server.FindChannels("The Bando").FirstOrDefault();
                   var newOverwrites = new ChannelPermissionOverrides(speak: PermValue.Deny);
                   if (e.User.ServerPermissions.Administrator == true)
                   {
                       var usernameToMute = e.Args[0];
                       var userToMute = e.Channel.Users.Where(input => input.Name == usernameToMute).FirstOrDefault();
                       var userPerms = e.Channel.GetPermissionsRule(userToMute);                     

                      
                       if (userToMute != null)
                       {
                           await bompton.AddPermissionsRule(userToMute, newOverwrites);
                           await chiraq.AddPermissionsRule(userToMute, newOverwrites);
                           await magicCity.AddPermissionsRule(userToMute, newOverwrites);
                           await theBando.AddPermissionsRule(userToMute, newOverwrites);
                           await e.Channel.SendMessage(usernameToMute + " has been muted.");
                       }
                       
                   }
               });
        }

        private void RegisterUnMuteCommand()
        {
            commands.CreateCommand("unmute").Parameter("user", ParameterType.Multiple)
               .Do(async (e) =>
               {
                   var bompton = e.Server.FindChannels("Bompton").FirstOrDefault();
                   var chiraq = e.Server.FindChannels("Chiraq").FirstOrDefault();
                   var magicCity = e.Server.FindChannels("Magic City").FirstOrDefault();
                   var theBando = e.Server.FindChannels("The Bando").FirstOrDefault();
                   var newOverwrites = new ChannelPermissionOverrides(speak: PermValue.Allow);
                   if (e.User.ServerPermissions.Administrator == true)
                   {
                       var usernameToMute = e.Args[0];
                       var userToMute = e.Channel.Users.Where(input => input.Name == usernameToMute).FirstOrDefault();
                       var userPerms = e.Channel.GetPermissionsRule(userToMute);


                       if (usernameToMute != null)
                       {
                           await bompton.AddPermissionsRule(userToMute, newOverwrites);
                           await chiraq.AddPermissionsRule(userToMute, newOverwrites);
                           await magicCity.AddPermissionsRule(userToMute, newOverwrites);
                           await theBando.AddPermissionsRule(userToMute, newOverwrites);
                           await e.Channel.SendMessage(usernameToMute + " has been unmuted.");
                       }
                   }
               });
        }

        private void RegisterDecisionCommand()
        {
            commands.CreateCommand("8ball")
                .Do(async (e) =>
                {
                   
                       string[] answers = new string[] { "Yes", "No", "Maybe" };
                       int randomAnswerIndex = rand.Next(answers.Length);
                       string answerToPost = answers[randomAnswerIndex];
                       await e.Channel.SendMessage(answerToPost);

                    

                });
        }
        
        private void RegisterDeleteCommand()
        {
            commands.CreateCommand("delete").Parameter("number", ParameterType.Multiple)
                .Do(async (e) =>
                {
                    if (e.User.ServerPermissions.Administrator == true)
                    {
                        var parameter = e.Args[0];
                        var number = Convert.ToInt32(parameter) + 1;
                        Message[] messagesToDelete = await e.Channel.DownloadMessages(number);
                        await e.Channel.DeleteMessages(messagesToDelete);
                    }

                });
        }
        
        private async Task DoGoogle(CommandEventArgs e)
        {
            var googleData = e.Args[0];            

            var message = ConstructMessage(e, googleData != null);

            if(googleData != null)
            {                
                await e.Channel.SendMessage("http://lmgtfy.com/?q=" + message);
            }
            else
            {
                await e.Channel.SendMessage("Tell me what to google.");
            }

        }      


        private string ConstructMessage(CommandEventArgs e, bool firstArg)
        {
            string message = "";

            for(int i = 0; i < e.Args.Length; i++)
            {
                message += e.Args[i].ToString() + "+";
            }

            var result = message;

            return result;


        }


        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
