using Microsoft.AspNetCore.Identity;

namespace BackEndProject.Data.Models
{
    public class Dish 
{
    public Guid id { get; set; }
    public string Name { get; set; }

    public int Price { get; set; }
    public string Description { get; set; }
    public bool  IsVegetarian { get; set; }
    public string Photo { get; set; } 

    public Category Category {get; set;}

    public ICollection<Rating> Ratings {get;set;}
    public DateTime ModifyDateTime { get; set; }
    public DateTime? DeleteDate { get; set; }

}

}

