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
    
    public partial class BridgeRegNoItemsS5
    {
        public int Id { get; set; }
        public Nullable<int> RegId { get; set; }
        public Nullable<int> ItemId { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual RegistrationNoS5 RegistrationNoS5 { get; set; }
    }
}