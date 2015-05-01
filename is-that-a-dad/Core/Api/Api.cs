using is_that_a_dad.Core.Entities.Response;
using is_that_a_dad.Core.Settings;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace is_that_a_dad.Core.Api
{
  class Api
  {
    public Response Get(Uri uri, Uri imageUri) {
      var transformer = new FaceTransformer();
      var client = new RestClient(uri);
      var request = new RestRequest("detection/detect", Method.GET);
      request.AddParameter("api_key", ApiSettings.ApiKey);
      request.AddParameter("api_secret", ApiSettings.ApiSecret);
      request.AddParameter("url", imageUri);

      var response = client.Execute(request);
      if (response.StatusCode != HttpStatusCode.OK) {
        throw new Exception(String.Format("Get request returned a status code of: {0}", response.StatusCode));
      }
      var faceData = JsonConvert.DeserializeObject<Response>(response.Content);

      return faceData;
    }
  }
}
