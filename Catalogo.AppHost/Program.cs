var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiservice = builder.AddProject<Projects.Catalogo_ApiProdutos>("catalogo-apiprodutos");

builder.AddProject<Projects.Catalogo_LojaWeb>("catalogo-lojaweb")
            .WithReference(apiservice)
            .WithReference(cache);

builder.Build().Run();
