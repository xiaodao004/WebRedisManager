﻿using SAEA.Common;
using SAEA.MVC;
using System;
using System.Diagnostics;

namespace SAEA.WebRedisManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.Title = "WebRedisManager";

            var config = SAEAMvcApplicationConfigBuilder.Read();

            config.Port = 16379;

            SAEAMvcApplicationConfigBuilder.Write(config);

            SAEAMvcApplication mvcApplication = new SAEAMvcApplication(config);

            mvcApplication.Start();

            ConsoleHelper.WriteLine("WebRedisManager已启动");

            ConsoleHelper.WriteLine("请在浏览器上打开：http://localhost:16379/");

            ConsoleHelper.WriteLine("回车退出服务...");

            ConsoleHelper.ReadLine();
        }
    }
}
