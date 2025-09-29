# what is graph QL Api

GraphQL is a query language for APIs that lets clients ask exactly for the data they need, nothing more and nothing less.

Instead of the server deciding what data to send (like in REST), the client shapes the response.

this works on single schema only 


# Required Package

to build the graphQl api using .net core we need to intsall the packaes name 
 (HotChoclate)

 # project Setup 

 frist of all we need t crate a asp.net core empty web application or you also can crate web api project hat ever you want according your prefrence the you have to insatall the required nueget packages 


 # Dependency injection of hotchocklet in the asp.net core empty application

    builder.Services .AddGraphQLServer()  .AddQueryType<Query>();

    in this Query is a class which i declared in the schema class

# mapping graphQl endpoint 
  instead on routing we use this this is 
  app.MapGraphQL("/graphql");

# run you application 
  open the playground of graphQL and now write your properties 

  suppose this is our Query class 
        namespace GraphQLAPI.Schema
        {
            public class Query
            {
                public string Instructions() => "Hello, GraphQL with HotChocolate!";
            }
        }

if we want to execute this on the playground you have to write only like this 

    query{
    instructions
    }

    writtiing Query is optional you can simply write it like this 

    {
        instructions
    }