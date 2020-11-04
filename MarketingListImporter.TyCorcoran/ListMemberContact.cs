using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace MarketingListImporter.TyCorcoran
{
    public class ListMemberContact : IListMember
    {
        public ListMemberContact() {}

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string emailaddress1 { get; set; }
        public string parentcustomerid { get; set; }
        public string jobtitle { get; set; }
        public string telephone1 { get; set; }
        public string telephone2 { get; set; }
        public string telephone3 { get; set; }
        public string mobilephone { get; set; }
        public string address1_line1 { get; set; }
        public string address1_line2 { get; set; }
        public string address1_line3 { get; set; }
        public string address1_city { get; set; }
        public string address1_postalcode { get; set; }
        public string address1_stateorprovince { get; set; }
        public string address1_country { get; set; }
        public string address1_county { get; set; }
        public double? address1_latitude { get; set; }
        public double? address1_longitude { get; set; }
        public string description { get; set; }


        public EntityCollection ReturnExistingMemberCollection(IOrganizationService service)
        {
            var xml = Data.ReturnExistingUserXml("contact", emailaddress1);
            return service.RetrieveMultiple(new FetchExpression(xml));
        }
        public ImportLog ProcessMember(IOrganizationService service) //new member
        {
            var importLog = new ImportLog();
            try
            {
                Entity parentAccount = null;
                Entity companyAccount = Data.TryGetAccountByName(parentcustomerid, service);
                if (companyAccount != null)
                {
                    parentAccount = Data.GetParentAccount(companyAccount, service);
                }
                var newContact = new Entity("contact")
                {
                    ["firstname"] = firstname,
                    ["lastname"] = lastname,
                    ["emailaddress1"] = emailaddress1,
                    ["parentcustomerid"] = (parentAccount != null) ? new EntityReference("account", parentAccount.Id) : default,
                    ["jobtitle"] = jobtitle,
                    ["telephone1"] = telephone1,
                    ["telephone2"] = telephone2,
                    ["telephone3"] = telephone3,
                    ["mobilephone"] = mobilephone,
                    ["address1_line1"] = address1_line1,
                    ["address1_line2"] = address1_line2,
                    ["address1_line3"] = address1_line3,
                    ["address1_city"] = address1_city,
                    ["address1_postalcode"] = address1_postalcode,
                    ["address1_stateorprovince"] = address1_stateorprovince,
                    ["address1_country"] = address1_country,
                    ["address1_county"] = address1_county,
                    ["address1_latitude"] = address1_latitude,
                    ["address1_longitude"] = address1_longitude,
                    ["description"] = description
                };
                newContact.Id = service.Create(newContact);
                importLog.Type = "Success";
                importLog.CreateMode = "New";
                importLog.Result = $"Associated new contact {emailaddress1} with Id: {newContact.Id}";
                importLog.memberId = newContact.Id;
            }
            catch (Exception ex)
            {
                importLog.Type = "Failure";
                importLog.CreateMode = "Failure";
                importLog.Result = ex.Message;
                importLog.memberId = default;
            }
            return importLog;
        }
        public ImportLog ProcessMember(IOrganizationService service, DataCollection<Entity> entityCollection) //existing member
        {
            var importLog = new ImportLog();
            try
            {
                var existingContact = entityCollection.First();
                importLog.Type = "Success";
                importLog.CreateMode = "Existing";
                importLog.Result = $"Associated existing contact {(string)existingContact.Attributes["emailaddress1"]} with Id: {existingContact.Id}";
                importLog.memberId = existingContact.Id;
            }
            catch (Exception ex)
            {
                importLog.Type = "Failure";
                importLog.CreateMode = "Failure";
                importLog.Result = ex.Message;
                importLog.memberId = default;
            }
            return importLog;
        }
    }
}
