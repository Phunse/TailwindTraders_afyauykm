﻿using System.Threading.Tasks;
using Refit;
using TailwindTraders.Mobile.Features.Settings;

namespace TailwindTraders.Mobile.Features.Home
{
    public interface IHomeAPI
    {
        [Get("/landing")]
        Task<LandingDTO> GetAsync([Header(DefaultSettings.ApiAuthorizationHeader)] string authorizationHeader);
    }
}
