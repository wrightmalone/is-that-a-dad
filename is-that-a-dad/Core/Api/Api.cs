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
          new Face{ Age = 0, AgeRange = 0, Gender = "?", GenderConfidence = 0, Race = "?", RaceConfidence = 0 }
        };
        //throw new Exception(String.Format("Get request returned a status code of: {0}", response.StatusCode));
      }
      var faceData = JsonConvert.DeserializeObject<Response>(response.Content);
      var faces = transformer.Transform(faceData);
      return faces;
    }
  }
}
