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
    
    public partial class Reconcile
    {
        public int Id { get; set; }
        public Nullable<int> Teacher_Id { get; set; }
        public Nullable<int> ClassRoom_Id { get; set; }
        public Nullable<int> Curriculum_Id { get; set; }
        public Nullable<int> Curse_Id { get; set; }
        public string ClassSchedule_Id { get; set; }
        public Nullable<System.DateTime> NewDate { get; set; }
        public string Rmark { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual Classroom Classroom { get; set; }
        public virtual ClassSchedule ClassSchedule { get; set; }
        public virtual CourseTime CourseTime { get; set; }
        public virtual Curriculum Curriculum { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}