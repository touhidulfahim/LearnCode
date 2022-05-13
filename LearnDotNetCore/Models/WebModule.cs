using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using LearnDotNetCore.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace LearnDotNetCore.Models
{
    public class WebModule : Module
    {
        //private readonly string _connectionString;
        //private readonly string _migrationAssemblyName;
        //private readonly IConfiguration _configuration;
        //private readonly IWebHostEnvironment _webHostEnvironment;
        //public WebModule(string connectionStringName, string
        //        migrationAssemblyName,
        //    IConfiguration configuration,
        //    IWebHostEnvironment webHostEnvironment)
        //{
        //    _connectionString = connectionStringName;
        //    _migrationAssemblyName = migrationAssemblyName;
        //    _configuration = configuration;
        //    _webHostEnvironment = webHostEnvironment;
        //}
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleDbService>().As<IDbService>().InstancePerLifetimeScope();
            //builder.RegisterType<TracksModel>().AsSelf();
            //builder.RegisterType<CourseBatchModel>().AsSelf();
            //builder.RegisterType<ReferralModel>().AsSelf();
            //builder.RegisterType<CourseModel>().AsSelf();
            //builder.RegisterType<DataTablesAjaxRequestModel>().As < IDataTablesAjaxReq
            //tModel > ()
            //    .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
