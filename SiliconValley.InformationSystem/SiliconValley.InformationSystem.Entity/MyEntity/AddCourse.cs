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
    
    public partial class AddCourse
    {
        public int ID { get; set; }
        public Nullable<int> Count { get; set; }
        public string reason { get; set; }
        public Nullable<int> TeacherID { get; set; }
        public string ClassNumber { get; set; }
        public Nullable<System.DateTime> ApplyDate { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public string Remark { get; set; }
    
        public virtual ClassSchedule ClassSchedule { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}