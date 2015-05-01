using is_that_a_dad.Core.Entities.Response;

namespace is_that_a_dad.Tests
{
  public class FaceBase
  {
    public FaceResponse Face1;
    public FaceResponse Face2;
    public FaceResponse Face3;
    public Response Faces;
    public int FaceCount;

    public FaceBase() {
      Face1 = new FaceResponse {
        Attribute = new Core.Entities.Response.Attribute {
          Age = new Age {
            Range = 4,
            Value = 28,
          },
          Gender = new Gender {
            Confidence = .9996F,
            Value = "male",
          },
          Race = new Race {
            Confidence = .714F,
            Value = "White",
          },
        }
      };

      Face2 = new FaceResponse {
        Attribute = new Core.Entities.Response.Attribute {
          Age = new Age {
            Range = 7,
            Value = 45,
          },
          Gender = new Gender {
            Confidence = .9126F,
            Value = "male",
          },
          Race = new Race {
            Confidence = .914F,
            Value = "Black",
          },
        }
      };

      Face3 = new FaceResponse {
        Attribute = new Core.Entities.Response.Attribute {
          Age = new Age {
            Range = 1,
            Value = 15,
          },
          Gender = new Gender {
            Confidence = .8126F,
            Value = "female",
          },
          Race = new Race {
            Confidence = .7254F,
            Value = "Black",
          },
        }
      };

      Faces = new Response {
        Face = new[] { Face1, Face2, Face3 }
      };

      FaceCount = 3;
    }
  }
}
