using is_that_a_dad.Core.Api;
using is_that_a_dad.Core.Entities;
using is_that_a_dad.Core.Settings;
using System;
using System.Linq;

namespace is_that_a_dad.Core
{
  public class Retrieval
  {
    public Face GetInfo(Uri imageUri) {
      var api = new Api.Api();
      var transformer = new FaceTransformer();
      var faceResponse = api.Get(ApiSettings.BaseUri, imageUri);
      var faces = transformer.Transform(faceResponse);

      //Todo: add support for multiple faces
      var face = faces.First();

      return face;
    }
  }
}
