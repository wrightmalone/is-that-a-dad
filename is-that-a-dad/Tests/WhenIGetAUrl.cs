using is_that_a_dad.Core;
using NUnit.Framework;
using System;

namespace is_that_a_dad.Tests
{
  class WhenIGetAUrl
  {
    public Inputs Inputs = new Inputs();
    [Test]
    public void It_should_convert_the_string() {
      const string theUrlString = "http://google.com";
      var theConvertedString = Inputs.SelectUrl(theUrlString);
      Assert.IsInstanceOf<Uri>(theConvertedString);
    }
  }
}
