using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Model
{
    public class GolfCompetition
    {
        public int ID { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Competition Date")]
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [Display(Name = "Competition Summary")]
        public string Description { get; set; }
    }
}
