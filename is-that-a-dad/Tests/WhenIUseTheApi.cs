using is_that_a_dad.Core.Api;
using is_that_a_dad.Core.Entities;
using is_that_a_dad.Core.Entities.Response;
using is_that_a_dad.Core.Settings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace is_that_a_dad.Tests
{
  [TestFixture]
  class WhenIUseTheApi
  {
    public Api Api = new Api();
    public List<Face> Faces;
    public Face Face;
    public Response FaceData;
    public int Age;
    public WhenIUseTheApi() {
      var transformer = new FaceTransformer();
      FaceData = Api.Get(ApiSettings.BaseUri, new Uri("http://c3458338.r38.cf0.rackcdn.com/don-cheadle.jpg"));
      Faces = transformer.Transform(FaceData);

      Face = Faces.First();
    }

    [Test]
    public void It_should_get_the_object() {
      Assert.IsNotNull(Face.Age);
      Assert.IsNotNullOrEmpty(Face.Gender);
      Assert.IsNotNullOrEmpty(Face.Race);
    }
  }
}
