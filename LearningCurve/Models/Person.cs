using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningCurve.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [UIHint("Integer")]
        [Required(ErrorMessage = "{0} IS REQUIRED!")]
        [DisplayName("'n Nommer")]
        [AdditionalMetadata("Test", 5)]
        public int Test { get; set; }
    }
}