using System;
using MyChatGPT_Maui.ServiceModels;

namespace MyChatGPT_Maui.Services.ClientInfoServices
{
	public interface IClientInfoServices
	{
        Task<ImageResponseModel> GetImages(string jSONData);
        Task<TextResponseModel> GetText(string jSONData);
    }
}

