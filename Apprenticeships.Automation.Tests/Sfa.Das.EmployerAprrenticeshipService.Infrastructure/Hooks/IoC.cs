namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Hooks
{
    using BoDi;
    using Selenium;
    using Services;

    public class IoC
    {
        public static IObjectContainer Initialise(IObjectContainer objectContainer)
        {
            objectContainer.RegisterTypeAs<BrowserStackApi, IBrowserStackApi>();
            objectContainer.RegisterTypeAs<WebRequestRetryService, IRetryWebRequests>();
            objectContainer.RegisterTypeAs<ConsoleLogger, ILog>();
            return objectContainer;
        }
    }
}
