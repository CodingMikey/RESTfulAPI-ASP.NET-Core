using CourseLibrary.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.ValidationAttributes
{
    public class CourseTitleMustBeDifferentFromDescription : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var coursce = (CourseForCreationDto)validationContext.ObjectInstance;

            if (coursce.Title == coursce.Description)
            {
                return new ValidationResult(
                    "The provided description should be different from the title",
                    new[] { nameof(CourseForCreationDto) });
            }
            return ValidationResult.Success;
        }
    }
}
