//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeployingAppHarbor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RegistrationNoS2
    {
        public RegistrationNoS2()
        {
            this.BridgeRegNoItemS2 = new HashSet<BridgeRegNoItemS2>();
        }
    
        public int Id { get; set; }
        public string RegNo { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<bool> PaidStatus { get; set; }
        public Nullable<System.TimeSpan> TimeStamp { get; set; }
    
        public virtual ICollection<BridgeRegNoItemS2> BridgeRegNoItemS2 { get; set; }
    }
}