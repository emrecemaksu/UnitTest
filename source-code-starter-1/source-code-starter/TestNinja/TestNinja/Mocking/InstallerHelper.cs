using System.Net;

namespace TestNinja.Mocking
{
    public class InstallerHelper
    {
        private string _setupDestinationFile;
        private readonly IHelper _helper;

        public InstallerHelper(IHelper helper)
        {
            _helper = helper;
        }

        public bool DownloadInstaller(string customerName, string installerName)
        {
            
            try
            {
                _helper.DownloadFile(
                    string.Format("http://example.com/{0}/{1}",
                        customerName,
                        installerName),
                    _setupDestinationFile);

                return true;
            }
            catch (WebException)
            {
                return false; 
            }
        }
    }
}