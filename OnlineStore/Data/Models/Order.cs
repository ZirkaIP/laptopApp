using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OnlineStore.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display (Name = "Input your name")]
        [StringLength(20)]
        [Required(ErrorMessage = "Name can't be longer than 20 letters")]
        public string Name { get; set; }

        [Display(Name = "Input your surname")]
        [StringLength(20)]
        [MinLength(1)]
        [Required(ErrorMessage = "Surname must be longer than 3 letters")]
        public string Surname { get; set; }

        [Display(Name = "Input your phone number")]
        [DataType(DataType.PhoneNumber )]
        [StringLength(12)]
        [MinLength(5)]
        [Required(ErrorMessage = "There are minimum 7 digits in phone number")]
        public string Phone { get; set; }

        [Display(Name = "Input your address")]
        [StringLength(60)]
        [MinLength(5)]
        [Required(ErrorMessage = "Here might be at least characters")]
        public string Address { get; set; }

        [Display(Name = "Input your E-mail")]
        [DataType(DataType.EmailAddress)]
        [MinLength(3)]
        [Required(ErrorMessage = "E-mail might be longer")]
        public string Email { get; set; }

         [BindNever]
         [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
