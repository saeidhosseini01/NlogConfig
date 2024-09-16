using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{






    public class persone
    {
        public string name { get; set; }
        public string family { get; set; }
        public string tell { get; set; }
        public override string ToString()
        {
            return name + " " + family;
        }
    }

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            persone persone = new persone()
            { 
                name="saeed",
                family="hosseini",
                tell="09159524625"
            };
            _logger.LogInformation("This Is A test {persone}", persone);
        }
     
    }
}
