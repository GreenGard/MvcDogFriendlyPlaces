using System.ComponentModel.DataAnnotations;


namespace MvcDogFriendlyPlaces.Models
{
    public class DogFriendlyPlaces
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    
    }
}
