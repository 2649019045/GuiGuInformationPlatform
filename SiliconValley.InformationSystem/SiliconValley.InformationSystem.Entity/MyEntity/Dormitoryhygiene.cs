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
    
    public partial class Dormitoryhygiene
    {
        public int ID { get; set; }
        public Nullable<int> Clothing { get; set; }
        public Nullable<int> Washsupplies { get; set; }
        public Nullable<int> Cleantoilet { get; set; }
        public Nullable<int> Shoeplacement { get; set; }
        public Nullable<int> Beddebris { get; set; }
        public Nullable<int> Trunk { get; set; }
        public Nullable<int> Emptyplacement { get; set; }
        public Nullable<int> Sheet { get; set; }
        public Nullable<int> BeddingOverlay { get; set; }
        public Nullable<int> Inspector { get; set; }
        public Nullable<int> Dormitoryaddress { get; set; }
        public Nullable<int> Ground { get; set; }
        public Nullable<bool> Dateofregistration { get; set; }
        public Nullable<System.DateTime> Addtime { get; set; }
        public string Remarks { get; set; }
    
        public virtual DormInformation DormInformation { get; set; }
        public virtual InstructorList InstructorList { get; set; }
    }
}
