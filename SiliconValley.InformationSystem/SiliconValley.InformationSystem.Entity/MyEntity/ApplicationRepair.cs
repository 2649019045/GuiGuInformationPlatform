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
    
    public partial class ApplicationRepair
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApplicationRepair()
        {
            this.ClassDynamics = new HashSet<ClassDynamics>();
        }
    
        public int Id { get; set; }
        public string Rehabilit { get; set; }
        public string Reason { get; set; }
        public string StudentID { get; set; }
        public Nullable<System.DateTime> Repairtime { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> Addtime { get; set; }
    
        public virtual ClassSchedule ClassSchedule { get; set; }
        public virtual StudentInformation StudentInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassDynamics> ClassDynamics { get; set; }
    }
}
