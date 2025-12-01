using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using static SampleRegression.ConsoleApp.SampleRegression;

namespace wee.Pages;

public class IndexModel : PageModel
{

    [BindProperty]
    public ModelInput ModelInput { get; set; } = new ModelInput();
    public ModelOutput ModelOutput { get; set; } = new ModelOutput();

    public void OnGet()
    {
        var sampleData = new ModelInput()
        {
            Vendor_id = @"CMT",
            Rate_code = 1F,
            Passenger_count = 1F,
            Trip_time_in_secs = 1271F,
            Trip_distance = 3.8F,
            Payment_type = @"CRD",
        };

        this.ModelInput = sampleData;
    }

    public IActionResult OnPost()
    {
        var predictionResult = Predict(this.ModelInput);

        this.ModelOutput = predictionResult;

        return Page();
    }
}
