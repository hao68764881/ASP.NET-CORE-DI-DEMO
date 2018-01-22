using Autofac;
using DEMO.IServices;
using DEMO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMO.AutoDI
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //builder.Register(c => new AOPTest());
            //注入测试服务
            //builder.RegisterType<TestService>().As<ITestService>();
            //属性注入
            builder.RegisterType<TestService>().As<ITestService>().PropertiesAutowired();
          
        }
    }
}
