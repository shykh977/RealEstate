namespace PropertyBackend.Model
{
    public class Areas
    {
       public int LocationID              {get;set;}
       public int CityID                  {get;set;}
       public int CPID                    {get;set;}
       public int Level                   {get;set;}
       public int Latitude                {get;set;}
       public int Longitude               {get;set;}
      
        public string? LocationName       {get;set;} 
        public string? Description { get;set;}  
       public int IsDelete                {get;set;}
       public int SortBy { get; set; }
    }
}
