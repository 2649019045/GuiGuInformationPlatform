//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconValley.InformationSystem.Entity.MyEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class LatesubmieCords
    {
        public int ID { get; set; }
        public string Student_number { get; set; }
        public Nullable<int> Guarantee { get; set; }
        public Nullable<decimal> Reason { get; set; }
        public Nullable<int> Residual_costs { get; set; }
        public string LatestPaymentDate { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> Addtime { get; set; }
    
        public virtual StudentInformation StudentInformation { get; set; }
    }
}
