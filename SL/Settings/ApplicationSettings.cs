﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SL.Settings
{
    public static class ApplicationSettings
    {
        public static IConfiguration Configuration;
        //readonly static string path;
        readonly static string IPath;
        readonly static string conString;
        readonly static string SP_Login;
        readonly static string Composite;
        readonly static string path;

        readonly static string BkupDB;
        static ApplicationSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json");
            Configuration = builder.Build();



            path = Configuration.GetSection("AppSettings").GetSection("filePath").Value;
            //utilizar solo 1 base de datos
            BkupDB = Configuration.GetSection("AppSettings").GetSection("Bkup").Value;
            conString = Configuration.GetConnectionString("SqlConnection");
            IPath = Configuration.GetSection("AppSettings").GetSection("idiomaPath").Value;
            SP_Login = Configuration.GetSection("AppSettings").GetSection("SP_Login").Value;
            Composite = Configuration.GetConnectionString("ServiceLayerSqlConnection");
        }
        public static string Path
        {
            get
            {
                return path;
            }
        }
        public static string BackUp
        {
            get
            {
                return BkupDB;
            }
        }
        public static string CompoPath
        {
            get
            {
                return Composite;
            }
        }
        public static string SQLPath
        {
            get
            {
                return conString;
            }
        }
        public static string IdiomaPath
        {
            get
            {
                return IPath;
            }
        }
        public static string StoredProcedure_Login
        {
            get
            {
                return SP_Login;
            }
        }
    }
}
