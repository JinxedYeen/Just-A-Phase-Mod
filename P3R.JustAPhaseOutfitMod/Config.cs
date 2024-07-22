using P3R.JustAPhaseOutfitMod.Template.Configuration;
using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Interfaces.Structs;
using System;
using System.ComponentModel;
using static P3R.JustAPhaseOutfitMod.Configuration.Config;

namespace P3R.JustAPhaseOutfitMod.Configuration
{
    public class Config : Configurable<Config>
    {
        /*
            User Properties:
                - Please put all of your configurable properties here.
    
            By default, configuration saves as "Config.json" in mod user config folder.    
            Need more config files/classes? See Configuration.cs
    
            Available Attributes:
            - Category
            - DisplayName
            - Description
            - DefaultValue

            // Technically Supported but not Useful
            - Browsable
            - Localizable

            The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
        */

        //FIRST CONFIG (SPECIAL 4 SOME REASON)
        [Category("Misc")]
        [DisplayName("Prep Strega")]
        [Description("Replaces Strega's Outfits with Prep Clothes")]
        [DefaultValue(false)]
        public bool PrepStrega { get; set; } = true;

        //DIVIDER FOR TOP

        //YUKARI----


        [Category("Aigis Outfit Swap")]
        [DisplayName("Aigis - Beach Outfit")]
        [Description("Overrides Aigis's Beach Outfit")]
        [DefaultValue(BeachUni7.Off)]
        public BeachUni7 BeachOutfit7 { get; set; } = BeachUni7.Off;

        public enum BeachUni7
        {
            Off,
            Base
        }

        [Category("Aigis Outfit Swap")]
        [DisplayName("Aigis - SEES Outfit")]
        [Description("Overrides Aigis's SEES Outfit")]
        [DefaultValue(SEESUni7.Off)]
        public SEESUni7 SEESUniform7 { get; set; } = SEESUni7.Off;

        public enum SEESUni7
        {
            Off,
            Base
        }

        [Category("Aigis Outfit Swap")]
        [DisplayName("Aigis - Armband Outfit")]
        [Description("Overrides Aigis's Armband Outfit")]
        [DefaultValue(ArmbandUni7.Off)]
        public ArmbandUni7 ArmbandUniform7 { get; set; } = ArmbandUni7.Off;

        public enum ArmbandUni7
        {
            Off,
            Base
        }

        [Category("Aigis Outfit Swap")]
        [DisplayName("Aigis - Winter Garb")]
        [Description("Overrides Aigis's Winter Garb")]
        [DefaultValue(WinterGarb7.Off)]
        public WinterGarb7 WinterGarbb7 { get; set; } = WinterGarb7.Off;

        public enum WinterGarb7
        {
            Off,
            Base
        }

        [Category("Aigis Outfit Swap")]
        [DisplayName("Aigis - Winter Uniform")]
        [Description("Overrides Aigis's Winter Uniform")]
        [DefaultValue(WinterUni7.Off)]
        public WinterUni7 WinterUniform7 { get; set; } = WinterUni7.Off;

        public enum WinterUni7
        {
            Off,
            Base
        }



        //FUUK here


        [Category("Fuuka Outfit Swap")]
        [DisplayName("Fuuka - Beach Outfit")]
        [Description("Overrides Fuuka's Beach Outfit")]
        [DefaultValue(BeachUni6.Off)]
        public BeachUni6 BeachOutfit6 { get; set; } = BeachUni6.Off;

        public enum BeachUni6
        {
            Off,
            Base
        }
        [Category("Fuuka Outfit Swap")]
        [DisplayName("Fuuka - SEES Outfit")]
        [Description("Overrides Fuuka's SEES Outfit")]
        [DefaultValue(SEESUni6.Off)]
        public SEESUni6 SEESUniform6 { get; set; } = SEESUni6.Off;

        public enum SEESUni6
        {
            Off,
            Base
        }

        [Category("Fuuka Outfit Swap")]
        [DisplayName("Fuuka - Armband Outfit")]
        [Description("Overrides Fuuka's Armband Outfit")]
        [DefaultValue(ArmbandUni6.Off)]
        public ArmbandUni6 ArmbandUniform6 { get; set; } = ArmbandUni6.Off;

        public enum ArmbandUni6
        {
            Off,
            Base
        }
        [Category("Fuuka Outfit Swap")]
        [DisplayName("Fuuka - Summer Garb")]
        [Description("Overrides Fuuka's Summer Garb")]
        [DefaultValue(SummerGarb6.Off)]
        public SummerGarb6 SummerGarbb6 { get; set; } = SummerGarb6.Off;

        public enum SummerGarb6
        {
            Off,
            Base
        }

