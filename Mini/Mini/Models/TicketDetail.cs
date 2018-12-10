//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mini.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class TicketDetails
    {
        [Required]
        [DisplayName("Request Id")]
        public int ReqID { get; set; }

        [Required]
        [DisplayName("Request Date ")]
        public System.DateTime ReqDate { get; set; }

        [Required]
        [DisplayName("From Location")]
        public string FromLocation { get; set; }

        [Required]
        [DisplayName("To Location")]
        public string ToLocation { get; set; }

        [DisplayName("Employee Id")]
        public Nullable<int> empID { get; set; }

        [DisplayName("Manager Id")]
        public Nullable<int> mgrID { get; set; }

        [DisplayName("Manager Approval")]
        public Nullable<bool> managerApproval { get; set; }

        [DisplayName("Travelagent Approval")]
        public Nullable<bool> travelagentApproval { get; set; }
    }
}