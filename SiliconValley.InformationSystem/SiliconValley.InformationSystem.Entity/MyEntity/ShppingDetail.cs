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
    
    public partial class ShppingDetail
    {
        public int Id { get; set; }
        public Nullable<int> PurchaseApply_Id { get; set; }
        public Nullable<int> Goods_Id { get; set; }
        public Nullable<int> GoodsCount { get; set; }
        public string Rmark { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual Goods Goods { get; set; }
        public virtual PurchaseApply PurchaseApply { get; set; }
    }
}
