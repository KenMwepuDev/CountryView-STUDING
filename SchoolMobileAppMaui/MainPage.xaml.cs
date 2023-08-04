using SchoolMobileAppMaui.Model;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace SchoolMobileAppMaui;

public partial class MainPage : ContentPage
{
	int count = 0;
    public ObservableCollection<Country> Countries { get; set; }

    public MainPage()
	{
		InitializeComponent();
        var client = new HttpClient();
        var response = 
        //Countries = new ObservableCollection<Country>
        //{
        //    new Country { name = "Republic Democratic Of Congo", Population = 24232, flagImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Flag_of_the_Democratic_Republic_of_the_Congo.svg/2560px-Flag_of_the_Democratic_Republic_of_the_Congo.svg.png" },
        //    new Country { name = "France", Population = 2024223, flagImage = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/1200px-Flag_of_France.svg.png" },
        //    new Country { name = "Zambie", Population = 3452003, flagImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Flag_of_Zambia.svg/2560px-Flag_of_Zambia.svg.png" },
        //    // Add more countries as needed
        //};



        countriesCollectionView.ItemsSource = Countries;
    }
}

