using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiAngularJS.Domain.Entities
{
    public abstract class DbEntity
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [Range(typeof(DateTime), "01/01/1753", "31/12/9999")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTime DtInc { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DtAlt { get; set; }
    }
}