        [Category("Fuuka Outfit Swap")]
        [DisplayName("Fuuka - Winter Garb")]
        [Description("Overrides Fuuka's Winter Garb")]
        [DefaultValue(WinterGarb6.Off)]
        public WinterGarb6 WinterGarbb6 { get; set; } = WinterGarb6.Off;

        public enum WinterGarb6
        {
            Off,
            Base
        }



        [Category("Fuuka Outfit Swap")]
        [DisplayName("Fuuka - Summer Uniform")]
        [Description("Overrides Fuuka's Summer Uniform")]
        [DefaultValue(SummerUni6.Off)]
        public SummerUni6 SummerUniform6 { get; set; } = SummerUni6.Off;

        public enum SummerUni6
        {
            Off,
            Base
        }
        [Category("Fuuka Outfit Swap")]
        [DisplayName("Fuuka - Winter Uniform")]
        [Description("Overrides Fuuka's Winter Uniform")]
        [DefaultValue(WinterUni6.Off)]
        public WinterUni6 WinterUniform6 { get; set; } = WinterUni6.Off;

        public enum WinterUni6
        {
            Off,
            Base
        }



        //MITSURU HERE
        [Category("Mitsuru Outfit Swap")]
        [DisplayName("Mitsuru - Dorm Outfit")]
        [Description("Overrides Mitsuru's Dorm Outfit")]
        [DefaultValue(DormUni5.Off)]
        public DormUni5 DormOutfit5 { get; set; } = DormUni5.Off;

        public enum DormUni5
        {
            Off,
            Base

        }

        [Category("Mitsuru Outfit Swap")]
        [DisplayName("Mitsuru - Beach Outfit")]
        [Description("Overrides Mitsuru's Beach Outfit")]
        [DefaultValue(BeachUni5.Off)]
        public BeachUni5 BeachOutfit5 { get; set; } = BeachUni5.Off;

        public enum BeachUni5
        {
            Off,
            Base
        }



        [Category("Mitsuru Outfit Swap")]
        [DisplayName("Mitsuru - SEES Outfit")]
        [Description("Overrides Mitsuru's SEES Outfit")]
        [DefaultValue(SEESUni5.Off)]
        public SEESUni5 SEESUniform5 { get; set; } = SEESUni5.Off;

        public enum SEESUni5
        {
            Off,
            Base
        }

        [Category("Mitsuru Outfit Swap")]
        [DisplayName("Mitsuru - Armband Outfit")]
        [Description("Overrides Mitsuru's Armband Outfit")]
        [DefaultValue(ArmbandUni5.Off)]
        public ArmbandUni5 ArmbandUniform5 { get; set; } = ArmbandUni5.Off;

        public enum ArmbandUni5
        {
            Off,
            Base
        }


        [Category("Mitsuru Outfit Swap")]
        [DisplayName("Mitsuru - Summer Garb")]
        [Description("Overrides Mitsuru's Summer Garb")]
        [DefaultValue(SummerGarb5.Off)]
        public SummerGarb5 SummerGarbb5 { get; set; } = SummerGarb5.Off;

        public enum SummerGarb5
        {
            Off,
            Base
        }
        [Category("Mitsuru Outfit Swap")]
        [DisplayName("Mitsuru - Winter Garb")]
        [Description("Overrides Mitsuru's Winter Garb")]
        [DefaultValue(WinterGarb5.Off)]
        public WinterGarb5 WinterGarbb5 { get; set; } = WinterGarb5.Off;

        public enum WinterGarb5
        {
            Off,
            Base
        }

        [Category("Mitsuru Outfit Swap")]
        [DisplayName("Mitsuru - Summer Uniform")]
        [Description("Overrides Mitsuru's Summer Uniform")]
        [DefaultValue(SummerUni5.Off)]
        public SummerUni5 SummerUniform5 { get; set; } = SummerUni5.Off;

        public enum SummerUni5
        {
            Off,
            Base
        }
        [Category("Mitsuru Outfit Swap")]
        [DisplayName("Mitsuru - Winter Uniform")]
        [Description("Overrides Mitsuru's Winter Uniform")]
        [DefaultValue(WinterUni5.Off)]
        public WinterUni5 WinterUniform5 { get; set; } = WinterUni5.Off;

        public enum WinterUni5
        {
            Off,
            Base
        }


        //AKI GOES HERE



        [Category("Akihiko Outfit Swap")]
        [DisplayName("Akihiko - Winter Uniform")]
        [Description("Overrides Akihiko's Winter Uniform")]
        [DefaultValue(WinterUni4.Off)]
        public WinterUni4 WinterUniform4 { get; set; } = WinterUni4.Off;

        public enum WinterUni4
        {
            Off,
            Base
        }

