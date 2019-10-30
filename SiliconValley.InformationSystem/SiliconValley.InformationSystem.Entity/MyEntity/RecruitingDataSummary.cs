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
    
    public partial class RecruitingDataSummary
    {
        public int Id { get; set; }
        public Nullable<int> Pid { get; set; }
        public Nullable<int> PlanRecruitNum { get; set; }
        public Nullable<int> ResumeSum { get; set; }
        public Nullable<int> OutboundCallSum { get; set; }
        public Nullable<int> InstantInviteSum { get; set; }
        public Nullable<int> InstantToFacesSum { get; set; }
        public Nullable<int> InstantRetestSum { get; set; }
        public Nullable<int> InstantRetestPassSum { get; set; }
        public Nullable<int> InstantEntryNum { get; set; }
        public Nullable<decimal> InstantToFacesRate { get; set; }
        public Nullable<decimal> InstantInviteRate { get; set; }
        public Nullable<decimal> InstantRetestPassrate { get; set; }
        public Nullable<decimal> EntryRate { get; set; }
        public Nullable<decimal> RecruitPercentage { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> IsDel { get; set; }
    
        public virtual Position Position { get; set; }
    }
}