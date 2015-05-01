using is_that_a_dad.Core.Api;
using is_that_a_dad.Core.Entities;
using NUnit.Framework;
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

    public WhenIUseTheApi() {
      Faces = Api.Get("http://c3458338.r38.cf0.rackcdn.com/don-cheadle.jpg");
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
