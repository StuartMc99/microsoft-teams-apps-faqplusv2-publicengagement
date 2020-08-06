public class MessageBack
{
    public string UserQuestion { get; set; }
    public string KnowledgeBaseAnswer { get; set; }
    public Msteams msteams { get; set; }
}

public class Msteams
{
    public string type { get; set; }
    public string text { get; set; }
    public string displayText { get; set; }
}
