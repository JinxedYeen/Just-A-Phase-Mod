using BGME.BattleThemes.Config;
using BGME.BattleThemes.Interfaces;
using BGME.Framework.Interfaces;
using P3R.CostumeFramework.Interfaces;
using P3R.JustAPhaseOutfitMod.Configuration;
using P3R.JustAPhaseOutfitMod.Template;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using System.ComponentModel;
using UnrealEssentials.Interfaces;
using static P3R.JustAPhaseOutfitMod.Configuration.Config;

namespace P3R.JustAPhaseOutfitMod
{
    /// <summary>
    /// Your mod logic goes here.

    /// </summary>
    public class Mod : ModBase // <= Do not Remove.
    {

        /// <summary>
        /// Provides access to the mod loader API.
        /// </summary>
        private readonly IModLoader _modLoader;

        /// <summary>
        /// Provides access to the Reloaded.Hooks API.
        /// </summary>
        /// <remarks>This is null if you remove dependency on Reloaded.SharedLib.Hooks in your mod.</remarks>
        private readonly IReloadedHooks? _hooks;

        /// <summary>
        /// Provides access to the Reloaded logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Entry point into the mod, instance that created this class.
        /// </summary>
        private readonly IMod _owner;

        /// <summary>
        /// Provides access to this mod's configuration.
        /// </summary>
        private Config _configuration;

        /// <summary>
        /// The configuration of the currently executing mod.
        /// </summary>
        private readonly IModConfig _modConfig;

