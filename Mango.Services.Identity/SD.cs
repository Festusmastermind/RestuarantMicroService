using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace Mango.Services.Identity
{
    public class SD
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        // Terms and Definition
        // IdentityResources: A named group of claims that can be requested, its basically data  you are trying to access via scope parameter

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
            };

        // Api Scopes are identifiers for the Apis / Resources the Clients (Web, Mobile, Desktop) apps wants to Access...
        // We have two types of Scopes; IdentityScope and Resource Scope
        // Identity Scope contains the object of the profile itself ..i.e. firstname, lastname etc...
        // Resource Scope contains the 

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("mango", "Mango Server"),
                new ApiScope(name: "read", displayName: "Read your data"),
                new ApiScope(name: "write", displayName: "Write your data"),
                new ApiScope(name: "delete", displayName: "Delete your data"),
            };


        // A Client is a piece of software that request an IdentiyToken from a server either for authentication a user or accessing a resource
        // Mango.Web is a client in this project...
        // profile is a built in Scope ...
        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                //this first client is not used ...its just an example showing we can have multiple Clients..
                new Client
                {
                    ClientId= "client",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "read", "write", "profile"}
                },
                new Client
                {
                    ClientId= "mango",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris = { "https://localhost:7125/signin-oidc" }, //on attempted/successful login..this is mandatory for the Code GrantTypes..
                    PostLogoutRedirectUris = { "https://localhost:7125/signout-callback-oidc" }, // on logout...
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "mango"
                    }
                }
            };
    }
}
