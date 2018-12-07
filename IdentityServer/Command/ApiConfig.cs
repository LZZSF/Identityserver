using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Command
{
    //identityserver 需要在startup 注入的对象
    public class ApiConfig
    {
        /// <summary>
        /// 定义apiresource
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[] { new ApiResource("api", "My API") };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                new Client
                {
                    ClientId="client",
                    ClientSecrets=new []{ new Secret("secret".Sha256())},
                    AllowedGrantTypes=GrantTypes.ClientCredentials,//授权模式 这里采用客户端认证模式,只要clientId
                    AllowedScopes=new[]{ "api" }//定义客户端上可访问的api组，不定义就是访问全部
                }
            };
        }
    }
}
