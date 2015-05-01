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
      Assert.Equals(firstFace.Age, Face1.Attribute.Age.Value);
      Assert.Equals(firstFace.AgeRange, Face1.Attribute.Age.Range);
      Assert.Equals(firstFace.Gender, Face1.Attribute.Gender.Value);
      Assert.Equals(firstFace.GenderConfidence, Face1.Attribute.Gender.Confidence);
      Assert.Equals(firstFace.Race, Face1.Attribute.Race.Value);
      Assert.Equals(firstFace.RaceConfidence, Face1.Attribute.Race.Confidence);

      TransformedFaces.RemoveAt(0);
    }

    [Test]
    public void The_second_face_should_have_correct_information() {
      var secondFace = TransformedFaces.First();
      Assert.Equals(secondFace.Age, Face1.Attribute.Age.Value);
      Assert.Equals(secondFace.AgeRange, Face1.Attribute.Age.Range);
      Assert.Equals(secondFace.Gender, Face1.Attribute.Gender.Value);
      Assert.Equals(secondFace.GenderConfidence, Face1.Attribute.Gender.Confidence);
      Assert.Equals(secondFace.Race, Face1.Attribute.Race.Value);
      Assert.Equals(secondFace.RaceConfidence, Face1.Attribute.Race.Confidence);

      TransformedFaces.RemoveAt(0);
    }

    [Test]
    public void The_third_face_should_have_correct_information() {
      var thirdFace = TransformedFaces.First();
      Assert.Equals(thirdFace.Age, Face1.Attribute.Age.Value);
      Assert.Equals(thirdFace.AgeRange, Face1.Attribute.Age.Range);
      Assert.Equals(thirdFace.Gender, Face1.Attribute.Gender.Value);
      Assert.Equals(thirdFace.GenderConfidence, Face1.Attribute.Gender.Confidence);
      Assert.Equals(thirdFace.Race, Face1.Attribute.Race.Value);
      Assert.Equals(thirdFace.RaceConfidence, Face1.Attribute.Race.Confidence);
    }
  }
}
