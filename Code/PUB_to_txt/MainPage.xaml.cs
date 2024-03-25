namespace PUB_to_txt
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var response =await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Please slect an image",
                FileTypes = FilePickerFileType.Images
            });
            if (response.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase)||response.FileName.EndsWith("jpeg",StringComparison.OrdinalIgnoreCase))
            { 
            
            }
            else
            {
                await Shell.Current.DisplayAlert("Alert", "Invalid file selected", "Ok");
            }
        }
    }

}
