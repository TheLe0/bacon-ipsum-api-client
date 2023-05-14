// See https://aka.ms/new-console-template for more information

using Create.API.Client;

var client = new CreateApiClient();

var response = await client.TextGenerator
        .GenerateSentenceAsync(1)
        .ConfigureAwait(false);

Console.WriteLine("Hello, World!");
