using System.Collections.Generic;
using Nancy.Validation;

namespace Cmas.Infrastructure.ErrorHandler.Web
{
     
    public class ValidationErrorModel : ServiceErrorModel
    { 
        public IEnumerable<dynamic> Errors { get; set; }
    }
}
