using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;


namespace DeviceManagement_WebApp.Repositories
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        // Add class specific methods here
    }
}
