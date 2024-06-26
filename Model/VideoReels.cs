namespace PropertyBackend.Model
{
    public class VideoReels
    {


      public Guid   VideoReelsId     {get;set;}
      public Guid    AgentId          {get;set;}
      public string? Reel           { get; set; }
      public string? ReelUrl        { get; set; }
      public byte[] BinRells { get; set; }


    }
}
