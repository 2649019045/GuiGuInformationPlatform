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
    
    public partial class StudentFeeStandard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentFeeStandard()
        {
            this.Detailedpayment = new HashSet<Detailedpayment>();
        }
    
        public int ID { get; set; }
        public Nullable<decimal> Tuition { get; set; }
        public Nullable<decimal> Foodandlodging { get; set; }
        public Nullable<int> Stage { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> Addtime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detailedpayment> Detailedpayment { get; set; }
        public virtual StageGrade StageGrade { get; set; }
    }
}