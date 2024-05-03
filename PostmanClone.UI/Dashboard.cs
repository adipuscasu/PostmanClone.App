using PostmanClone.Library.Services;
using PostmanClone.Library.Validators;

namespace PostmanClone.UI;

public partial class Dashboard : Form
{
    private readonly IApiService _apiService = new ApiService();
    private readonly ApiUrlValidator _apiValidator = new ApiUrlValidator();
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultsText.Text = "";

        var apiUrl = apiText.Text;
        // Validate the URL
        var validationResult = _apiValidator.Validate(apiUrl);
        if (validationResult.IsValid == false)
        {
            var err = string.Join(" ", validationResult.Errors);
            MessageBox.Show(err);
            return;
        }

        try
        {
            resultsText.Text = await _apiService.CallApiAsync(apiUrl, true);
            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private void apiText_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            callApi_Click(sender, e);
            // Optionally, prevent further processing of the Enter key
            e.Handled = true;
        }
    }
}
