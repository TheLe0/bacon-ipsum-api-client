// See https://aka.ms/new-console-template for more information

using Bacon.Ipsum.API.Client;

var client = new BaconIpsumApiClient();

var response = await client.TextGenerator
        .GenerateSentenceAsync(1)
        .ConfigureAwait(false);

Console.WriteLine(response);
