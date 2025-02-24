using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class RequestResponseContext
    {
        public string? RequestBody { get; set; }
        public string? ResponseBody { get; set; }

        public int? RequestLength => RequestBody?.Length; 
        public int? ResponseLength => ResponseBody?.Length;

        public TimeSpan? ResponseCreationTime{get;set;}
        public TimeSpan? RequestProcessingTime{get;set;}

        public string? RequestMethod{get;set;}
        public string? RequestPath{get;set;}
        public string? RequestQueryString{get;set;}
        
    }
}
