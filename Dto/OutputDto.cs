namespace DiffancyAssignment.Dto
{
    public class OutputDto : InputDto
    {
        public LegalName legalName { get; set; }
        public LegalAddress legalAddress { get; set; }
        public List<string> bic { get; set; }
        public double transaction_costs =>
            legalAddress.country == "GB" ? notional * rate - notional :
            legalAddress.country == "NL" ? Math.Abs(notional * (1 / rate) - notional) : 0;
    }
}