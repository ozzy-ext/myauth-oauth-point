﻿#if MYAUTH_CLIENT
namespace MyAuth.OAuthPoint.Client.Models
#else
using Microsoft.AspNetCore.Mvc;

namespace MyAuth.OAuthPoint.Models.DataContract
#endif
{
    /// <summary>
    /// Token request model
    /// </summary>
    /// <remarks>https://datatracker.ietf.org/doc/html/rfc6749#section-4.1.3</remarks>
    public class TokenRequest
    {
        /// <summary>
        /// REQUIRED.  Value MUST be set to "client_credentials".
        /// </summary>
#if !MYAUTH_CLIENT
        [FromForm(Name = "grant_type")]
#endif
        public string GrantType { get; set; }

        /// <summary>
        /// REQUIRED.  The authorization code received from the authorization server.
        /// </summary>
#if !MYAUTH_CLIENT
        [FromForm(Name = "code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// REQUIRED, if the "redirect_uri" parameter was included in the authorization request as described in Section 4.1.1, and their values MUST be identical.
        /// </summary>
#if !MYAUTH_CLIENT
        [FromForm(Name = "redirect_uri")]
#endif
        public string RedirectUri { get; set; }

        /// <summary>
        /// REQUIRED, if the client is not authenticating with the authorization server as described in Section 3.2.1.
        /// </summary>
#if !MYAUTH_CLIENT
        [FromForm(Name = "client_id")]
#endif
        public string ClientId { get; set; }
    }
}