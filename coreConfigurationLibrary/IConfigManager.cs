using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace coreConfigurationLibrary
{
    public interface IConfigManager
    {
        public string? NorthwindConnection { get; }

        public string? EmailID { get; }

        public string? AccountKey { get; }

        public string? GetConnectionString(string connectionName);

        IConfigurationSection GetConfigurationSection(string Key);
    }
}
