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
          Attribute = new Attribute {
            Age = new Age {
              Value = face.Attribute.Age.Value,
              Range = face.Attribute.Age.Range,
            },
            Gender = new Gender {
              Value = face.Attribute.Gender.Value,
              Confidence = face.Attribute.Gender.Confidence,
            },
            Race = new Race {
              Value = face.Attribute.Race.Value,
              Confidence = face.Attribute.Race.Confidence,
            }
          },
          Center = new Point {
            X = face.Center.X,
            Y = face.Center.Y,
          },
          Height = face.Height,
          Width = face.Width,
        }));
      return transformedFaces;
    }
  }
}
