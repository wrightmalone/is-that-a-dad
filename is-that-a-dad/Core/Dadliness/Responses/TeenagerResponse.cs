using is_that_a_dad.Core.Entities;

namespace is_that_a_dad.Core.Dadliness.Responses
{
  public class TeenagerResponse
  {
    public string GenerateTeenagerResponse(Face face) {
      var teenString = "i mean maybe they're a dad if we're watching mtv. ";
      if (face.AgeRange > 4) {
        teenString += "but i don't know, maybe they're older.";
      } else {
        teenString += "and i'm pretty sure they're exactly that young.";
      }
      return teenString;
    }
  }
}
