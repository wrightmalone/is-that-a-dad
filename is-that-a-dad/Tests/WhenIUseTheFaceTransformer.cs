using is_that_a_dad.Core.Api;
using is_that_a_dad.Core.Entities;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace is_that_a_dad.Tests
{
  [TestFixture]
  class WhenIUseTheFaceTransformer : FaceBase
  {
    public List<Face> TransformedFaces;

    WhenIUseTheFaceTransformer() {
      var transformer = new FaceTransformer();

      var simulatedApiResponse = Faces;

      TransformedFaces = transformer.Transform(simulatedApiResponse);
    }

    [Test]
    public void It_should_return_a_list_of_all_faces() {
      Assert.Equals(TransformedFaces.Count, FaceCount);
    }

    [Test]
    public void The_first_face_should_have_correct_information() {
      var firstFace = TransformedFaces.First();
      Assert.Equals(firstFace.Attribute.Age.Value, Face1.Attribute.Age.Value);
      Assert.Equals(firstFace.Attribute.Age.Range, Face1.Attribute.Age.Range);
      Assert.Equals(firstFace.Attribute.Gender.Value, Face1.Attribute.Gender.Value);
      Assert.Equals(firstFace.Attribute.Gender.Confidence, Face1.Attribute.Gender.Confidence);
      Assert.Equals(firstFace.Attribute.Race.Value, Face1.Attribute.Race.Value);
      Assert.Equals(firstFace.Attribute.Race.Confidence, Face1.Attribute.Race.Confidence);

      TransformedFaces.RemoveAt(0);
    }

    [Test]
    public void The_second_face_should_have_correct_information() {
      var secondFace = TransformedFaces.First();
      Assert.Equals(secondFace.Attribute.Age.Value, Face1.Attribute.Age.Value);
      Assert.Equals(secondFace.Attribute.Age.Range, Face1.Attribute.Age.Range);
      Assert.Equals(secondFace.Attribute.Gender, Face1.Attribute.Gender.Value);
      Assert.Equals(secondFace.Attribute.Gender.Confidence, Face1.Attribute.Gender.Confidence);
      Assert.Equals(secondFace.Attribute.Race.Value, Face1.Attribute.Race.Value);
      Assert.Equals(secondFace.Attribute.Race.Confidence, Face1.Attribute.Race.Confidence);

      TransformedFaces.RemoveAt(0);
    }

    [Test]
    public void The_third_face_should_have_correct_information() {
      var thirdFace = TransformedFaces.First();
      Assert.Equals(thirdFace.Attribute.Age.Value, Face1.Attribute.Age.Value);
      Assert.Equals(thirdFace.Attribute.Age.Range, Face1.Attribute.Age.Range);
      Assert.Equals(thirdFace.Attribute.Gender.Value, Face1.Attribute.Gender.Value);
      Assert.Equals(thirdFace.Attribute.Gender.Confidence, Face1.Attribute.Gender.Confidence);
      Assert.Equals(thirdFace.Attribute.Race.Value, Face1.Attribute.Race.Value);
      Assert.Equals(thirdFace.Attribute.Race.Confidence, Face1.Attribute.Race.Confidence);
    }
  }
}
