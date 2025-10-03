using GraphQLAPI.Schema.Mutations;
using GraphQLAPI.Schema.Query;

var builder = WebApplication.CreateBuilder(args);

// Register GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

// Map GraphQL endpoint
app.MapGraphQL("/graphql");

app.Run();


