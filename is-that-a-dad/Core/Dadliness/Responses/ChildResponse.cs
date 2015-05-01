using is_that_a_dad.Core.Entities;

namespace is_that_a_dad.Core.Dadliness.Responses
{
  public class ChildResponse
  {
    public string GenerateChildResponse(Face face) {
      var childString = "dude that's a kid. get it together. ";
      if (face.AgeRange > 4) {
        childString += "ok, maybe he's a little older. But still.";
      }
      return childString;
    }
  }
}
