using Grpc.Net.Client;
using GrpcNet6;

var channel = GrpcChannel.ForAddress("https://localhost:7192");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
       new GrpcNet6.HelloRequest { Name = "gRPC Demo" }
);
Console.WriteLine("from server: " +reply);