        [Category("Akihiko Outfit Swap")]
        [DisplayName("Akihiko - Summer Uniform")]
        [Description("Overrides Akihiko's Summer Uniform")]
        [DefaultValue(SummerUni4.Off)]
        public SummerUni4 SummerUniform4 { get; set; } = SummerUni4.Off;

        public enum SummerUni4
        {
            Off,
            Base
        }      
        
        [Category("Akihiko Outfit Swap")]
        [DisplayName("Akihiko - Winter Garb")]
        [Description("Overrides Akihiko's Winter Garb")]
        [DefaultValue(WinterGarb4.Off)]
        public WinterGarb4 WinterGarbb4 { get; set; } = WinterGarb4.Off;

        public enum WinterGarb4
        {
            Off,
            Base
        }
        [Category("Akihiko Outfit Swap")]
        [DisplayName("Akihiko - Summer Garb")]
        [Description("Overrides Akihiko's Summer Garb")]
        [DefaultValue(SummerGarb4.Off)]
        public SummerGarb4 SummerGarbb4 { get; set; } = SummerGarb4.Off;

        public enum SummerGarb4
        {
            Off,
            Base
        }

        [Category("Akihiko Outfit Swap")]
        [DisplayName("Akihiko - Armband Outfit")]
        [Description("Overrides Akihiko's Armband Outfit")]
        [DefaultValue(ArmbandUni4.Off)]
        public ArmbandUni4 ArmbandUniform4 { get; set; } = ArmbandUni4.Off;

        public enum ArmbandUni4
        {
            Off,
            Base
        }
        [Category("Akihiko Outfit Swap")]
        [DisplayName("Akihiko - Dorm Outfit")]
        [Description("Overrides Akihiko's Dorm Outfit")]
        [DefaultValue(DormUni4.Off)]
        public DormUni4 DormOutfit4 { get; set; } = DormUni4.Off;

        public enum DormUni4
        {
            Off,
            Base

        }
        [Category("Akihiko Outfit Swap")]
        [DisplayName("Akihiko - Beach Outfit")]
        [Description("Overrides Akihiko's Beach Outfit")]
        [DefaultValue(BeachUni4.Off)]
        public BeachUni4 BeachOutfit4 { get; set; } = BeachUni4.Off;

        public enum BeachUni4
        {
            Off,
            Base
        }


        [Category("Akihiko Outfit Swap")]
        [DisplayName("Akihiko - SEES Outfit")]
        [Description("Overrides Akihiko's SEES Outfit")]
        [DefaultValue(SEESUni4.Off)]
        public SEESUni4 SEESUniform4 { get; set; } = SEESUni4.Off;

        public enum SEESUni4
        {
            Off,
            Base
        }

        //SHINJI HERE











        [Category("Shinji Outfit Swap")]
        [DisplayName("Shinji - Dorm Outfit")]
        [Description("Overrides Shinji's Dorm Outfit")]
        [DefaultValue(DormUni10.Off)]
        public DormUni10 DormOutfit10 { get; set; } = DormUni10.Off;
        public enum DormUni10
        {
            Off,
            Base,
            BlackParade
        }

        [Category("Shinji Outfit Swap")]
        [DisplayName("Shinji - Beach Outfit")]
        [Description("Overrides Shinji's Beach Outfit")]
        [DefaultValue(BeachUni10.Off)]
        public BeachUni10 BeachOutfit10 { get; set; } = BeachUni10.Off;

        public enum BeachUni10
        {
            Off,
            Base,
            BlackParade
        }


        [Category("Shinji Outfit Swap")]
        [DisplayName("Shinji - SEES Outfit")]
        [Description("Overrides Shinji's SEES Outfit")]
        [DefaultValue(SEESUni10.Off)]
        public SEESUni10 SEESUniform10 { get; set; } = SEESUni10.Off;

        public enum SEESUni10
        {
            Off,
            Base,
            BlackParade
        }

        [Category("Shinji Outfit Swap")]
        [DisplayName("Shinji - Armband Outfit")]
        [Description("Overrides Shinji's Armband Outfit")]
        [DefaultValue(ArmbandUni10.Off)]
        public ArmbandUni10 ArmbandUniform10 { get; set; } = ArmbandUni10.Off;

        public enum ArmbandUni10
        {
            Off,
            Base,
            BlackParade
        }


        [Category("Shinji Outfit Swap")]
        [DisplayName("Shinji - Winter Garb")]
        [Description("Overrides Shinji's Winter Garb")]
        [DefaultValue(WinterGarb10.Off)]
        public WinterGarb10 WinterGarbb10 { get; set; } = WinterGarb10.Off;

