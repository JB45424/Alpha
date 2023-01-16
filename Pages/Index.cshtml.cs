using Alpha.Data;
using Alpha.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alpha.Pages {
    public class IndexModel : PageModel {
        private AlphaContext context;

//      public YearSummary YearSummary { get; set; }

        public IEnumerable<YearSummary> YearSummaries { get; set; }
            =Enumerable.Empty<YearSummary>();

        public IndexModel(AlphaContext ctx) {
            context = ctx;
        }

//      public async Task OnGetAsync() {
//          YearSummary = await context.YearSummaries.FindAsync();
//      }

        public void OnGet() {
          YearSummaries = context.YearSummaries;
        }

    }
}