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
    
    public partial class CooperaEnterprises
    {
        public int ID { get; set; }
        public string EntContacts { get; set; }
        public string EntPhone { get; set; }
        public Nullable<bool> IsCooper { get; set; }
        public Nullable<int> EntID { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> IsDel { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual EnterpriseInfo EnterpriseInfo { get; set; }
    }
}