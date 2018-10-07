using System.Xml;
namespace TenPay.lib
{
    public class SafeXmlDocument:XmlDocument
    {
        public SafeXmlDocument()
        {
            this.XmlResolver = null;
        }
    }
}
