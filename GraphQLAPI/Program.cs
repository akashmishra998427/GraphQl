using GraphQLAPI.Schema;
using HotChocolate;
using HotChocolate.AspNetCore;
//using HotChocolate.AspNetCore.Playground;

var builder = WebApplication.CreateBuilder(args);

// Register GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

// Map GraphQL endpoint
app.MapGraphQL("/graphql");

//// Optional: Enable Playground (or Banana Cake Pop by default in v15)
//app.UsePlayground(new PlaygroundOptions
//{
//    QueryPath = "/graphql",
//    Path = "/playground"
//});

app.Run();


