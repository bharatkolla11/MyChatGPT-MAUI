using System;
namespace MyChatGPT_Maui.Services
{
    public class APIException : Exception
    {
        public string StatusCode { get; set; }

        public string Content { get; set; }
    }
}

