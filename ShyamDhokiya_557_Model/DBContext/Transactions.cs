//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShyamDhokiya_557_Model.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transactions
    {
        public int TransactionId { get; set; }
        public Nullable<int> WalletId { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<bool> IsDebitCredit { get; set; }
        public System.DateTime Time { get; set; }
        public Nullable<int> TotalAmount { get; set; }
    
        public virtual Wallet Wallet { get; set; }
    }
}
