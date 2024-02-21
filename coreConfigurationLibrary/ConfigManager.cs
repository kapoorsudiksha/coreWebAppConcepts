﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConfigurationLibrary
{
    public class ConfigManager : IConfigManager
    {
        private readonly IConfiguration _configuration;
        public ConfigManager(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string NorthwindConnection
        {
            get
            {
                return this._configuration["ConnectionStrings:NorthwindDatabase"];
            }
        }

        public string GetConnectionString(string connectionName)
        {
            return this._configuration.GetConnectionString(connectionName);
        }

        public string EmailID
        {
            get
            {
                return this._configuration["AppSeettings:EmailID"];
            }
        }

        public string AccountKey
        {
            get
            {
                return this._configuration["AppSeettings:AccountKey"];
            }
        }

        public IConfigurationSection GetConfigurationSection(string key)
        {
            return this._configuration.GetSection(key);
        }
    }
}
