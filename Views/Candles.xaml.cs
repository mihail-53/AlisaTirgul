namespace AlisaTirgul.Views;

public partial class Candles : ContentPage
{
    public Candles()
    {
        InitializeComponent();
    }

    private void OnSliderValueChanged(object sender, EventArgs e)
    {
        Slider slider = (Slider)sender;
        int age = (int)slider.Value;
        lblAge.Text = age.ToString();
        lblSentence.Text = $"{entryName.Text}, u are {age} years old! In ten years u will be {age + 10}";
        PicturesLayout.Children.Clear();

        for (int i = 0; i < age + 10; i++)
        {
            Image image = new Image
            {
                Source = $"candle.png",
                WidthRequest = 50,
                Margin = 1
            };

            PicturesLayout.Children.Add(image);
        }
    }

}