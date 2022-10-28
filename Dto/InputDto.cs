namespace DiffancyAssignment.Dto
{
    public class InputDto
    {
        public string transaction_uti { get; set; }
        public string isin { get; set; }
        public double notional { get; set; }
        public string notional_currency { get; set; }
        public string transaction_type { get; set; }
        public DateTime transaction_datetime { get; set; }
        public double rate { get; set; }
        public string lei { get; set; }
    }
}