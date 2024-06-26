namespace PropertyBackend.Model
{
    public class DeviceIdentity
    {
      public Guid    DeviceIdentityId         {get;set;}
      public string  IP                     {get;set;}
      public string  DeviceName             {get;set;}
      public string  DeviceModal            {get;set;}
      public string  Location               {get;set;}
      public string  SubLocation            {get;set;}
      public string  Lat                    {get;set;}
      public string  Long                   { get; set; }
      public string  Postal                  { get; set; }
    }
}
