using CityInfo.Api.Models;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {

        public List<CityDto> Cities { get; set; }

        public static  CitiesDataStore Current { get; } =  new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {

                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The one with the big park",
                    Pointofinterests = new List<PointofinterestDto>()
                    {
                        new PointofinterestDto()
                        {
                            Id=1,
                            Name="Mohammed",
                            Description = "He is a good man"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Paris",
                    Description = "The Beautiful City",
                    Pointofinterests= new List<PointofinterestDto>()
                    {
                        new PointofinterestDto()
                        {
                            Id = 2,
                            Name = "khalid",
                            Description ="Khlaid lives in Cairo"
                           
                        }
                    }

                }



            };
        }
    }
}
