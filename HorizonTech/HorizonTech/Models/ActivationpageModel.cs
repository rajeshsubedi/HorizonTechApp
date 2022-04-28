using System;
using System.Collections.Generic;
using System.Text;
using HorizonTech.Services;


namespace HorizonTech.Models
{
    public class ActivationpageModel
    {
        private readonly ApiServices _apiServices = new ApiServices();

        public int Liscence { get; set; }

        public int Token { get; set; }

        //public int Message { get; set; }

        //public ICommand ActivationCommand
        //{
        //    get
        //    {
        //        return new Command(async() =>
        //        {
        //            //var isSuccess = await _apiServices.ActivationpageAsync(
        //            //    Liscence, Token);

        //            //Setting.Liscence = Liscence;
        //            //Setting.Token = Token;

        //            //if (isSuccess)
        //            //    Message = "Activated";
        //            //else
        //            //    Message = "Retry Later";

        //            int accesstoken = await _apiServices.ActivationpageAsync(Liscence, Token);

        //            Setting.AccessToken = accesstoken;


        //        });
        //    }
        //}

    }
}