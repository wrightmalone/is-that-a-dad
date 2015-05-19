using is_that_a_dad.Core.Entities;
using is_that_a_dad.Core.Entities.Response;
using is_that_a_dad.Core.Settings;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Net;

namespace is_that_a_dad.Core.Api
{
  public class Api
  {
    public List<Face> Get(string imageUriString) {
      var transformer = new FaceTransformer();
      var inputs = new Inputs();

      var imageUri = inputs.SelectUrl(imageUriString);
      var client = new RestClient(ApiSettings.BaseUri);
      var request = new RestRequest("detection/detect", Method.GET);
      request.AddParameter("api_key", ApiSettings.ApiKey);
      request.AddParameter("api_secret", ApiSettings.ApiSecret);
      request.AddParameter("url", imageUri);

      var response = client.Execute(request);
      if (response.StatusCode != HttpStatusCode.OK) {
        return new List<Face> {
          new Face{ Attribute = { Age = {Range = 0, Value = 0}, Gender = {Value = "?", Confidence = 0}, Race = {Value = "?", Confidence = 0} }, Center = {X = 0, Y = 0}, Height = 0, Width = 0}
        };
      }
      var faceData = JsonConvert.DeserializeObject<Response>(response.Content);
      var faces = transformer.Transform(faceData);
      return faces;
    }
  }
}
