//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Demo
{
    using System;
    using System.Collections.Generic;
    
    public partial class CitiesData
    {
        public int id { get; set; }
        public Nullable<int> TourID { get; set; }
        public Nullable<int> CityID { get; set; }
    
        public virtual City City { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
