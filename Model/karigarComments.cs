namespace PropertyBackend.Model
{
    public class karigarComments
    {
       public Guid karigarCommentsId    {get;set;}
       public Guid karigarId            {get;set;}
       public Guid CustomerId { get;set;}
       public string? Comment { get; set; }
       public double Rating { get; set; }
    }
}
