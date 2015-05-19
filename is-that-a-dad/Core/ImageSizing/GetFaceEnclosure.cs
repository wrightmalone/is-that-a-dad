using is_that_a_dad.Core.Entities;
using is_that_a_dad.Core.Entities.FaceEnclosureBox;

namespace is_that_a_dad.Core.ImageSizing
{
  class GetFaceEnclosure
  {
    public FaceEnclosure GetEnclosure(int imageHeight, int imageWidth, int frameHeight, int frameWidth, Face face) {
      var widthRatio = imageWidth / frameWidth;
      var heightRatio = imageHeight / frameHeight;

      var enclosure = new FaceEnclosure {
        Center = new Point { X = face.Center.X * widthRatio, Y = face.Center.Y * heightRatio },
        Width = face.Width * widthRatio,
        Height = face.Height * heightRatio
      };

      return enclosure;
    }
  }
}
