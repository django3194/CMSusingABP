using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Vishnu_MyProject.Localization
{
    public static class Vishnu_MyProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Vishnu_MyProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Vishnu_MyProjectLocalizationConfigurer).GetAssembly(),
                        "Vishnu_MyProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