        public enum WinterGarb10
        {
            Off,
            Base,
            BlackParade
        }








        [Category("Koromaru Outfit Swap")]
        [DisplayName("Koromaru - Armband Outfit")]
        [Description("Overrides Koromaru's Armband Outfit")]
        [DefaultValue(ArmbandUni9.Off)]
        public ArmbandUni9 ArmbandUniform9 { get; set; } = ArmbandUni9.Off;

        public enum ArmbandUni9
        {
            Off,
            Base
        }


        [Category("Koromaru Outfit Swap")]
        [DisplayName("Koromaru - Winged Dog Suit")]
        [Description("Overrides Koromaru's Winged Dog Suit")]
        [DefaultValue(SummerGarb9.Off)]
        public SummerGarb9 SummerGarbb9 { get; set; } = SummerGarb9.Off;

        public enum SummerGarb9
        {
            Off,
            Base
        }

        [Category("Koromaru Outfit Swap")]
        [DisplayName("Koromaru - SEES Outfit")]
        [Description("Overrides Koromaru's SEES Outfit")]
        [DefaultValue(SEESUni9.Off)]
        public SEESUni9 SEESUniform9 { get; set; } = SEESUni9.Off;

        public enum SEESUni9
        {
            Off,
            Base
        }

        [Category("Koromaru Outfit Swap")]
        [DisplayName("Koromaru - No Collar")]
        [Description("Overrides Koromaru's No Collar Outfit")]
        [DefaultValue(WinterGarb9.Off)]
        public WinterGarb9 WinterGarbb9 { get; set; } = WinterGarb9.Off;

        public enum WinterGarb9
        {
            Off,
            Base
        }





        [Category("Ken Outfit Swap")]
        [DisplayName("Ken - Beach Outfit")]
        [Description("Overrides Ken's Beach Outfit")]
        [DefaultValue(BeachUni8.Off)]
        public BeachUni8 BeachOutfit8 { get; set; } = BeachUni8.Off;

        public enum BeachUni8
        {
            Off,
            Base,
            BlackParade
        }

        [Category("Ken Outfit Swap")]
        [DisplayName("Ken - SEES Outfit")]
        [Description("Overrides Ken's SEES Outfit")]
        [DefaultValue(SEESUni8.Off)]
        public SEESUni8 SEESUniform8 { get; set; } = SEESUni8.Off;

        public enum SEESUni8
        {
            Off,
            Base,
            BlackParade
        }
        [Category("Ken Outfit Swap")]
        [DisplayName("Ken - Armband Outfit")]
        [Description("Overrides Ken's Armband Outfit")]
        [DefaultValue(ArmbandUni8.Off)]
        public ArmbandUni8 ArmbandUniform8 { get; set; } = ArmbandUni8.Off;

        public enum ArmbandUni8
        {
            Off,
            Base,
            BlackParade
        }


        [Category("Ken Outfit Swap")]
        [DisplayName("Ken - Summer Garb")]
        [Description("Overrides Ken's Summer Garb")]
        [DefaultValue(SummerGarb8.Off)]
        public SummerGarb8 SummerGarbb8 { get; set; } = SummerGarb8.Off;

        public enum SummerGarb8
        {
            Off,
            Base,
            BlackParade
        }
        [Category("Ken Outfit Swap")]
        [DisplayName("Ken - Winter Garb")]
        [Description("Overrides Ken's Winter Garb")]
        [DefaultValue(WinterGarb8.Off)]
        public WinterGarb8 WinterGarbb8 { get; set; } = WinterGarb8.Off;

        public enum WinterGarb8
        {
            Off,
            Base,
            BlackParade
        }
        [Category("Ken Outfit Swap")]
        [DisplayName("Ken - Summer Uniform")]
        [Description("Overrides Ken's Summer Uniform")]
        [DefaultValue(SummerUni8.Off)]
        public SummerUni8 SummerUniform8 { get; set; } = SummerUni8.Off;

        public enum SummerUni8
        {
            Off,
            Base,
            BlackParade
        }
        [Category("Ken Outfit Swap")]
        [DisplayName("Ken - Winter Uniform")]
        [Description("Overrides Ken's Winter Uniform")]
        [DefaultValue(WinterUni8.Off)]
        public WinterUni8 WinterUniform8 { get; set; } = WinterUni8.Off;

        public enum WinterUni8
        {
            Off,
            Base,
            BlackParade
        }
















        //KEN

































        [Category("Makoto Music Mix Toggles")]
        [DisplayName("Green Day - American Idiot")]
        [Description("Toggles American Idiot by Green Day")]
        [DefaultValue(true)]
        public bool AmericanIdiot { get; set; } = true;


