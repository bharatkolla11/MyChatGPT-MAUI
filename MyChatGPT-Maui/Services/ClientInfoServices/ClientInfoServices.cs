using System;
using MyChatGPT_Maui.ServiceModels;
using Newtonsoft.Json;

namespace MyChatGPT_Maui.Services.ClientInfoServices
{
    public class ClientInfoServices : IClientInfoServices
    {
        public ClientInfoServices()
        {
        }

        public async Task<ImageResponseModel> GetImages(string jSONData)
        {
            ImageResponseModel imageResponseModel = null;
            ServiceHelper serviceHelper = new ServiceHelper();
            string baseUrl = "https://api.openai.com/v1/";
            string url = "images/generations";

            var response = await serviceHelper.PostDataAsync(baseUrl, url, jSONData);

            if (response != null && JsonValidationHelper.IsValidJson(response))
            {
                imageResponseModel = JsonConvert.DeserializeObject<ImageResponseModel>(response,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.None,
                        NullValueHandling = NullValueHandling.Ignore
                    });
            }
            return imageResponseModel;
        }

        public async Task<TextResponseModel> GetText(string jSONData)
        {
            TextResponseModel textResponseModel = null;
            ServiceHelper serviceHelper = new ServiceHelper();
            string baseUrl = "https://api.openai.com/v1/";
            string url = "completions";

            var response = await serviceHelper.PostDataAsync(baseUrl, url, jSONData);

            if (response != null && JsonValidationHelper.IsValidJson(response))
            {
                textResponseModel = JsonConvert.DeserializeObject<TextResponseModel>(response,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.None,
                        NullValueHandling = NullValueHandling.Ignore
                    });
            }
            return textResponseModel;
        }
    }
}

