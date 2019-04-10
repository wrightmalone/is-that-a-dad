using System;

namespace is_that_a_dad.Core.Settings
{
  class ApiSettings
  {
    public static Uri BaseUri = new Uri("http://api.cn.faceplusplus.com/");
    public static Uri TestUri = new Uri("http://localhost:9000/");
    public static string ApiKey = "";
    public static string ApiSecret = "";
  }
}
