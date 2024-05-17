using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class RegisterDto
    {
        public string? Image { get; set; }
        public string? Phone { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        
        public string? FullName { get; set; }
    
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public AccountType? AccountType { get; set; }
    }
}
