namespace Listing.API.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }


        //RelationShips :one country has many Hotels
        public virtual IList<Hotel> Hotels { get; set; }

    }
}
