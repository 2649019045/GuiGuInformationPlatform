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
    
    public partial class ChannelYearPlan
    {
        public int StaffYearPlanID { get; set; }
        public Nullable<int> SchoolYearPlanID { get; set; }
        public Nullable<int> ChannelStaffID { get; set; }
        public Nullable<int> PlanNumber { get; set; }
        public Nullable<int> SignUpNumber { get; set; }
        public Nullable<bool> IsDel { get; set; }
    
        public virtual ChannelStaff ChannelStaff { get; set; }
        public virtual SchoolYearPlan SchoolYearPlan { get; set; }
    }
}