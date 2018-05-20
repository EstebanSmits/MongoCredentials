using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

[BsonIgnoreExtraElements]
public class Company
{
    
    [BsonId]
    public ObjectId id { get; set; }
    public string name { get; set; }
    public string permalink { get; set; }
    public string crunchbase_url { get; set; }
    public string homepage_url { get; set; }
    public string blog_url { get; set; }
    public string blog_feed_url { get; set; }
    public string twitter_username { get; set; }
    public string category_code { get; set; }
    public int? number_of_employees { get; set; }
    public int? founded_year { get; set; }
    public int? founded_month { get; set; }
    public int? founded_day { get; set; }

    public int? deadpooled_day { get; set; }
    public int? deadpooled_month { get; set; }
    public int? deadpooled_year { get; set; }
    public string deadpooled_url{ get; set; }
    public string tag_list { get; set; }
    public string alias_list { get; set; }
    public string email_address { get; set; }
    public string phone_number { get; set; }
    public string description { get; set; }
    public string created_at { get; set; }
    public string updated_at { get; set; }
    public string overview { get; set; }
    public Image image { get; set; }
    public List<Product> products { get; set; }
    public List<Relationship> relationships { get; set; }
    public List<Competition> competitions { get; set; }
    public List<object> providerships { get; set; }
    public string total_money_raised { get; set; }
    public List<FundingRound> funding_rounds { get; set; }
    public List<object> investments { get; set; }
    public Acquisition acquisition { get; set; }
    public List<object> acquisitions { get; set; }
    public List<Office> offices { get; set; }
    public List<Milestone> milestones { get; set; }
    public List<object> video_embeds { get; set; }
    public List<Screenshot> screenshots { get; set; }
    public List<ExternalLink> external_links { get; set; }
    public List<object> partners { get; set; }
}