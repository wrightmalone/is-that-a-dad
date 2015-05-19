using is_that_a_dad.Core.Entities;

namespace is_that_a_dad.Core.Dadliness.Responses
{
  public class TwentiesResponse
  {
    public string GenerateTwentiesResponse(Face face) {
      var twentiesString = "don't know man... could go either way. depends prolly on how careful they've been. ";
      if (face.Attribute.Age.Range > 5) {
        twentiesString += "i'm not even sure if they're in their 20s";
      }
      return twentiesString;
    }
  }
}
