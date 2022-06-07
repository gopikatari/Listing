using System.ComponentModel.DataAnnotations.Schema;

namespace Listing.API.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { set; get; }
        public double Rating { set; get; }



        //RelationShips: Each Hotel has a country
        [ForeignKey(nameof(CountryId))]  //we can use like [foreignKEy("CountryId")]
        public int CountryId { get; set; }
        public Country Country { set; get; }
    }
}