        [Category("Makoto Music Mix Toggles")]
        [DisplayName("Green Day - Basket Case")]
        [Description("Toggles Basket Case by Green Day")]
        [DefaultValue(true)]
        public bool BasketCase { get; set; } = true;


        [Category("Makoto Music Mix Toggles")]
        [DisplayName("Green Day - Letterbomb")]
        [Description("Toggles Letterbomb by Green Day")]
        [DefaultValue(true)]
        public bool Letterbomb { get; set; } = true;

        [Category("Makoto Music Mix Toggles")]
        [DisplayName("Pierce The Veil - Hell Above")]
        [Description("Toggles Hell Above by Pierce The Veil")]
        [DefaultValue(true)]
        public bool HellAbove { get; set; } = true;


        [Category("Makoto Music Mix Toggles")]
        [DisplayName("Pierce The Veil - King for a Day")]
        [Description("Toggles King for a Day by Pierce The Veil")]
        [DefaultValue(true)]
        public bool KingDay { get; set; } = true;


        [Category("Makoto Music Mix Toggles")]
        [DisplayName("Pierce The Veil - A Match into Water")]
        [Description("Toggles A Match into Water by Pierce The Veil")]
        [DefaultValue(true)]
        public bool MatchWater { get; set; } = true;

        [Category("Makoto Music Mix Toggles")]
        [DisplayName("Paramore - Brick by Boring Brick")]
        [Description("Toggles Brick By Boring Brick by Paramore")]
        [DefaultValue(true)]
        public bool BrickBy { get; set; } = true;


        [Category("Makoto Music Mix Toggles")]
        [DisplayName("Paramore - Looking Up")]
        [Description("Toggles Looking Up by Paramore")]
        [DefaultValue(true)]
        public bool LookingUp { get; set; } = true;













        [Category("Aigis Music Mix Toggles")]
        [DisplayName("Paramore - I'm Still Into You")]
        [Description("Toggles I'm Still Into You by Paramore")]
        [DefaultValue(true)]
        public bool StillYou { get; set; } = true;

        [Category("Aigis Music Mix Toggles")]
        [DisplayName("Green Day - Peacemaker")]
        [Description("Toggles Peacemaker by Green Day")]
        [DefaultValue(true)]
        public bool Peacemaker { get; set; } = true;

        [Category("Aigis Music Mix Toggles")]
        [DisplayName("t.A.T.U - All the Things She Said")]
        [Description("Toggles All the Things She Said by t.A.T.U")]
        [DefaultValue(true)]
        public bool AllThings { get; set; } = true;

        [Category("Aigis Music Mix Toggles")]
        [DisplayName("Nirvana - Lounge Act")]
        [Description("Toggles Lounge Act by Nirvana")]
        [DefaultValue(true)]
        public bool LoungeAct { get; set; } = true;

        [Category("Aigis Music Mix Toggles")]
        [DisplayName("My Chemical Romance - Helena")]
        [Description("Toggles Helena by My Chemical Romance")]
        [DefaultValue(true)]
        public bool Helena { get; set; } = true;

        [Category("Aigis Music Mix Toggles")]
        [DisplayName("My Chemical Romance - Famous Last Words")]
        [Description("Toggles Famous Last Words by My Chemical Romance")]
        [DefaultValue(true)]
        public bool FamousLast { get; set; } = true;

        [Category("Makoto Music Mix Extras Toggles")]
        [DisplayName("Blink-182 - This Feeling")]
        [Description("Toggles This Feeling by Blink-182")]
        [DefaultValue(true)]
        public bool ThisFeeling { get; set; } = true;


        [Category("Makoto Music Mix Extras Toggles")]
        [DisplayName("Blink-182 - The Rock Show")]
        [Description("Toggles The Rock Show by Blink-182")]
        [DefaultValue(true)]
        public bool RockShow { get; set; } = true;


        [Category("Makoto Music Mix Extras Toggles")]
        [DisplayName("Blink-182 - All the Small Things")]
        [Description("Toggles All The Small Things by Blink-182")]
        [DefaultValue(true)]
        public bool SmallThings { get; set; } = true;


        [Category("Makoto Music Mix Extras Toggles")]
        [DisplayName("Bad Religion - American Jesus")]
        [Description("Toggles American Jesus by Bad Religion")]
        [DefaultValue(true)]
        public bool AmericanJesus { get; set; } = true;


        [Category("Makoto Music Mix Extras Toggles")]
        [DisplayName("Nirvana - Smells like Teen Spirit")]
        [Description("Toggles Smells like Teen Spirit by Nirvana")]
        [DefaultValue(true)]
        public bool TeenSpirit { get; set; } = true;


