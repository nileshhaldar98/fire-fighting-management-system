using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class VmInquery
    {
        public int Id { get; set; }
        [Required]
        public string EnquiryId { get; set; }
        [Required]
        public int EnquiryType { get; set; }
        [Required]
        public int EnquiryCategory { get; set; }
        [Required]
        public Nullable<int> NoFloors { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [Required]
        public string AlternateNo { get; set; }
        [Required]
        public string Remark { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> StatusId { get; set; }

        public bool IsActive { get; set; }
        public Nullable<System.DateTime> InActiveDate { get; set; }
        public Nullable<int> InActiveBy { get; set; }
        public string IPAddress { get; set; }

       
    }
}
