using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidanceFacebookAPI.Models
{
    public class ApiSettings
    {
        public string FacebookApiId { get; set; }
        public string FacebookApiSecret { get; set; }
        public string FacebookPageId { get; set; }
        public string UserAccessToken { get; set; }
        public string PageAccessToken { get; set; }
    }
}
