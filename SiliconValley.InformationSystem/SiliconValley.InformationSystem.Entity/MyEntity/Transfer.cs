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
    
    public partial class Transfer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transfer()
        {
            this.ClassDynamics = new HashSet<ClassDynamics>();
        }
    
        public int ID { get; set; }
        public string Student_number { get; set; }
        public string Reasonsforshifting { get; set; }
        public Nullable<System.DateTime> TransferDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> Dateofregistration { get; set; }
        public string Hopetoransfer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassDynamics> ClassDynamics { get; set; }
        public virtual ClassSchedule ClassSchedule { get; set; }
        public virtual StudentInformation StudentInformation { get; set; }
    }
}
