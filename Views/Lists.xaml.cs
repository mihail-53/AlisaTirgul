using AlisaTirgul.Models;
namespace AlisaTirgul.Views;

public partial class Lists : ContentPage
{
	public Lists()
	{
		InitializeComponent();

		

	}
    List<User> users = new List<User>() {
            new User() {Id = 1, Name="Itzik", Img = new Image{ Source = $"user1.jpg",  WidthRequest = 100,   Margin = 1} } ,
            new User() {Id=2, Name="Shlomi", Img = new Image{ Source = $"user2.jpg",  WidthRequest = 100,   Margin = 1}} ,
            new User() {Id = 3, Name="Jessica", Img = new Image{ Source = $"user3.jpg",  WidthRequest = 100,   Margin = 1}},
            new User() {Id = 4, Name="Sara", Img = new Image{ Source = $"user4.jpg",  WidthRequest = 100,   Margin = 1}}
        };
    private void SeeUsers(object sender, EventArgs e)
	{
        UserPistures.Children.Clear();

        foreach (User u in users)
        {
            UserPistures.Children.Add(u.Img);
        }

	}

    private void SearchUser(object sender, EventArgs e)
    {
        string? name = searchName.Text;
        SearchUsersPictures.Children.Clear();
        Image? img = (users.Find(x => x.Name == name)).Img;
        SearchUsersPictures.Children.Add(img);
    }



}