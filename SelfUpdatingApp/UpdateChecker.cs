using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Reflection;
using System.Xml;
using SelfUpdatingApp.Properties;

namespace SelfUpdatingApp
{
    public class UpdateChecker
    {
        private const string DefaultApplicationVersion = "1.0.0.0";

        public static string GetApplicationVersion()
        {
            return ApplicationDeployment.IsNetworkDeployed
                ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                : DefaultApplicationVersion;
        }

        public Boolean IsUpdateNeeded()
        {
            var currentVersion = GetApplicationVersion();
            XmlDocument installerProperties = GetInstallerProperties();

            var installerVersion = GetInstallerVersionFromProperties(installerProperties);

            if (installerVersion == null)
            {
                return false;
            }

            return !currentVersion.Equals(installerVersion);
        }

        private string GetInstallerVersionFromProperties(XmlDocument installerProperties)
        {
            if (installerProperties == null)
            {
                return null;
            }

            XmlNodeList propertiesChildNodes = installerProperties.ChildNodes;
            XmlNode assembly = propertiesChildNodes.Item(1);
            if (assembly == null || !assembly.HasChildNodes)
            {
                return null;
            }

            XmlNodeList assemblyIdentityChildNodes = assembly.ChildNodes;
            XmlNode assemblyIdentity = assemblyIdentityChildNodes.Item(0);

            return assemblyIdentity?.Attributes?[Settings.Default.manifestVersionFieldName].Value;
        }

        private XmlDocument GetInstallerProperties()
        {
            try
            {
                XmlDocument installerProperties = new XmlDocument();

                installerProperties.Load(Settings.Default.installerPath +
                                         Assembly.GetExecutingAssembly().GetName().Name +
                                         Settings.Default.applicationManifestExtension);

                return installerProperties;
            }
            catch (Exception e)
            {
                Debug.WriteLine(Resources
                    .UpdateChecker_GetInstallerProperties_Error_getting_properties_file__error_message__ + e.Message);

                return null;
            }
        }
    }
}