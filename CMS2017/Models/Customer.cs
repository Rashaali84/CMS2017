using System;
using System.ComponentModel.DataAnnotations;

namespace CMS2017.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

  
public class MathUtils
    {
        public static double Average(int a, int b)
        {
            return ((a + b) / 2);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Average(2, 1));
        }
    }
}
}