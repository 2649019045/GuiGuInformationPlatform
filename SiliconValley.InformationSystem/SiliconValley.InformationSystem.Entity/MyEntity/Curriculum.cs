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
    
    public partial class Curriculum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curriculum()
        {
            this.AnswerQuestionBank = new HashSet<AnswerQuestionBank>();
            this.ClassTeacher = new HashSet<ClassTeacher>();
            this.GoodSkill = new HashSet<GoodSkill>();
            this.MachTestQuesBank = new HashSet<MachTestQuesBank>();
            this.MultipleChoiceQuestion = new HashSet<MultipleChoiceQuestion>();
            this.Reconcile = new HashSet<Reconcile>();
            this.SatisficingConfig = new HashSet<SatisficingConfig>();
            this.StrengthenClass = new HashSet<StrengthenClass>();
        }
    
        public int CurriculumID { get; set; }
        public Nullable<int> Grand_Id { get; set; }
        public Nullable<int> 专业ID { get; set; }
        public string CourseName { get; set; }
        public Nullable<int> CourseType_Id { get; set; }
        public Nullable<int> CourseCount { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<decimal> PeriodMoney { get; set; }
        public string Rmark { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnswerQuestionBank> AnswerQuestionBank { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassTeacher> ClassTeacher { get; set; }
        public virtual CourseType CourseType { get; set; }
        public virtual Grand Grand { get; set; }
        public virtual Specialty Specialty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodSkill> GoodSkill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachTestQuesBank> MachTestQuesBank { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MultipleChoiceQuestion> MultipleChoiceQuestion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reconcile> Reconcile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SatisficingConfig> SatisficingConfig { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StrengthenClass> StrengthenClass { get; set; }
    }
}