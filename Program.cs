using Azure.AI.OpenAI;
using Azure.Identity;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using OpenAI;
using System;

var endpoint = new Uri("https://myaiserviceluiscoco.openai.azure.com/");
var credential = new AzureCliCredential();

var chat = new AzureOpenAIClient(endpoint, credential)
    .GetChatClient(deploymentName: "gpt-4o-mini");

AIAgent agent = chat.CreateAIAgent(
    instructions: "You are good at telling jokes.",
    name: "Joker"
);

Console.WriteLine(await agent.RunAsync("Tell me a joke about a god."));
