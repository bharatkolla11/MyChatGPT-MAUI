using System;
using System.Windows.Input;
using MyChatGPT_Maui.Services.ClientInfoServices;

namespace MyChatGPT_Maui.PageModels
{
    public class HomePageModel : BasePageModel
    {
        private readonly IClientInfoServices _clientInfoServices;

        #region #Commands#
        public ICommand SelectMyGPTCommand { get; }

        #endregion
        public HomePageModel(IClientInfoServices clientInfoServices) : base(clientInfoServices)
        {
            _clientInfoServices = clientInfoServices;
            SelectMyGPTCommand = new Command(async (obj) => await NavigateToDataPage(obj));
        }

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
        }


        private async Task NavigateToDataPage(object obj)
        {
            await CoreMethods.PushPageModel<DataPageModel>(obj);
        }
    }
}

