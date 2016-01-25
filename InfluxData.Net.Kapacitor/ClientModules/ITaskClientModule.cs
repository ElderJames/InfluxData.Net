﻿using System.Collections.Generic;
using System.Threading.Tasks;
using InfluxData.Net.Common.Infrastructure;
using InfluxData.Net.Kapacitor.Models;
using InfluxData.Net.Kapacitor.Models.Responses;

namespace InfluxData.Net.Kapacitor.ClientModules
{
    public interface ITaskClientModule
    {
        Task<KapacitorTask> GetTask(string taskName);

        Task<IEnumerable<KapacitorTask>> GetTasks();

        Task<IInfluxDataApiResponse> DefineTask(DefineTaskParams taskParams);

        Task<IInfluxDataApiResponse> DeleteTask(string taskName);

        Task<IInfluxDataApiResponse> EnableTask(string taskName);

        Task<IInfluxDataApiResponse> DisableTask(string taskName);
    }
}