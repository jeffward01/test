using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExam.Models.Dto
{
    [DataContract]
    public class Customer_Dto
    {
        [DataMember(Name="customerId")]
        public int CustomerId { get; set; }
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }
        [DataMember(Name = "middleName")]
        public string MiddleName { get; set; }
        [DataMember(Name = "isActive")]
        public bool IsActive { get; set; }
    }
}
