using System;

namespace is_that_a_dad.Core
{
  class Inputs
  {
    public Uri SelectUrl(string uri) {
      var convertedUri = new Uri(uri);
      return convertedUri;
    }
  }
}
