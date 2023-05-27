
using Spectre.Console;
using Zerg.Http.Services;
using Zerg.SpaceTraders.API.RateLimiting;

const string token =
    "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZGVudGlmaWVyIjoiWkVSRy1NQVJLLTEiLCJ2ZXJzaW9uIjoidjIiLCJyZXNldF9kYXRlIjoiMjAyMy0wNS0yMCIsImlhdCI6MTY4NDk0NDEzNywic3ViIjoiYWdlbnQtdG9rZW4ifQ.E5x3vP0k2A446eS4_eh63-Cw-BBCulWNw9YoO9Slh6vLCmB4rmUn2rc9P9MlvlDSTM98qLdDAIHuzO-7FN8oOgpG_oAbwN1Lr2AZKDJ6RI71aZDYJjZmV7QPkCWgGkTlNJ8tx6iXSf2wc3WmHsAifJYXucfMxhT170rR89pkoyD4jcnLGbs6eW10lUcbXfnRAROtK6k-0nxZv-BRqpblpZYdh2RNYYqDr_Db6WQsRx1LWH2TS1HZpl9IOqjfL-PSg1rpnj1ehBOcyoTs_rakPrMDItEqCU19hMfviNFAHs-B3JxiHDHjHhzrh5BmwLeTBT8cLq4yLOt8egbXjK054Q";


AnsiConsole.WriteLine("Hello, world!");

var limiter = new SpaceTradersRateLimiter();
var fleet = new HttpFleetService("https://api.spacetraders.io/v2", token, limiter);

var result =  fleet.ListAllShipsAsync();

await foreach (var ship in result)
{
    AnsiConsole.WriteLine(ship.Symbol);
}

Console.ReadLine();

