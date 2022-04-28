using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HorizonTech.Models;
using HorizonTech.FlyoutFeatures.Features2;

namespace HorizonTech.FlyoutFeatures.Features2
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    //public partial class Feature2 : ContentPage
    //{
    //    private object myCollectionView;

    //    public Feature2()
    //    {
    //        InitializeComponent();
    //    }

    //    private void InitializeComponent()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    protected override async void OnAppearing()
    //    {
    //        try
    //        {
    //            base.OnAppearing();
    //            myCollectionView.ItemsSource = await App.MyDatabase.ReadEmployees();
    //        }
    //        catch { }

    //    }

    //    async void ToolbarItem_Clicked(object sender, EventArgs e)
    //    {
    //        await Navigation.PushAsync(new EmployeeDetail());
    //    }

    //    async void SwipeItem_Invoked(object sender, EventArgs e)
    //    {
    //        var item = sender as SwipeItem;
    //        var emp = item.CommandParameter as EmployeeModel;
    //        await Navigation.PushAsync(new EmployeeDetail(emp));
    //    }

    //    // to change in data



    //    // to delete from database
    //    async void SwipeItem_Invoked_1(object sender, EventArgs e)
    //    {
    //        var item = sender as SwipeItem;
    //        var emp = item.CommandParameter as EmployeeModel;
    //        var result = await DisplayAlert("Delete ", $"Delete {emp.Name} from the database", "Yes", "No");
    //        if (result)
    //        {
    //            await App.MyDatabase.DeleteEmployee(emp);
    //            //to refresh fastly
    //            myCollectionView.ItemsSource = await App.MyDatabase.ReadEmployees();
    //        }
    //    }

    //    async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    //    {
    //        myCollectionView.ItemsSource = await App.MyDatabase.Search(e.NewTextValue);
    //    }
    //}

}