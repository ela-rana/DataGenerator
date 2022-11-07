using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataGenerator.Models
{
    public class GeneratedTable
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<GeneratedField>? GeneratedFields { get; set; }
    }

    public class GeneratedField
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public AllDataTypes? Datatype { get; set; }
        
        public int TableID { get; set; }

        public virtual GeneratedTable Table { get; set; } = null!;
    }

    public enum AllDataTypes
    {
        FirstName,
        MiddleName,
        LastName,
        MiddleInitial,
        NumericID,
        AlphaNumericID,
        IntegerValues,
        DecimalValues,
        Date
    }
}
