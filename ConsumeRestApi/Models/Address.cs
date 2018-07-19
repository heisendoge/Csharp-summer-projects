namespace Models
{
    public class Address
    {
        public Address()
        {
            geo = new Geo();
        }
       public string street{get;set;}
       public string suite {get;set;}
       public string city { get; set; }
       public string zipcode { get; set; }
       public Geo geo { get; set; }

        public override string ToString()
        {
            string result =
                street
                + "\n" + suite
                + "\n" + city
                + "\n" + zipcode
                + "\n" + geo.ToString();
            return result;
        }
    }
}