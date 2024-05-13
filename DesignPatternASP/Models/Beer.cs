using System.ComponentModel.DataAnnotations;

namespace DesignPatternASP.Models
{
    public class Beer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
    }
}
