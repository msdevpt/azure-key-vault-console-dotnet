using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

const string vaultUrl = "https://test-kv.vault.azure.net/";

var client = new SecretClient(vaultUri: new Uri(vaultUrl), credential:new DefaultAzureCredential());

// Create a new secret using the secret client.
KeyVaultSecret secret = client.SetSecret("access-token", "access-token-value");

// Retrieve a secret using the secret client.
try
{
    secret = client.GetSecret("access-token");
    Console.WriteLine(secret.Value);
}
catch (Azure.RequestFailedException ex)
{
    Console.WriteLine(ex.Message);
}
