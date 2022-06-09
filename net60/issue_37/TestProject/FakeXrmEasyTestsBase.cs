using FakeXrmEasy.Abstractions;
using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.Middleware;
using FakeXrmEasy.Middleware.Crud;
using Microsoft.PowerPlatform.Dataverse.Client;

namespace TestProject;

public class FakeXrmEasyTestsBase
{
    protected readonly IOrganizationServiceAsync2 _service;
    protected readonly IXrmFakedContext _context;

    public FakeXrmEasyTestsBase()
    {
        _context = MiddlewareBuilder
                            .New()
                            .AddCrud()
                            
                            .UseCrud()
                            .SetLicense(FakeXrmEasyLicense.RPL_1_5)
                            .Build();

        _service = _context.GetAsyncOrganizationService2();
    }
}