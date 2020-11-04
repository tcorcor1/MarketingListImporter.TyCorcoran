using System.IO;
using Microsoft.Xrm.Sdk;

namespace MarketingListImporter.TyCorcoran
{
    public static class Extensions
    {
        public static bool IsFileLocked(this FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
                return false;
            }
            catch (IOException)
            {
                return true;
            }
        }
        public static MarketingListItem ConvertToMarketingListItem(this Entity entity)
        {
            return new MarketingListItem()
            {
                Name = (string)entity.Attributes["listname"],
                Id = entity.Id
            };
        }
    }
}