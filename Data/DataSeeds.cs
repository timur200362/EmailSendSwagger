using Dogs.WebApi.Models;

namespace Dogs.WebApi.Data
{
    public static class DataSeeds
    {
        public static readonly List<Dog> DogsList = new List<Dog>
        {
            new Dog { 
                Id = Guid.NewGuid(),
                Description = "Это красивая собака",
                Family=null,
                MaxAge=15,
                MinAge=10,
                ImgUrl= "https://s1.1zoom.ru/big3/984/Canada_Parks_Lake_Mountains_Forests_Scenery_Rocky_567540_3840x2400.jpg",
                Weight=1000,
                ShortDescription="Это собака",
                Name="Диназавр",
                Height=120
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Это красивая собака2",
                Family=null,
                MaxAge=15,
                MinAge=10,
                ImgUrl= "https://s1.1zoom.ru/big3/984/Canada_Parks_Lake_Mountains_Forests_Scenery_Rocky_567540_3840x2400.jpg",
                Weight=1000,
                ShortDescription="Это собака2",
                Name="Диназавр2",
                Height=120
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Это красивая собака3",
                Family=null,
                MaxAge=15,
                MinAge=10,
                ImgUrl= "https://s1.1zoom.ru/big3/984/Canada_Parks_Lake_Mountains_Forests_Scenery_Rocky_567540_3840x2400.jpg",
                Weight=1000,
                ShortDescription="Это собака3",
                Name="Диназавр3",
                Height=120
            },
        };
        public static readonly List<Family> FamilyList = new List<Family>
        {
            new Family {
                Id = Guid.NewGuid(),
                Name="Семейство без шерсти",
                Description = "Это красивая собака",
            },
            new Family {
                Id = Guid.NewGuid(),
                Name="Семество с шёрсткой",
                Description = "Это красивая собака2",
            }
        };
    }
}
