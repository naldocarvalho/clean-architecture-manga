namespace Manga.WebApi.UseCases.CloseAccount
{
    using System;
    using Manga.Application.Boundaries.CloseAccount;
    using Microsoft.AspNetCore.Mvc;

    public sealed class Presenter : IOutputHandler
    {
        public IActionResult ViewModel { get; private set; }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Handle(Guid output)
        {
            ViewModel = new OkResult();
        }
    }
}