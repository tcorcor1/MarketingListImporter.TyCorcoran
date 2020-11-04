using Microsoft.Xrm.Sdk;

namespace MarketingListImporter.TyCorcoran
{
    public interface IListMember
    {
        EntityCollection ReturnExistingMemberCollection(IOrganizationService service);
        ImportLog ProcessMember(IOrganizationService service, DataCollection<Entity> entityCollection);
        ImportLog ProcessMember(IOrganizationService service);
    }
}
