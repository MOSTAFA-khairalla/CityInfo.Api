namespace CityInfo.Api.Models
{
    public class CityDto
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointofinterests 
        {
            get
            {
                return Pointofinterests.Count;  
            }
           
        
        
        }

        public ICollection<PointofinterestDto> Pointofinterests { get; set; }
        = new List<PointofinterestDto>();


    }
}
