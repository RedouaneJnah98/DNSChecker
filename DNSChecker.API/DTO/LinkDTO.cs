namespace DNSChecker.API.DTO;

public class LinkDTO
{
    public LinkDTO(string href, string type, string rel)
    {
        Href = href;
        Type = type;
        Rel = rel;
    }

    public string Href { get; private set; }
    public string Type { get; private set; }
    public string Rel { get; private set; }
}