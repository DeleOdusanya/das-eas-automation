namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Selenium
{
    using System;

    public interface IBrowserStackApi
    {
        void FailTestSession(Exception testError);
    }
}