        [Category("Makoto Music Mix Extras Toggles")]
        [DisplayName("Weezer - I Just Threw Out the Love of My Dreams")]
        [Description("Toggles I Just Threw Out the Love of My Dreams by Weezer")]
        [DefaultValue(true)]
        public bool ThrewOut { get; set; } = true;

        [Category("Makoto MCR Mix Toggles")]
        [DisplayName("My Chemical Romance - Welcome to the Black Parade")]
        [Description("Toggles Welcome to the Black Parade by My Chemical Romance")]
        [DefaultValue(true)]
        public bool BlackParade { get; set; } = true;



        [Category("Makoto MCR Mix Toggles")]
        [DisplayName("My Chemical Romance - Na Na Na")]
        [Description("Toggles Na Na Na by My Chemical Romance")]
        [DefaultValue(true)]
        public bool NaNaNa { get; set; } = true;



        [Category("Makoto MCR Mix Toggles")]
        [DisplayName("My Chemical Romance - I'm Not Okay (I Promise)")]
        [Description("Toggles I'm Not Okay (I Promise) by My Chemical Romance")]
        [DefaultValue(true)]
        public bool NotOkay { get; set; } = true;


        [Category("Makoto MCR Mix Toggles")]
        [DisplayName("My Chemical Romance - Dead!")]
        [Description("Toggles Dead! by My Chemical Romance")]
        [DefaultValue(true)]
        public bool Dead { get; set; } = true;


        [Category("Makoto Music Mix Toggles")]
        [DisplayName("Paramore - Misery Buisness")]
        [Description("Toggles Misery Buisness by Paramore")]
        [DefaultValue(true)]
        public bool MiseryBuisness { get; set; } = true;

        [Category("Makoto Music Mix Toggles - Originals")]
        [DisplayName("Yuugen Vinny - Mass Destruction Emo Ver.(feat. sleepy)")]
        [Description("Toggles the Emo Version of Mass Destruction by Yuugen Vinny(feat. sleepy)")]
        [DefaultValue(true)]
        public bool MassDestructEmo { get; set; } = true;


        [Category("Makoto Music Mix Toggles - Originals")]
        [DisplayName("Yuugen Vinny - It's Going Down Now Emo Ver.(feat. alex m)")]
        [Description("Toggles the Emo Version of It's Going Down Now by Yuugen Vinny(feat. alex m)")]
        [DefaultValue(true)]
        public bool ItsGoingDownNowEMO { get; set; } = true;

        [Category("Makoto Music Mix Toggles - Originals")]
        [DisplayName("Yuugen Vinny - Full Moon Full Life Emo Ver.(feat. tunattic)")]
        [Description("Toggles the Emo Version of Full Moon Full Life by Yuugen Vinny(feat. tunattic)")]
        [DefaultValue(true)]
        public bool FullMoonEMO { get; set; } = true;






        [Category("Player Outfit Swap")]
        [DisplayName("Player - Winter Uniform")]
        [Description("Overrides the Player's Winter Uniform")]
        [DefaultValue(WinterUni1.Off)]
        public WinterUni1 WinterUniform1 { get; set; } = WinterUni1.Off;

        public enum WinterUni1
        {
            Off,
            Base,
            Ryoji,
            FEMC,
            BlackParade
        }

        [Category("Player Outfit Swap")]
        [DisplayName("Player - Summer Uniform")]
        [Description("Overrides the Player's Summer Uniform")]
        [DefaultValue(SummerUni1.Off)]
        public SummerUni1 SummerUniform1 { get; set; } = SummerUni1.Off;

        public enum SummerUni1
        {
            Off,
            Base,
            Ryoji,
            FEMC,
            BlackParade
        }

        [Category("Player Outfit Swap")]
        [DisplayName("Player - Winter Garb")]
        [Description("Overrides the Player's Winter Garb")]
        [DefaultValue(WinterGarb1.Off)]
        public WinterGarb1 WinterGarbb1 { get; set; } = WinterGarb1.Off;

        public enum WinterGarb1
        {
            Off,
            Base,
            Ryoji,
            FEMC,
            BlackParade
        }


        [Category("Player Outfit Swap")]
        [DisplayName("Player - Job Outfits")]
        [Description("Overrides the Player's Job Outfits")]
        [DefaultValue(JobhUni1.Off)]
        public JobhUni1 JobOutfit1 { get; set; } = JobhUni1.Off;

        public enum JobhUni1
        {
            Off,
            Base,
            Ryoji,
            FEMC,
            BlackParade
        }

        [Category("Player Outfit Swap")]
        [DisplayName("Player - Dorm Outfit")]
        [Description("Overrides the Player's Dorm Outfit")]
        [DefaultValue(BeachUni1.Off)]
        public DormhUni1 DormOutfit1 { get; set; } = DormhUni1.Off;

