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
    
    public partial class BeOnDuty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BeOnDuty()
        {
            this.ClassTeacherKeep = new HashSet<ClassTeacherKeep>();
            this.OvertimeRecord = new HashSet<OvertimeRecord>();
            this.TeacherNight = new HashSet<TeacherNight>();
        }
    
        public int Id { get; set; }
        public string TypeName { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string Reak { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassTeacherKeep> ClassTeacherKeep { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OvertimeRecord> OvertimeRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherNight> TeacherNight { get; set; }
    }
}