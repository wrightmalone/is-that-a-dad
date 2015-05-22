using is_that_a_dad.Core.Entities;
using is_that_a_dad.Core.Entities.FaceEnclosureBox;

namespace is_that_a_dad.Core.ImageSizing
{
  public class GetFaceEnclosure
  {
    public FaceEnclosure GetEnclosure(int imageHeight, int imageWidth, int frameHeight, int frameWidth, Face face) {
      var widthRatio = (double)frameWidth / imageWidth;
      var heightRatio = (double)frameHeight / imageHeight;

      var enclosure = new FaceEnclosure {
        Center = new Point { X = face.Center.X * widthRatio, Y = face.Center.Y * heightRatio },
        Width = face.Width / 100 * imageWidth * widthRatio,
        Height = face.Height / 100 * imageHeight * heightRatio
      };

      return enclosure;
    }
  }
}