        private readonly ThemeConfig themeConfig;
        public Mod(ModContext context)
        {
            _modLoader = context.ModLoader;
            _hooks = context.Hooks;
            _logger = context.Logger;
            _owner = context.Owner;
            _configuration = context.Configuration;
            _modConfig = context.ModConfig;




            var unrealEssentialsController = _modLoader.GetController<IUnrealEssentials>();
            if (unrealEssentialsController == null || !unrealEssentialsController.TryGetTarget(out var unrealEssentials))
            {
                _logger.WriteLine($"[My Mod] Unable to get controller for Unreal Essentials, stuff won't work :(", System.Drawing.Color.Red);
                return;
            }

            // SET MOD DIRECTORY
            var modDir = _modLoader.GetDirectoryForModId(_modConfig.ModId);

            // ADD ICOSTUMEAPI
            _modLoader.GetController<ICostumeApi>().TryGetTarget(out var CostumeApi);


            //ADD IBATTLETHEMESAPI
            _modLoader.GetController<IBattleThemesApi>().TryGetTarget(out var BattleThemesApi);

            this.themeConfig = new ThemeConfig(this._modLoader, this._modConfig, this._configuration, this._logger);

            //MUSIC TOGGLES

            this.themeConfig.AddSetting(nameof(this._configuration.MassDestructEmo), "MD-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.ItsGoingDownNowEMO), "IGDN-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.FullMoonEMO), "FM-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.AmericanIdiot), "AI-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.AmericanJesus), "AJ-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.BasketCase), "BC-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.BlackParade), "BP-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.Dead), "DE-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.HellAbove), "HA-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.KingDay), "KD-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.Letterbomb), "LB-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.LookingUp), "LU-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.MiseryBuisness), "MB-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.BrickBy), "BB-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.MatchWater), "MW-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.NaNaNa), "NA-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.NotOkay), "NO-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.RockShow), "RS-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.SmallThings), "ST-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.ThisFeeling), "TF-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.ThrewOut), "TO-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.TeenSpirit), "TS-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.StillYou), "SY-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.Peacemaker), "PM-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.AllThings), "AS-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.Helena), "HE-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.FamousLast), "FL-EMO.theme.pme");
            this.themeConfig.AddSetting(nameof(this._configuration.LoungeAct), "LA-EMO.theme.pme");

            this.themeConfig.Initialize();





            //Strega Outfit Toggle
            if (_configuration.PrepStrega)
            {
                var protagPath = Path.Combine(modDir, "Options", "Strega", "True");
                unrealEssentials.AddFromFolder(protagPath);
            }
            else
            {
            }

            //Ryoji Model Swap
            if (_configuration.JustAPhaseRyoji)
            {
                var protagPath = Path.Combine(modDir, "Options", "Ryoji", "True");
                unrealEssentials.AddFromFolder(protagPath);
            }
            else
            {
            }

            //AoA Portrait Toggles

            switch (_configuration.AOAPortrait)
            {

                case AoAP.Male:
                    var AOAPathM = Path.Combine(modDir, "Options", "AoAPortraits", "True");
                    unrealEssentials.AddFromFolder(AOAPathM);
                    var MaleAOAPath = Path.Combine(modDir, "Options", "AoAPortraits", "Male");
                    unrealEssentials.AddFromFolder(MaleAOAPath);
                    break;

                case AoAP.Off:

                    break;

                case AoAP.FEMC:
                    var AOAPathF = Path.Combine(modDir, "Options", "AoAPortraits", "True");
                    unrealEssentials.AddFromFolder(AOAPathF);
                    var FEMCAOAPath = Path.Combine(modDir, "Options", "AoAPortraits", "FEMC");
                    unrealEssentials.AddFromFolder(FEMCAOAPath);
                    break;

                default: break;
            }

            //Main Menu Toggles

            switch (_configuration.MenuMainChar)
            {

                case MenuMC.Male:

                    var MaleAOAPath = Path.Combine(modDir, "Options", "Menu-Swap", "Male");
                    unrealEssentials.AddFromFolder(MaleAOAPath);
                    break;

                case MenuMC.Off:

                    break;

                case MenuMC.FEMC:

                    var FEMCAOAPath = Path.Combine(modDir, "Options", "Menu-Swap", "FEMC");
                    unrealEssentials.AddFromFolder(FEMCAOAPath);
                    break;

                default: break;
            }

            //UI Swap Toggle
            if (_configuration.UISWAP)
            {
                var UIPath = Path.Combine(modDir, "Options", "UI");
                unrealEssentials.AddFromFolder(UIPath);
            }
            else
            {
            }

            //ENUM CONFIG -----------------------------------------------------------------------------------------------------------------

            switch (_configuration.WinterUniform1)
            {

                case WinterUni1.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "1Player", "1Winter-Outfit", "1BASE", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterUni1.Off:

                    break;

                case WinterUni1.Ryoji:
                    var WinUniRPath = Path.Join(modDir, "costumes", "1Player", "1Winter-Outfit", "2RYOJI", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniRPath);
                    break;

                case WinterUni1.FEMC:
                    var WinUniFPath = Path.Join(modDir, "costumes", "1Player", "1Winter-Outfit", "3FEMC", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                case WinterUni1.BlackParade:
                    var WinUniBPPath = Path.Join(modDir, "costumes", "1Player", "1Winter-Outfit", "4BP", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPPath);
                    break;

                default: break;
            }


            switch (_configuration.SummerUniform1)
            {

                case SummerUni1.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "1Player", "2Summer-Outfit", "1BASE", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerUni1.Off:

                    break;

                case SummerUni1.Ryoji:
                    var WinUniRPath = Path.Join(modDir, "costumes", "1Player", "2Summer-Outfit", "2RYOJI", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniRPath);
                    break;

                case SummerUni1.FEMC:
                    var WinUniFPath = Path.Join(modDir, "costumes", "1Player", "2Summer-Outfit", "3FEMC", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                case SummerUni1.BlackParade:
                    var WinUniBPPath = Path.Join(modDir, "costumes", "1Player", "2Summer-Outfit", "4BP", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPPath);
                    break;

                default: break;
            }

            switch (_configuration.WinterGarbb1)
            {

                case WinterGarb1.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "1Player", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterGarb1.Off:

                    break;

                case WinterGarb1.Ryoji:
                    var WinUniRPath = Path.Join(modDir, "costumes", "1Player", "6Winter-Garb", "2RYOJI", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniRPath);
                    break;

                case WinterGarb1.FEMC:
                    var WinUniFPath = Path.Join(modDir, "costumes", "1Player", "6Winter-Garb", "3FEMC", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                case WinterGarb1.BlackParade:
                    var WinUniBPPath = Path.Join(modDir, "costumes", "1Player", "6Winter-Garb", "4BP", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPPath);
                    break;

                default: break;
            }


            switch (_configuration.SummerGarbb1)
            {

                case SummerGarb1.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "1Player", "5Summer-Garb", "1BASE", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerGarb1.Off:

                    break;

                case SummerGarb1.Ryoji:
                    var WinUniRPath = Path.Join(modDir, "costumes", "1Player", "5Summer-Garb", "2RYOJI", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniRPath);
                    break;

                case SummerGarb1.FEMC:
                    var WinUniFPath = Path.Join(modDir, "costumes", "1Player", "5Summer-Garb", "3FEMC", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                case SummerGarb1.BlackParade:
                    var WinUniBPPath = Path.Join(modDir, "costumes", "1Player", "5Summer-Garb", "4BP", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPPath);
                    break;

                default: break;
            }


            switch (_configuration.ArmbandUniform1)
            {

                case ArmbandUni1.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "1Player", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni1.Off:

                    break;

                case ArmbandUni1.Ryoji:
                    var WinUniRPath = Path.Join(modDir, "costumes", "1Player", "51Armband-Outfit", "2RYOJI", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniRPath);
                    break;

                case ArmbandUni1.FEMC:
                    var WinUniFPath = Path.Join(modDir, "costumes", "1Player", "51Armband-Outfit", "3FEMC", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                case ArmbandUni1.BlackParade:
                    var WinUniBPPath = Path.Join(modDir, "costumes", "1Player", "51Armband-Outfit", "4BP", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPPath);
                    break;

                default: break;
            }


            switch (_configuration.SEESUniform1)
            {

                case SEESUni1.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "1Player", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni1.Off:

                    break;

                case SEESUni1.Ryoji:
                    var WinUniRPath = Path.Join(modDir, "costumes", "1Player", "52Sees-Outfit", "2RYOJI", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniRPath);
                    break;

                case SEESUni1.FEMC:
                    var WinUniFPath = Path.Join(modDir, "costumes", "1Player", "52Sees-Outfit", "3FEMC", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                case SEESUni1.BlackParade:
                    var WinUniBPPath = Path.Join(modDir, "costumes", "1Player", "52Sees-Outfit", "4BP", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPPath);
                    break;

                default: break;
            }

            switch (_configuration.BeachOutfit1)
            {

                case BeachUni1.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "1Player", "102Beach-Outfit", "1BASE", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case BeachUni1.Off:

                    break;

                case BeachUni1.Ryoji:
                    var WinUniRPath = Path.Join(modDir, "costumes", "1Player", "102Beach-Outfit", "2RYOJI", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniRPath);
                    break;

                case BeachUni1.FEMC:
                    var WinUniFPath = Path.Join(modDir, "costumes", "1Player", "102Beach-Outfit", "3FEMC", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                case BeachUni1.BlackParade:
                    var WinUniBPPath = Path.Join(modDir, "costumes", "1Player", "102Beach-Outfit", "4BP", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPPath);
                    break;

                default: break;
            }


            switch (_configuration.DormOutfit1)
            {

                case DormhUni1.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "1Player", "103Dorm-Outfit", "1BASE", "Just-A-Phase (Dorm Outfits).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case DormhUni1.Off:

                    break;

                case DormhUni1.Ryoji:
                    var WinUniRPath = Path.Join(modDir, "costumes", "1Player", "103Dorm-Outfit", "2RYOJI", "Just-A-Phase (Dorm Outfits).yaml");
                    CostumeApi.AddOverridesFile(WinUniRPath);
                    break;

                case DormhUni1.FEMC:
                    var WinUniFPath = Path.Join(modDir, "costumes", "1Player", "103Dorm-Outfit", "3FEMC", "Just-A-Phase (Dorm Outfits).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                case DormhUni1.BlackParade:
                    var WinUniBPPath = Path.Join(modDir, "costumes", "1Player", "103Dorm-Outfit", "4BP", "Just-A-Phase (Dorm Outfits).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPPath);
                    break;

                default: break;
            }

            switch (_configuration.JobOutfit1)
            {

                case JobhUni1.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "1Player", "158Job-Outfit", "1BASE", "Just-A-Phase (Job Outfits).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case JobhUni1.Off:

                    break;

                case JobhUni1.Ryoji:
                    var WinUniRPath = Path.Join(modDir, "costumes", "1Player", "158Job-Outfit", "2RYOJI", "Just-A-Phase (Job Outfits).yaml");
                    CostumeApi.AddOverridesFile(WinUniRPath);
                    break;

                case JobhUni1.FEMC:
                    var WinUniFPath = Path.Join(modDir, "costumes", "1Player", "158Job-Outfit", "3FEMC", "Just-A-Phase (Job Outfits).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                case JobhUni1.BlackParade:
                    var WinUniBPPath = Path.Join(modDir, "costumes", "1Player", "158Job-Outfit", "4BP", "Just-A-Phase (Job Outfits).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPPath);
                    break;

                default: break;
            }


            switch (_configuration.WinterUniform2)
            {

                case WinterUni2.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "2Yukari", "1Winter-Outfit", "1BASE", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterUni2.Off:

                    break;

                case WinterUni2.ALT:
                    var WinUniFPath = Path.Join(modDir, "costumes", "2Yukari", "1Winter-Outfit", "3FEMC", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SummerUniform2)
            {

                case SummerUni2.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "2Yukari", "2Summer-Outfit", "1BASE", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerUni2.Off:

                    break;

                case SummerUni2.ALT:
                    var WinUniFPath = Path.Join(modDir, "costumes", "2Yukari", "2Summer-Outfit", "3FEMC", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SummerGarbb2)
            {

                case SummerGarb2.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "2Yukari", "5Summer-Garb", "1BASE", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerGarb2.Off:

                    break;

                case SummerGarb2.ALT:
                    var WinUniFPath = Path.Join(modDir, "costumes", "2Yukari", "5Summer-Garb", "3FEMC", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }


            switch (_configuration.WinterGarbb2)
            {

                case WinterGarb2.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "2Yukari", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterGarb2.Off:

                    break;

                case WinterGarb2.ALT:
                    var WinUniFPath = Path.Join(modDir, "costumes", "2Yukari", "6Winter-Garb", "3FEMC", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.ArmbandUniform2)
            {

                case ArmbandUni2.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "2Yukari", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni2.Off:

                    break;

                case ArmbandUni2.ALT:
                    var WinUniFPath = Path.Join(modDir, "costumes", "2Yukari", "51Armband-Outfit", "3FEMC", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SEESUniform2)
            {

                case SEESUni2.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "2Yukari", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni2.Off:

                    break;

                case SEESUni2.ALT:
                    var WinUniFPath = Path.Join(modDir, "costumes", "2Yukari", "52Sees-Outfit", "3FEMC", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.BeachOutfit2)
            {

                case BeachUni2.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "2Yukari", "102Beach-Outfit", "1BASE", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case BeachUni2.Off:

                    break;

                case BeachUni2.ALT:
                    var WinUniFPath = Path.Join(modDir, "costumes", "2Yukari", "102Beach-Outfit", "3FEMC", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.DormOutfit2)
            {

                case DormUni2.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "2Yukari", "103Dorm-Outfit", "1BASE", "Just-A-Phase (Dorm Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case DormUni2.Off:

                    break;

                case DormUni2.ALT:
                    var WinUniFPath = Path.Join(modDir, "costumes", "2Yukari", "103Dorm-Outfit", "3FEMC", "Just-A-Phase (Dorm Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.WinterUniform3)
            {

                case WinterUni3.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "3Junpei", "1Winter-Outfit", "1BASE", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterUni3.Off:

                    break;

                case WinterUni3.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "3Junpei", "1Winter-Outfit", "4BP", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SummerUniform3)
            {

                case SummerUni3.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "3Junpei", "2Summer-Outfit", "1BASE", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerUni3.Off:

                    break;

                case SummerUni3.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "3Junpei", "2Summer-Outfit", "4BP", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SummerGarbb3)
            {

                case SummerGarb3.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "3Junpei", "5Summer-Garb", "1BASE", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerGarb3.Off:

                    break;

                case SummerGarb3.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "3Junpei", "5Summer-Garb", "4BP", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }


            switch (_configuration.WinterGarbb3)
            {

                case WinterGarb3.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "3Junpei", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterGarb3.Off:

                    break;

                case WinterGarb3.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "3Junpei", "6Winter-Garb", "4BP", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.ArmbandUniform3)
            {

                case ArmbandUni3.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "3Junpei", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni3.Off:

                    break;

                case ArmbandUni3.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "3Junpei", "51Armband-Outfit", "4BP", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SEESUniform3)
            {

                case SEESUni3.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "3Junpei", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni3.Off:

                    break;

                case SEESUni3.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "3Junpei", "52Sees-Outfit", "4BP", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.BeachOutfit3)
            {

                case BeachUni3.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "3Junpei", "102Beach-Outfit", "1BASE", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case BeachUni3.Off:

                    break;

                case BeachUni3.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "3Junpei", "102Beach-Outfit", "4BP", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }


            switch (_configuration.WinterUniform4)
            {

                case WinterUni4.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "4Akihiko", "1Winter-Outfit", "1BASE", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterUni4.Off:

                    break;



                default: break;
            }

            switch (_configuration.SummerUniform4)
            {

                case SummerUni4.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "4Akihiko", "2Summer-Outfit", "1BASE", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerUni4.Off:

                    break;



                default: break;
            }

            switch (_configuration.SummerGarbb4)
            {

                case SummerGarb4.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "4Akihiko", "5Summer-Garb", "1BASE", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerGarb4.Off:

                    break;


                default: break;
            }


            switch (_configuration.WinterGarbb4)
            {

                case WinterGarb4.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "4Akihiko", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterGarb4.Off:

                    break;



                default: break;
            }

            switch (_configuration.ArmbandUniform4)
            {

                case ArmbandUni4.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "4Akihiko", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni4.Off:

                    break;


                default: break;
            }

            switch (_configuration.SEESUniform4)
            {

                case SEESUni4.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "4Akihiko", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni4.Off:

                    break;


                default: break;
            }

            switch (_configuration.BeachOutfit4)
            {

                case BeachUni4.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "4Akihiko", "102Beach-Outfit", "1BASE", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case BeachUni4.Off:

                    break;


                default: break;
            }

            switch (_configuration.DormOutfit4)
            {

                case DormUni4.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "4Akihiko", "103Dorm-Outfit", "1BASE", "Just-A-Phase (Dorm Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case DormUni4.Off:

                    break;



                default: break;
            }

            switch (_configuration.WinterUniform5)
            {

                case WinterUni5.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "5Mitsuru", "1Winter-Outfit", "1BASE", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterUni5.Off:

                    break;



                default: break;
            }

            switch (_configuration.SummerUniform5)
            {

                case SummerUni5.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "5Mitsuru", "2Summer-Outfit", "1BASE", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerUni5.Off:

                    break;



                default: break;
            }

            switch (_configuration.SummerGarbb5)
            {

                case SummerGarb5.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "5Mitsuru", "5Summer-Garb", "1BASE", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerGarb5.Off:

                    break;


                default: break;
            }


            switch (_configuration.WinterGarbb5)
            {

                case WinterGarb5.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "5Mitsuru", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterGarb5.Off:

                    break;



                default: break;
            }

            switch (_configuration.ArmbandUniform5)
            {

                case ArmbandUni5.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "5Mitsuru", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni5.Off:

                    break;


                default: break;
            }

            switch (_configuration.SEESUniform5)
            {

                case SEESUni5.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "5Mitsuru", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni5.Off:

                    break;


                default: break;
            }

            switch (_configuration.BeachOutfit5)
            {

                case BeachUni5.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "5Mitsuru", "102Beach-Outfit", "1BASE", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case BeachUni5.Off:

                    break;


                default: break;
            }

            switch (_configuration.DormOutfit5)
            {

                case DormUni5.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "5Mitsuru", "103Dorm-Outfit", "1BASE", "Just-A-Phase (Dorm Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case DormUni5.Off:

                    break;



                default: break;
            }

            switch (_configuration.WinterUniform6)
            {

                case WinterUni6.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "6Fuuka", "1Winter-Outfit", "1BASE", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterUni6.Off:

                    break;



                default: break;
            }

            switch (_configuration.SummerUniform6)
            {

                case SummerUni6.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "6Fuuka", "2Summer-Outfit", "1BASE", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerUni6.Off:

                    break;



                default: break;
            }

            switch (_configuration.SummerGarbb6)
            {

                case SummerGarb6.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "6Fuuka", "5Summer-Garb", "1BASE", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerGarb6.Off:

                    break;


                default: break;
            }


            switch (_configuration.WinterGarbb6)
            {

                case WinterGarb6.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "6Fuuka", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterGarb6.Off:

                    break;



                default: break;
            }

            switch (_configuration.ArmbandUniform6)
            {

                case ArmbandUni6.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "6Fuuka", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni6.Off:

                    break;


                default: break;
            }

            switch (_configuration.SEESUniform6)
            {

                case SEESUni6.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "6Fuuka", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni6.Off:

                    break;


                default: break;
            }

            switch (_configuration.BeachOutfit6)
            {

                case BeachUni6.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "6Fuuka", "102Beach-Outfit", "1BASE", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case BeachUni6.Off:

                    break;


                default: break;
            }


            switch (_configuration.WinterUniform7)
            {

                case WinterUni7.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "7Aigis", "1Winter-Outfit", "1BASE", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterUni7.Off:

                    break;



                default: break;
            }
        


            switch (_configuration.WinterGarbb7)
            {

                case WinterGarb7.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "7Aigis", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterGarb7.Off:

                    break;



                default: break;
            }

            switch (_configuration.ArmbandUniform7)
            {

                case ArmbandUni7.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "7Aigis", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni7.Off:

                    break;


                default: break;
            }

            switch (_configuration.SEESUniform7)
            {

                case SEESUni7.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "7Aigis", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni7.Off:

                    break;


                default: break;
            }

            switch (_configuration.BeachOutfit7)
            {

                case BeachUni7.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "7Aigis", "102Beach-Outfit", "1BASE", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case BeachUni7.Off:

                    break;


                default: break;
            }



            switch (_configuration.WinterUniform8)
            {

                case WinterUni8.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "8Ken", "1Winter-Outfit", "1BASE", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterUni8.Off:

                    break;

                case WinterUni8.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "8Ken", "1Winter-Outfit", "4BP", "Just-A-Phase (Winter Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SummerUniform8)
            {

                case SummerUni8.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "8Ken", "2Summer-Outfit", "1BASE", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerUni8.Off:

                    break;

                case SummerUni8.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "8Ken", "2Summer-Outfit", "4BP", "Just-A-Phase (Summer Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SummerGarbb8)
            {

                case SummerGarb8.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "8Ken", "5Summer-Garb", "1BASE", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerGarb8.Off:

                    break;

                case SummerGarb8.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "8Ken", "5Summer-Garb", "4BP", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }


            switch (_configuration.WinterGarbb8)
            {

                case WinterGarb8.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "8Ken", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterGarb8.Off:

                    break;

                case WinterGarb8.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "8Ken", "6Winter-Garb", "4BP", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.ArmbandUniform8)
            {

                case ArmbandUni8.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "8Ken", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni8.Off:

                    break;

                case ArmbandUni8.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "8Ken", "51Armband-Outfit", "4BP", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SEESUniform8)
            {

                case SEESUni8.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "8Ken", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni8.Off:

                    break;

                case SEESUni8.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "8Ken", "52Sees-Outfit", "4BP", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.BeachOutfit8)
            {

                case BeachUni8.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "8Ken", "102Beach-Outfit", "1BASE", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case BeachUni8.Off:

                    break;

                case BeachUni8.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "8Ken", "102Beach-Outfit", "4BP", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }








            switch (_configuration.SummerGarbb9)
            {

                case SummerGarb9.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "9Koromaru", "5Summer-Garb", "1BASE", "Just-A-Phase (Summer Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SummerGarb9.Off:

                    break;


                default: break;
            }


            switch (_configuration.WinterGarbb9)
            {

                case WinterGarb9.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "9Koromaru", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case WinterGarb9.Off:

                    break;



                default: break;
            }

            switch (_configuration.ArmbandUniform9)
            {

                case ArmbandUni9.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "9Koromaru", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni9.Off:

                    break;


                default: break;
            }

            switch (_configuration.SEESUniform9)
            {

                case SEESUni9.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "9Koromaru", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni9.Off:

                    break;


                default: break;
            }




            switch (_configuration.WinterGarbb10)
            {

                case WinterGarb10.Base:
                    var WinUniPath10 = Path.Join(modDir, "costumes", "10Shinji", "6Winter-Garb", "1BASE", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniPath10);
                    break;

                case WinterGarb10.Off:

                    break;

                case WinterGarb10.BlackParade:
                    var WinUniBPath = Path.Join(modDir, "costumes", "10Shinji", "6Winter-Garb", "4BP", "Just-A-Phase (Winter Garb).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                default: break;
            }

            switch (_configuration.ArmbandUniform10)
            {

                case ArmbandUni10.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "10Shinji", "51Armband-Outfit", "1BASE", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case ArmbandUni10.Off:

                    break;

                case ArmbandUni10.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "10Shinji", "51Armband-Outfit", "4BP", "Just-A-Phase (Uniform & Armband).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.SEESUniform10)
            {

                case SEESUni10.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "10Shinji", "52Sees-Outfit", "1BASE", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case SEESUni10.Off:

                    break;

                case SEESUni10.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "10Shinji", "52Sees-Outfit", "4BP", "Just-A-Phase (SEES Uniform).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.BeachOutfit10)
            {

                case BeachUni10.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "10Shinji", "102Beach-Outfit", "1BASE", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case BeachUni10.Off:

                    break;

                case BeachUni10.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "10Shinji", "102Beach-Outfit", "4BP", "Just-A-Phase (Beach Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }

            switch (_configuration.DormOutfit10)
            {

                case DormUni10.Base:
                    var WinUniBPath = Path.Join(modDir, "costumes", "10Shinji", "103Dorm-Outfit", "1BASE", "Just-A-Phase (Dorm Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniBPath);
                    break;

                case DormUni10.Off:

                    break;

                case DormUni10.BlackParade:
                    var WinUniFPath = Path.Join(modDir, "costumes", "10Shinji", "103Dorm-Outfit", "4BP", "Just-A-Phase (Dorm Outfit).yaml");
                    CostumeApi.AddOverridesFile(WinUniFPath);
                    break;

                default: break;
            }


























            //

            // For more information about this template, please see
            // https://reloaded-project.github.io/Reloaded-II/ModTemplate/

            // If you want to implement e.g. unload support in your mod,
            // and some other neat features, override the methods in ModBase.

            // TODO: Implement some mod logic


        }

        #region Standard Overrides
        public override void ConfigurationUpdated(Config configuration)
        {
            // Apply settings from configuration.
            // ... your code here.

            _configuration = configuration;
            _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");


        }
        #endregion

        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Mod() { }
#pragma warning restore CS8618
        #endregion
    }
}