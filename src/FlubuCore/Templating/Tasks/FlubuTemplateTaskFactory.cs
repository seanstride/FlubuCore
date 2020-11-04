﻿using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Templating.Models;

namespace FlubuCore.Templating.Tasks
{
    public class FlubuTemplateTaskFactory : IFlubuTemplateTaskFactory
    {
        private static readonly Dictionary<string, Type> Tasks = new Dictionary<string, Type>()
        {
            { FlubuTemplateTaskName.ReplacementTokenTask, typeof(TemplateReplacementTokenTask) }
        };

        private readonly IServiceProvider _serviceProvider;

        public FlubuTemplateTaskFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IFlubuTemplateTask GetFlubuTemplateTask(string taskName)
        {
           var task = _serviceProvider.GetService(Tasks[taskName]);
           return (IFlubuTemplateTask)task;
        }
    }
}
