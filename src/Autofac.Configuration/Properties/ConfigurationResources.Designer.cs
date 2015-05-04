// <auto-generated />
namespace Autofac.Configuration
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class ConfigurationResources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Autofac.Configuration.ConfigurationResources", typeof(ConfigurationResources).GetTypeInfo().Assembly);

        /// <summary>
        /// The {0} may not be empty.
        /// </summary>
        internal static string ArgumentMayNotBeEmpty
        {
            get { return GetString("ArgumentMayNotBeEmpty"); }
        }

        /// <summary>
        /// The {0} may not be empty.
        /// </summary>
        internal static string FormatArgumentMayNotBeEmpty(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentMayNotBeEmpty"), p0);
        }

        /// <summary>
        /// If 'name' is specified, 'service' must also be specified (component name='{0}'.)
        /// </summary>
        internal static string ServiceTypeMustBeSpecified
        {
            get { return GetString("ServiceTypeMustBeSpecified"); }
        }

        /// <summary>
        /// If 'name' is specified, 'service' must also be specified (component name='{0}'.)
        /// </summary>
        internal static string FormatServiceTypeMustBeSpecified(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ServiceTypeMustBeSpecified"), p0);
        }

        /// <summary>
        /// Unable to convert object of type '{0}' to type '{1}'.
        /// </summary>
        internal static string TypeConversionUnsupported
        {
            get { return GetString("TypeConversionUnsupported"); }
        }

        /// <summary>
        /// Unable to convert object of type '{0}' to type '{1}'.
        /// </summary>
        internal static string FormatTypeConversionUnsupported(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TypeConversionUnsupported"), p0, p1);
        }

        /// <summary>
        /// The type '{0}' specified in the TypeConverterAttribute is not a TypeConverter.
        /// </summary>
        internal static string TypeConverterAttributeTypeNotConverter
        {
            get { return GetString("TypeConverterAttributeTypeNotConverter"); }
        }

        /// <summary>
        /// The type '{0}' specified in the TypeConverterAttribute is not a TypeConverter.
        /// </summary>
        internal static string FormatTypeConverterAttributeTypeNotConverter(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TypeConverterAttributeTypeNotConverter"), p0);
        }

        /// <summary>
        /// The type '{0}' could not be found. It may require assembly qualification, e.g. "MyType, MyAssembly".
        /// </summary>
        internal static string TypeNotFound
        {
            get { return GetString("TypeNotFound"); }
        }

        /// <summary>
        /// The type '{0}' could not be found. It may require assembly qualification, e.g. "MyType, MyAssembly".
        /// </summary>
        internal static string FormatTypeNotFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TypeNotFound"), p0);
        }

        /// <summary>
        /// The value '{0}' is not valid for the auto activate setting. Valid values are 'true' and 'false'.
        /// </summary>
        internal static string UnrecognisedAutoActivate
        {
            get { return GetString("UnrecognisedAutoActivate"); }
        }

        /// <summary>
        /// The value '{0}' is not valid for the auto activate setting. Valid values are 'true' and 'false'.
        /// </summary>
        internal static string FormatUnrecognisedAutoActivate(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnrecognisedAutoActivate"), p0);
        }

        /// <summary>
        /// The value '{0}' is not valid for the inject properties setting. Valid values are 'true' and 'false'.
        /// </summary>
        internal static string UnrecognisedInjectProperties
        {
            get { return GetString("UnrecognisedInjectProperties"); }
        }

        /// <summary>
        /// The value '{0}' is not valid for the inject properties setting. Valid values are 'true' and 'false'.
        /// </summary>
        internal static string FormatUnrecognisedInjectProperties(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnrecognisedInjectProperties"), p0);
        }

        /// <summary>
        /// The value '{0}' is not valid for the ownership setting. Valid values are 'lifetime-scope' (the default) and 'external'.
        /// </summary>
        internal static string UnrecognisedOwnership
        {
            get { return GetString("UnrecognisedOwnership"); }
        }

        /// <summary>
        /// The value '{0}' is not valid for the ownership setting. Valid values are 'lifetime-scope' (the default) and 'external'.
        /// </summary>
        internal static string FormatUnrecognisedOwnership(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnrecognisedOwnership"), p0);
        }

        /// <summary>
        /// The value '{0}' is not valid for the instance scope setting. Valid values are 'single-instance', 'per-dependency' (the default), 'per-lifetime-scope', and 'per-request'.
        /// </summary>
        internal static string UnrecognisedScope
        {
            get { return GetString("UnrecognisedScope"); }
        }

        /// <summary>
        /// The value '{0}' is not valid for the instance scope setting. Valid values are 'single-instance', 'per-dependency' (the default), 'per-lifetime-scope', and 'per-request'.
        /// </summary>
        internal static string FormatUnrecognisedScope(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnrecognisedScope"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
