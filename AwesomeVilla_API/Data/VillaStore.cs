using AwesomeVilla_API.Models.DTO;

namespace AwesomeVilla_API.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
           {
               new VillaDTO{Id = 1, Name = "Pool View", Occupancy= 100, Sqft = 4},
               new VillaDTO{Id = 2, Name = "Beach View", Occupancy= 300, Sqft = 3}
           };
    }
}
