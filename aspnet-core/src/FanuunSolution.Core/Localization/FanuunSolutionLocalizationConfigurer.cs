using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace FanuunSolution.Localization
{
    public static class FanuunSolutionLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(FanuunSolutionConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FanuunSolutionLocalizationConfigurer).GetAssembly(),
                        "FanuunSolution.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
