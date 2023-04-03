using System.ComponentModel.DataAnnotations;

namespace Lab9EF
{
    public class Class
    {
        public int ClassID { get; set; }
        [MaxLength(50)]
        public string ClassName { get; set; }
        [Required]
        public int MaxClassSize { get; set; }
        public Language ClassLanguage { get; set; }

        public override string ToString()
        {
            return $"{this.ClassID}| {this.ClassName} | {this.MaxClassSize} | {this.ClassLanguage.ToString()}";
        }
    }
}