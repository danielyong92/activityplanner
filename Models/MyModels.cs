using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BeltExam2.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        // Will not be mapped to your users table!
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }
        public List<Participate> ParticipatingActivities { get; set; }
    }
    public class Login
    {
        [EmailAddress]
        [Required]
        public string LoginEmail { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string LoginPassword { get; set; }
    }

    public class Activityclass
    {
        [Key]
        public int ActivityID { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Title must be atleast 2 char")]
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public int Duration { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "Description Must be atleast 10 char")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UserID { get; set; }
        public User Coordinator { get; set; }
        public List<Participate> ActivityToUser { get; set; }
    }
    public class Participate 
    {
        [Key]
        public int ParticipateID {get; set;}
        public int ActivityID {get; set;}
        public int UserID {get; set;}
        public Activityclass Activitys {get; set;}
        public User Users {get; set;}
    }
}