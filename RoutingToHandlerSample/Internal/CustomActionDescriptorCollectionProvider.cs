﻿using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using RoutingToHandlerSample.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingToHandlerSample.Internal
{
    public class CustomActionDescriptorCollectionProvider : IActionDescriptorCollectionProvider
    {
        private readonly List<ActionDescriptor> _actionDescriptors;

        public CustomActionDescriptorCollectionProvider()
        {
            var actionDescriptor = new ControllerActionDescriptor();
            actionDescriptor.MethodInfo = typeof(CustomersController).GetMethod(nameof(HomeController.Index));
            actionDescriptor.ActionName = nameof(HomeController.Index);

            _actionDescriptors = new List<ActionDescriptor>();
            _actionDescriptors.Add(actionDescriptor);

            ActionDescriptors = new ActionDescriptorCollection(_actionDescriptors.AsReadOnly(), 1);
        }

        public ActionDescriptorCollection ActionDescriptors { get; }
    }
}