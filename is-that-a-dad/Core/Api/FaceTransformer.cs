using is_that_a_dad.Core.Entities;
using is_that_a_dad.Core.Entities.Response;
using System.Collections.Generic;
using System.Linq;

namespace is_that_a_dad.Core.Api
{
  class FaceTransformer
  {
    public List<Face> Transform(Response response) {
      var transformedFaces = new List<Face> { };
      transformedFaces.AddRange(response.Face.Select(
        face => new Face {
          Age = face.Attribute.Age.Value,
          AgeRange = face.Attribute.Age.Range,
          Gender = face.Attribute.Gender.Value,
          GenderConfidence = face.Attribute.Gender.Confidence,
          Race = face.Attribute.Race.Value,
          RaceConfidence = face.Attribute.Race.Confidence,
        }));
      return transformedFaces;
    }
  }
}
