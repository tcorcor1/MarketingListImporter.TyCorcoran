using System;

namespace MarketingListImporter.TyCorcoran
{
    public class ImportLog
    {
        public string Type;
        public string Result;
        public string CreateMode;
        public string Message => $"{Type}: {Result}";
        public Guid memberId;
        public double ImportNewMemberCount;
        public double ImportExistingMemberCount;
        public double ImportFailureCount;
    }
}
