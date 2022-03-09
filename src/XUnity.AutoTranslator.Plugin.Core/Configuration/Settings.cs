using System;
using System.Collections.Generic;

namespace XUnity.AutoTranslator.Plugin.Core.Configuration
{
   internal static class Settings
   {
      // cannot be changed
      public static readonly int MaxFailuresForSameTextPerEndpoint = 3;
      public static readonly string TranslatorsFolder = "Translators";
      public static readonly int MaxMaxCharactersPerTranslation = 2500;
      public static readonly string DefaultLanguage = "en";
      public static readonly string DefaultFromLanguage = "ja";
      public static readonly string EnglishLanguage = "en";
      public static readonly string Romaji = "romaji";
      public static readonly int MaxErrors = 5;
      public static readonly float ClipboardDebounceTime = 1.250f;
      public static readonly int MaxTranslationsBeforeShutdown = 8000;
      public static readonly int MaxUnstartedJobs = 4000;
      public static readonly float IncreaseBatchOperationsEvery = 30;
      public static readonly int MaximumStaggers = 6;
      public static readonly int PreviousTextStaggerCount = 3;
      public static readonly int MaximumConsecutiveFramesTranslated = 90;
      public static readonly int MaximumConsecutiveSecondsTranslated = 60;
      public static bool FromLanguageUsesWhitespaceBetweenWords = false;
      public static bool ToLanguageUsesWhitespaceBetweenWords = false;
      public static string ApplicationName;
      public static float Timeout = 150.0f;
      public static string RedirectedResourcesPath;
      public static readonly int MaxImguiKeyCacheCount = 10000;

      public static Dictionary<string, string> Replacements = new Dictionary<string, string>();
      public static Dictionary<string, string> Preprocessors = new Dictionary<string, string>();
      public static Dictionary<string, string> Postprocessors = new Dictionary<string, string>();
      //public static List<RegexTranslationSplitter> Patterns = new List<RegexTranslationSplitter>();

      public static bool SimulateError = false;
      public static bool SimulateDelayedError = false;

      public static bool InvokeEvents = true;
      public static Action<object> RemakeTextData = null;
      public static Action<object> SetCurText = null;

      public static bool IsShutdown = false;
      public static int TranslationCount = 0;
      public static int MaxAvailableBatchOperations = 50;

      public static readonly float MaxTranslationsQueuedPerSecond = 5;
      public static readonly int MaxSecondsAboveTranslationThreshold = 30;
      public static readonly int TranslationQueueWatchWindow = 6;

      public static bool RequiresToggleFix = false;

      // can be changed
      public static string ServiceEndpoint;
      public static string FallbackServiceEndpoint;
      public static string Language;
      public static string FromLanguage;
      public static string OutputFile;
      public static string SubstitutionFile;
      public static string PreprocessorsFile;
      public static string PostprocessorsFile;
      public static string TranslationDirectory;
      public static int MaxCharactersPerTranslation;
      public static bool EnableConsole;
      public static string AutoTranslationsFilePath;
      public static string SubstitutionFilePath;
      public static string PreprocessorsFilePath;
      public static string PostprocessorsFilePath;
      public static string TranslationsPath;
      public static string TexturesPath;
      public static string TranslatorsPath;
      public static bool EnableIMGUI;
      public static bool EnableUGUI;
      public static bool EnableNGUI;
      public static bool EnableTextMeshPro;
      public static bool EnableTextMesh;
      public static bool EnableFairyGUI;
      public static bool InitializeHarmonyDetourBridge;
      public static bool IgnoreWhitespaceInDialogue;
      public static bool IgnoreWhitespaceInNGUI;
      public static int MinDialogueChars;
      public static int ForceSplitTextAfterCharacters;
      public static bool EnableMigrations;
      public static string MigrationsTag;
      public static bool EnableBatching;
      public static bool EnableUIResizing;
      public static bool UseStaticTranslations;
      public static string OverrideFont;
      public static int? OverrideFontSize;
      public static string OverrideFontTextMeshPro;
      public static string UserAgent;
      public static bool DisableCertificateValidation;
      public static float? ResizeUILineSpacingScale;
      public static bool ForceUIResizing;
      public static string[] IgnoreTextStartingWith;
      public static HashSet<string> GameLogTextPaths;
      public static bool TextGetterCompatibilityMode;
      public static bool ForceMonoModHooks;
      public static bool CacheRegexPatternResults;
      public static bool CacheRegexLookups;
      public static bool CacheWhitespaceDifferences;
      public static bool GenerateStaticSubstitutionTranslations;
      public static bool GeneratePartialTranslations;
      public static bool EnableTranslationScoping;
      public static bool EnableSilentMode;
      public static HashSet<string> BlacklistedIMGUIPlugins;
      public static bool EnableTextPathLogging;
      public static bool OutputUntranslatableText;
      public static bool IgnoreVirtualTextSetterCallingRules;
      public static int MaxTextParserRecursion;
      public static bool HtmlEntityPreprocessing;
      public static bool HandleRichText;
      public static bool EnableTranslationHelper;
      public static bool OutputTooLongText;
      public static bool TemplateAllNumberAway;
      public static bool ReloadTranslationsOnFileChange;
      public static bool DisableTextMeshProScrollInEffects;
      public static bool CacheParsedTranslations;

      public static string TextureDirectory;
      public static bool EnableTextureTranslation;
      public static bool EnableTextureDumping;
      public static bool EnableTextureToggling;
      public static bool EnableTextureScanOnSceneLoad;
      public static bool EnableSpriteRendererHooking;
      public static bool LoadUnmodifiedTextures;
      public static bool DetectDuplicateTextureNames;
      public static bool EnableLegacyTextureLoading;
      public static HashSet<string> DuplicateTextureNames;
      public static bool CacheTexturesInMemory;
      public static bool EnableSpriteHooking;

      public static string PreferredStoragePath;
      public static bool EnableDumping;
      public static bool EnableTextAssetRedirector;
      public static bool LogAllLoadedResources;
      public static bool CacheMetadataForAllFiles;


      public static float Height;
      public static float Width;
      public static HashSet<string> EnabledTranslators;

      public static bool CopyToClipboard;
      public static int MaxClipboardCopyCharacters;
   }
}
