using Newtonsoft.Json;

namespace DiffancyAssignment.Dto
{
    public class LeiRecord
    {
        public Meta meta { get; set; }
        public Links links { get; set; }
        public List<Datum> data { get; set; }
    }

    public class AssociatedEntity
    {
        public object lei { get; set; }
        public object name { get; set; }
    }

    public class Attributes
    {
        public string lei { get; set; }
        public Entity entity { get; set; }
        public Registration registration { get; set; }
        public List<string> bic { get; set; }
    }

    public class Datum
    {
        public string type { get; set; }
        public string id { get; set; }
        public Attributes attributes { get; set; }
        public Relationships relationships { get; set; }
        public Links links { get; set; }
    }

    public class DirectChildren
    {
        public Links links { get; set; }
    }

    public class DirectParent
    {
        public Links links { get; set; }
    }

    public class Entity
    {
        public LegalName legalName { get; set; }
        public List<OtherName> otherNames { get; set; }
        public List<object> transliteratedOtherNames { get; set; }
        public LegalAddress legalAddress { get; set; }
        public HeadquartersAddress headquartersAddress { get; set; }
        public RegisteredAt registeredAt { get; set; }
        public string registeredAs { get; set; }
        public string jurisdiction { get; set; }
        public string category { get; set; }
        public LegalForm legalForm { get; set; }
        public AssociatedEntity associatedEntity { get; set; }
        public string status { get; set; }
        public Expiration expiration { get; set; }
        public SuccessorEntity successorEntity { get; set; }
        public List<object> successorEntities { get; set; }
        public DateTime? creationDate { get; set; }
        public object subCategory { get; set; }
        public List<object> otherAddresses { get; set; }
        public List<object> eventGroups { get; set; }
    }

    public class Expiration
    {
        public object date { get; set; }
        public object reason { get; set; }
    }

    public class FieldModifications
    {
        public Links links { get; set; }
    }

    public class GoldenCopy
    {
        public DateTime publishDate { get; set; }
    }

    public class HeadquartersAddress
    {
        public string language { get; set; }
        public List<string> addressLines { get; set; }
        public object addressNumber { get; set; }
        public object addressNumberWithinBuilding { get; set; }
        public object mailRouting { get; set; }
        public string city { get; set; }
        public object region { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
    }

    public class Isins
    {
        public Links links { get; set; }
    }

    public class LegalAddress
    {
        public string language { get; set; }
        public List<string> addressLines { get; set; }
        public object addressNumber { get; set; }
        public object addressNumberWithinBuilding { get; set; }
        public object mailRouting { get; set; }
        public string city { get; set; }
        public object region { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
    }

    public class LegalForm
    {
        public string id { get; set; }
        public object other { get; set; }
    }

    public class LegalName
    {
        public string name { get; set; }
        public string language { get; set; }
    }

    public class LeiIssuer
    {
        public Links links { get; set; }
    }

    public class Links
    {
        public string first { get; set; }
        public string last { get; set; }
        public string related { get; set; }

        [JsonProperty("relationship-record")]
        public string RelationshipRecord { get; set; }

        [JsonProperty("lei-record")]
        public string LeiRecord { get; set; }

        [JsonProperty("relationship-records")]
        public string RelationshipRecords { get; set; }
        public string self { get; set; }
    }

    public class ManagingLou
    {
        public Links links { get; set; }
    }

    public class Meta
    {
        public GoldenCopy goldenCopy { get; set; }
        public Pagination pagination { get; set; }
    }

    public class OtherName
    {
        public string name { get; set; }
        public string language { get; set; }
        public string type { get; set; }
    }

    public class Pagination
    {
        public int currentPage { get; set; }
        public int perPage { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public int total { get; set; }
        public int lastPage { get; set; }
    }

    public class RegisteredAt
    {
        public string id { get; set; }
        public object other { get; set; }
    }

    public class Registration
    {
        public DateTime initialRegistrationDate { get; set; }
        public DateTime lastUpdateDate { get; set; }
        public string status { get; set; }
        public DateTime nextRenewalDate { get; set; }
        public string managingLou { get; set; }
        public string corroborationLevel { get; set; }
        public ValidatedAt validatedAt { get; set; }
        public string validatedAs { get; set; }
        public List<object> otherValidationAuthorities { get; set; }
    }

    public class Relationships
    {
        [JsonProperty("managing-lou")]
        public ManagingLou ManagingLou { get; set; }

        [JsonProperty("lei-issuer")]
        public LeiIssuer LeiIssuer { get; set; }

        [JsonProperty("field-modifications")]
        public FieldModifications FieldModifications { get; set; }

        [JsonProperty("direct-parent")]
        public DirectParent DirectParent { get; set; }

        [JsonProperty("ultimate-parent")]
        public UltimateParent UltimateParent { get; set; }

        [JsonProperty("direct-children")]
        public DirectChildren DirectChildren { get; set; }
        public Isins isins { get; set; }
    }

    public class SuccessorEntity
    {
        public object lei { get; set; }
        public object name { get; set; }
    }

    public class UltimateParent
    {
        public Links links { get; set; }
    }

    public class ValidatedAt
    {
        public string id { get; set; }
        public object other { get; set; }
    }


}