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
    
    public partial class Montpowermission
    {
        public int ID { get; set; }
        public Nullable<bool> Dateofregistration { get; set; }
        public Nullable<System.DateTime> Add_time { get; set; }
        public string Remarks { get; set; }
        public string Departmentname { get; set; }
        public Nullable<int> Dormitorynumber { get; set; }
        public Nullable<double> Electricquantity { get; set; }
    
        public virtual DormInformation DormInformation { get; set; }
    }
}
