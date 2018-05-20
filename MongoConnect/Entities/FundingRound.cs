using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

[BsonIgnoreExtraElements]
public class FundingRound
{
    [BsonElement("id")]
    public int? id { get; set; }
    public string round_code { get; set; }
    public string source_url { get; set; }
    public string source_description { get; set; }
    public int? raised_amount { get; set; }
    public string raised_currency_code { get; set; }
    public int? funded_year { get; set; }
    public int? funded_month { get; set; }
    public int? funded_day { get; set; }
    public List<Investment> investments { get; set; }
}