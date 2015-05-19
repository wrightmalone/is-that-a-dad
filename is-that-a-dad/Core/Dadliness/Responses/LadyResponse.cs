using is_that_a_dad.Core.Entities;

namespace is_that_a_dad.Core.Dadliness.Responses
{
  public class LadyResponse
  {
    public string GenerateLadyResponse(Face face) {
      var ladyString = "i think that's a lady so prolly not a dad... ";

      if (face.Attribute.Gender.Confidence > .95) {
        ladyString += "and im pretty sure about it";
      } else {
        ladyString += "but im not so confident";
      }
      return ladyString;
    }
  }
}