        public enum DormhUni1
        {
            Off,
            Base,
            Ryoji,
            FEMC,
            BlackParade
        }

        [Category("Player Outfit Swap")]
        [DisplayName("Player - Beach Outfit")]
        [Description("Overrides the Player's Beach Outfit")]
        [DefaultValue(BeachUni1.Off)]
        public BeachUni1 BeachOutfit1 { get; set; } = BeachUni1.Off;

        public enum BeachUni1
        {
            Off,
            Base,
            Ryoji,
            FEMC,
            BlackParade
        }
        [Category("Player Outfit Swap")]
        [DisplayName("Player - SEES Uniform")]
        [Description("Overrides the Player's SEES Uniform")]
        [DefaultValue(SEESUni1.Off)]
        public SEESUni1 SEESUniform1 { get; set; } = SEESUni1.Off;

        public enum SEESUni1
        {
            Off,
            Base,
            Ryoji,
            FEMC,
            BlackParade
        }


        [Category("Player Outfit Swap")]
        [DisplayName("Player - Armband Uniform")]
        [Description("Overrides the Player's Armband Uniform")]
        [DefaultValue(ArmbandUni1.Off)]
        public ArmbandUni1 ArmbandUniform1 { get; set; } = ArmbandUni1.Off;

        public enum ArmbandUni1
        {
            Off,
            Base,
            Ryoji,
            FEMC,
            BlackParade
        }


        [Category("Player Outfit Swap")]
        [DisplayName("Player - Summer Garb")]
        [Description("Overrides the Player's Summer Garb")]
        [DefaultValue(SummerGarb1.Off)]
        public SummerGarb1 SummerGarbb1 { get; set; } = SummerGarb1.Off;

        public enum SummerGarb1
        {
            Off,
            Base,
            Ryoji,
            FEMC,
            BlackParade
        }



        [Category("Junpei Outfit Swap")]
        [DisplayName("Junpei - SEES Outfit")]
        [Description("Overrides Junpei's SEES Outfit")]
        [DefaultValue(SEESUni3.Off)]
        public SEESUni3 SEESUniform3 { get; set; } = SEESUni3.Off;

        public enum SEESUni3
        {
            Off,
            Base,
            BlackParade
        }

        [Category("Junpei Outfit Swap")]
        [DisplayName("Junpei - Armband Outfit")]
        [Description("Overrides Junpei's Armband Outfit")]
        [DefaultValue(ArmbandUni3.Off)]
        public ArmbandUni3 ArmbandUniform3 { get; set; } = ArmbandUni3.Off;

        public enum ArmbandUni3
        {
            Off,
            Base,
            BlackParade
        }


        [Category("Junpei Outfit Swap")]
        [DisplayName("Junpei - Summer Garb")]
        [Description("Overrides Junpei's Summer Garb")]
        [DefaultValue(SummerGarb3.Off)]
        public SummerGarb3 SummerGarbb3 { get; set; } = SummerGarb3.Off;


        public enum SummerGarb3
        {
            Off,
            Base,
            BlackParade
        }

        [Category("Junpei Outfit Swap")]
        [DisplayName("Junpei - Winter Garb")]
        [Description("Overrides Junpei's Winter Garb")]
        [DefaultValue(WinterGarb3.Off)]
        public WinterGarb3 WinterGarbb3 { get; set; } = WinterGarb3.Off;

        public enum WinterGarb3
        {
            Off,
            Base,
            BlackParade
        }
        [Category("Junpei Outfit Swap")]
        [DisplayName("Junpei - Beach Outfit")]
        [Description("Overrides Junpei's Beach Outfit")]
        [DefaultValue(BeachUni3.Off)]
        public BeachUni3 BeachOutfit3 { get; set; } = BeachUni3.Off;

        public enum BeachUni3
        {
            Off,
            Base,
            BlackParade
        }
        [Category("Junpei Outfit Swap")]
        [DisplayName("Junpei - Summer Uniform")]
        [Description("Overrides Junpei's Summer Uniform")]
        [DefaultValue(SummerUni3.Off)]
        public SummerUni3 SummerUniform3 { get; set; } = SummerUni3.Off;

        public enum SummerUni3
        {
            Off,
            Base,
            BlackParade
        }


        [Category("Junpei Outfit Swap")]
        [DisplayName("Junpei - Winter Uniform")]
        [Description("Overrides Junpei's Winter Uniform")]
        [DefaultValue(WinterUni3.Off)]
        public WinterUni3 WinterUniform3 { get; set; } = WinterUni3.Off;

        public enum WinterUni3
        {
            Off,
            Base,
            BlackParade
        }




