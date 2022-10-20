using DotNet.CommonHelpers.Exceptions;
using System.ComponentModel;
using System.Configuration;

namespace DotNet.CommonHelpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class AppSettings
    {
        /// <summary>
        /// Easier reading of <c>App.config</c> parameters.
        /// </summary>
        /// <example>        
        /// <code lang="csharp">
        /// var timeret = AppSettings.Get&lt;int&gt;("Timeout");                
        /// </code>
        /// </example>
        /// <typeparam name="T">Type of the parameter</typeparam>
        /// <param name="key">Appsettings key</param>
        /// <exception cref="AppSettingNotFoundException">Thrown when specified key is not found in the appsettings</exception>
        /// <returns></returns>
        public static T Get<T>(string key)
        {
            var appSetting = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrWhiteSpace(appSetting)) throw new AppSettingNotFoundException(key);

            var converter = TypeDescriptor.GetConverter(typeof(T));
            return (T)(converter.ConvertFromInvariantString(appSetting));            
                
        }
    }
}