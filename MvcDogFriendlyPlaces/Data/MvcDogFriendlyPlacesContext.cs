using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcDogFriendlyPlaces.Models;

namespace MvcDogFriendlyPlaces.Data
{
    public class MvcDogFriendlyPlacesContext : DbContext
    {
        public MvcDogFriendlyPlacesContext (DbContextOptions<MvcDogFriendlyPlacesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcDogFriendlyPlaces.Models.DogFriendlyPlaces> DogFriendlyPlaces { get; set; } = default!;
    }
}
