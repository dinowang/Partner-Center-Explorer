﻿// -----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.Explorer.Controllers
{
    using System;
    using System.Web.Mvc;
    using Providers;
    using Security;

    /// <summary>
    /// Controller for all Home views.
    /// </summary>
    public class HomeController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        public HomeController(IExplorerProvider provider) : base(provider)
        {
        }

        /// <summary>
        /// Handles the request for the index view.
        /// </summary>
        /// <returns>The HTML template for the index page.</returns>
        [AuthorizationFilter(Roles = UserRole.Partner)]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Handles the request for the error view.
        /// </summary>
        /// <returns>The HTML template for the error page.</returns>
        public ActionResult Error(string message)
        {
            ViewBag.ErrorMessage = message;
            return View();
        }
    }
}