        [Category("Yukari Outfit Swap")]
        [DisplayName("Yukari - Dorm Outfit")]
        [Description("Overrides Yukari's Dorm Outfit")]
        [DefaultValue(DormUni2.Off)]
        public DormUni2 DormOutfit2 { get; set; } = DormUni2.Off;

        public enum DormUni2
        {
            Off,
            Base,
            ALT
        }

        [Category("Yukari Outfit Swap")]
        [DisplayName("Yukari - Beach Outfit")]
        [Description("Overrides Yukari's Beach Outfit")]
        [DefaultValue(BeachUni2.Off)]
        public BeachUni2 BeachOutfit2 { get; set; } = BeachUni2.Off;

        public enum BeachUni2
        {
            Off,
            Base,
            ALT
        }

        [Category("Yukari Outfit Swap")]
        [DisplayName("Yukari - SEES Outfit")]
        [Description("Overrides Yukari's SEES Outfit")]
        [DefaultValue(SEESUni2.Off)]
        public SEESUni2 SEESUniform2 { get; set; } = SEESUni2.Off;

        public enum SEESUni2
        {
            Off,
            Base,
            ALT
        }


        [Category("Yukari Outfit Swap")]
        [DisplayName("Yukari - Armband Outfit")]
        [Description("Overrides Yukari's Armband Outfit")]
        [DefaultValue(ArmbandUni2.Off)]
        public ArmbandUni2 ArmbandUniform2 { get; set; } = ArmbandUni2.Off;

        public enum ArmbandUni2
        {
            Off,
            Base,
            ALT
        }

        [Category("Yukari Outfit Swap")]
        [DisplayName("Yukari - Winter Garb")]
        [Description("Overrides Yukari's Winter Garb")]
        [DefaultValue(WinterGarb2.Off)]
        public WinterGarb2 WinterGarbb2 { get; set; } = WinterGarb2.Off;

        public enum WinterGarb2
        {
            Off,
            Base,
            ALT
        }


        [Category("Yukari Outfit Swap")]
        [DisplayName("Yukari - Summer Garb")]
        [Description("Overrides Yukari's Summer Garb")]
        [DefaultValue(SummerGarb2.Off)]
        public SummerGarb2 SummerGarbb2 { get; set; } = SummerGarb2.Off;

        public enum SummerGarb2
        {
            Off,
            Base,
            ALT
        }


        [Category("Yukari Outfit Swap")]
        [DisplayName("Yukari - Summer Uniform")]
        [Description("Overrides Yukari's Summer Uniform")]
        [DefaultValue(SummerUni2.Off)]
        public SummerUni2 SummerUniform2 { get; set; } = SummerUni2.Off;

        public enum SummerUni2
        {
            Off,
            Base,
            ALT
        }

        [Category("Yukari Outfit Swap")]
        [DisplayName("Yukari - Winter Uniform")]
        [Description("Overrides Yukari's Winter Uniform")]
        [DefaultValue(WinterUni2.Off)]
        public WinterUni2 WinterUniform2 { get; set; } = WinterUni2.Off;

        public enum WinterUni2
        {
            Off,
            Base,
            ALT
        }

        //DIVIDER ----------------------------------------------







        //DIVIDER ------------------------------------------------------------------
        [Category("Misc")]
        [DisplayName("Just-A-Phase Ryoji")]
        [Description("Replaces Ryoji's Outfit with an appropiate Just-A-Phase one")]
        [DefaultValue(false)]
        public bool JustAPhaseRyoji { get; set; } = true;


        [Category("Misc")]
        [DisplayName("All-Out-Attack Portraits")]
        [Description("Replaces the AoA Portraits for the entire party, select male or female to reflect which version you are platying!")]
        [DefaultValue(AoAP.Off)]
        public AoAP AOAPortrait { get; set; } = AoAP.Off;

        public enum AoAP
        {
            Off,
            Male,
            FEMC
        }

        [Category("Misc")]
        [DisplayName("MenuSwap")]
        [Description("Replaces the main menu model with the outfit present in the mod")]
        [DefaultValue(MenuMC.Off)]
        public MenuMC MenuMainChar { get; set; } = MenuMC.Off;

        public enum MenuMC
        {
            Off,
            Male,
            FEMC
        }

        [Category("Misc")]
        [DisplayName("UI Swap")]
        [Description("Toggles the Ui Swap of character art -Only Applies to Makoto for now-")]
        [DefaultValue(false)]
        public bool UISWAP { get; set; } = true;








        //DIVIDER ----------------------------------------------------------------------

        //DIVIDER -------------------------------------------------------




        //DIVIDER --------------------------------------------------------------------


        // PLAYER -------------------------------------------------------------




















    }

}

/// <summary>
/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }

