//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSTowersOffice.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Team_Employee
    {
        public int ID { get; set; }
        public int Team { get; set; }
        public int Employee { get; set; }
        public System.DateTime AddDate { get; set; }
        public int Role { get; set; }
    
        public virtual Employee Employee1 { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual Team_Role Team_Role { get; set; }
    }
}
