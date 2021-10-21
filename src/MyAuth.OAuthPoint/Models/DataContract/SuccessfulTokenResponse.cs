﻿using Newtonsoft.Json;

#if MYAUTH_CLIENT
namespace MyAuth.OAuthPoint.Client.Models
#else
namespace MyAuth.OAuthPoint.Models.DataContract
#endif
{
    /// <summary>
    /// Successful response for token request
    /// </summary>
    public class SuccessfulTokenResponse
    {
        /// <summary>
        /// REQUIRED.  The access token issued by the authorization server.
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string Token { get; set; }

        /// <summary>
        /// REQUIRED.  The type of the token issued as described in Section 7.1.  Value is case insensitive.
        /// </summary>
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// RECOMMENDED.  The lifetime in seconds of the access token.  For example, the value "3600" denotes that the access token will expire in one hour from the time the response was generated. If omitted, the authorization server SHOULD provide the expiration time via other means or document the default value.
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// OPTIONAL.  The refresh token, which can be used to obtain new access tokens using the same authorization grant as described in Section 6.
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// OPTIONAL, if identical to the scope requested by the client; otherwise, REQUIRED.The scope of the access token as described by Section 3.3.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }
    }
}