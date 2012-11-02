//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Effort.Test.Data.Northwind
{
    
    public class Employee
    {
        public virtual int EmployeeID { get; set; }
    
        public virtual string LastName { get; set; }
    
        public virtual string FirstName { get; set; }
    
        public virtual string Title { get; set; }
    
        public virtual string TitleOfCourtesy { get; set; }
    
        public virtual Nullable<System.DateTime> BirthDate { get; set; }
    
        public virtual Nullable<System.DateTime> HireDate { get; set; }
    
        public virtual string Address { get; set; }
    
        public virtual string City { get; set; }
    
        public virtual string Region { get; set; }
    
        public virtual string PostalCode { get; set; }
    
        public virtual string Country { get; set; }
    
        public virtual string HomePhone { get; set; }
    
        public virtual string Extension { get; set; }
    
        public virtual byte[] Photo { get; set; }
    
        public virtual string Notes { get; set; }
    
        public virtual Nullable<int> ReportsTo { get; set; }
    
        public virtual string PhotoPath { get; set; }
    
        public virtual ICollection<Employee> Subalterns { get; set; }
    
        public virtual Employee Principal { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    
        public virtual ICollection<Territory> Territories { get; set; }
    
    
    }
}