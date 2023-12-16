using Microsoft.AspNetCore.Identity;

namespace BackEndProject.Data.Models{

    public class Rating 
    {
        public Guid id { get; set; }

        public int Value { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public DateTime? DeleteDate { get; set; }

    }
}
