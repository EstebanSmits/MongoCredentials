public class Milestone
{
    public int? id { get; set; }
    public string description { get; set; }
    public int? stoned_year { get; set; }
    public int? stoned_month { get; set; }
    public int? stoned_day { get; set; }
    public string source_url { get; set; }
    public object source_text { get; set; }
    public string source_description { get; set; }
    public string stoneable_type { get; set; }
    public object stoned_value { get; set; }
    public object stoned_value_type { get; set; }
    public object stoned_acquirer { get; set; }
    public Stoneable stoneable { get; set; }
}