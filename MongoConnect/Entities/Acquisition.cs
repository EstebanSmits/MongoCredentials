public class Acquisition
{
    public int? price_amount { get; set; }
    public string price_currency_code { get; set; }
    public string term_code { get; set; }
    public string source_url { get; set; }
    public string source_description { get; set; }
    public int? acquired_year { get; set; }
    public int? acquired_month { get; set; }
    public int? acquired_day { get; set; }
    public AcquiringCompany acquiring_company { get; set; }
}