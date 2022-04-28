using System;
using System.Collections.Generic;
using System.Text;
using HorizonTech.Services;
using System.ComponentModel;


namespace HorizonTech.Models
{
    public class LoginViewModel : INotifyPropertyChanged

    {
        ApiServices _apiServices = new ApiServices();

        //public string AccessToken { get; set; }

        public List<Idea> Ideas;

        public event PropertyChangedEventHandler PropertyChanged;

        //public ICommand LoginCommand
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            var accesstoken = Setting.AccessToken;
        //            //Loginmenu = await _apiServices.LoginAsync(accesstoken);
        //        });
        //    }
        //}

        public class Idea
        {
        }
    }

}
