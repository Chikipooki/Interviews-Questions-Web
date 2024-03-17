using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewsAPI.Models
{
    public class Questions
    {
        [Key]
        public int QnId { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string QnInWords { get; set; }
        [Column(TypeName = "varchar(260)")]
        public string? ImageName { get; set; }

        [Column(TypeName = "varchar(260)")]
        public string Option1 { get; set; }
        [Column(TypeName = "varchar(260)")]
        public string Option2 { get; set; }
        [Column(TypeName = "varchar(260)")]
        public string Option3 { get; set; }
        [Column(TypeName = "varchar(260)")]
        public string Option4 { get; set; }

        public int Answer { get; set; }
    }
}
