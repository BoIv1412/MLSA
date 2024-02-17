using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Threading.Tasks;

namespace Marathon.Server.Azure
{
    public class KeyVaultManager
    {
        readonly string tenantId;
        readonly string clientId;
        readonly string clientSecret;

        public KeyVaultManager()
        {
            tenantId = "84c31ca0-ac3b-4eae-ad11-519d80233e6f";
            clientId = "e83117cc-02a0-4222-86f6-bd194609cb63";
            clientSecret = "tmP8Q~Hi52gRwTl0irLKllmWjP4jxML_5gIGddyA";
        }
        public string GetSecret(string SecretName)
        {
            var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var client = new SecretClient(vaultUri: new Uri("https://keyvault125347.vault.azure.net/"), credential);

            return client.GetSecret(SecretName).Value.Value;
        }

        public async Task<string> GetSecretAsync(string SecretName)
        {
            var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var client = new SecretClient(vaultUri: new Uri("https://keyvault125347.vault.azure.net/"), credential);

            var secret = await client.GetSecretAsync(SecretName);
            return secret.Value.Value;
        }


    }
}