using System;
using FreshMvvm.Maui;
using MyChatGPT_Maui.Services.ClientInfoServices;

namespace MyChatGPT_Maui.PageModels
{
    public class BasePageModel : FreshBasePageModel
    {
        private readonly IClientInfoServices _clientInfoServices;
        string _pageTitle = string.Empty;
        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                RaisePropertyChanged("PageTitle");
            }
        }
        public BasePageModel(IClientInfoServices clientInfoServices)
        {
            _clientInfoServices = clientInfoServices;
        }
    }
}

