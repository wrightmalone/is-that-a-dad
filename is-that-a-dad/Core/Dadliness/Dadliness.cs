using is_that_a_dad.Core.Dadliness.Responses;
using is_that_a_dad.Core.Entities;

namespace is_that_a_dad.Core.Dadliness
{
  public class Dadliness
  {
    public LadyResponse LadyResponse = new LadyResponse();
    public ChildResponse ChildResponse = new ChildResponse();
    public TeenagerResponse TeenagerResponse = new TeenagerResponse();
    public TwentiesResponse TwentiesResponse = new TwentiesResponse();

    public string CheckDadliness(Face face) {
      var dadliness = "";
      if (face.Gender != "Male") {
        dadliness += LadyResponse.GenerateLadyResponse(face);
      } else if (face.Age < 13) {
        dadliness += ChildResponse.GenerateChildResponse(face);
      } else if (face.Age < 18) {
        dadliness += TeenagerResponse.GenerateTeenagerResponse(face);
      } else if (face.Age < 25) {
        dadliness += TwentiesResponse.GenerateTwentiesResponse(face);
      } else if (face.Age < 40) {
        dadliness += "totally dad material.";
      } else if (face.Age < 50) {
        dadliness += "get prepared to hear some dad jokes. because he's a dad. ";
      } else {
        dadliness += "dude i bet that's a double dad. he's the dad of a dad. ";
      }

      return dadliness;
    }
  }
}
