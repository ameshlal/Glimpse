using System.Configuration;

namespace Glimpse.Core2.Configuration
{
    public class LoggingElement : ConfigurationElement
    {
        [ConfigurationProperty("level", DefaultValue = LoggingLevel.Off)]
        public LoggingLevel Level
        {
            get { return (LoggingLevel)base["level"]; }
            set { base["level"] = value; }
        }
    }
}