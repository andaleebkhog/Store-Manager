//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Store_Manager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.ExchangePermessions = new HashSet<ExchangePermession>();
        }
    
        public int cust_id { get; set; }
        public string cust_name { get; set; }
        public string cust_phone { get; set; }
        public string cust_fax { get; set; }
        public string cust_mobile { get; set; }
        public string cust_mail { get; set; }
        public string cust_website { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangePermession> ExchangePermessions { get; set; }
    }
}