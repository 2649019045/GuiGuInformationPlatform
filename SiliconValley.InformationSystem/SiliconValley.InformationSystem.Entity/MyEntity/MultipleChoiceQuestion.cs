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
    
    public partial class MultipleChoiceQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MultipleChoiceQuestion()
        {
            this.ChoiceQuestionPaper = new HashSet<ChoiceQuestionPaper>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public Nullable<bool> IsRadio { get; set; }
        public Nullable<int> Level { get; set; }
        public string Answer { get; set; }
        public Nullable<int> Proposition { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<bool> IsUsing { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Course { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChoiceQuestionPaper> ChoiceQuestionPaper { get; set; }
        public virtual Curriculum Curriculum { get; set; }
        public virtual QuestionLevel QuestionLevel { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
