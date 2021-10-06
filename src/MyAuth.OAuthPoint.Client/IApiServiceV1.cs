﻿using System.Threading.Tasks;
using MyAuth.OAuthPoint.Client.Models;
using MyLab.ApiClient;

namespace MyAuth.OAuthPoint.Client
{
    /// <summary>
    /// MyAuth API endpoints
    /// </summary>
    [Api("api/v1", Key = "api/v1")]
    public interface IApiServiceV1
    {
        /// <summary>
        /// Complete login process successfully
        /// </summary>
        [Post("{loginSessionId}/error")]
        Task SuccessLogin([Path] string loginSessionId, [JsonContent] AuthorizedUserInfo authorizedUserInfo);

        /// <summary>
        /// Complete login process failed
        /// </summary>
        [Post("{loginSessionId}/error")]
        Task FailLogin([Path] string loginSessionId, [JsonContent] LoginError loginError);

        /// <summary>
        /// Return back from login process
        /// </summary>
        [Get("authorization-callback")]
        Task CallbackLogin([Query("login_session_id")]string loginSessionId);
    }
}