using is_that_a_dad.Core.Api;
using is_that_a_dad.Core.Dadliness;
using is_that_a_dad.Core.Entities;
using is_that_a_dad.Core.Entities.FaceEnclosureBox;
using is_that_a_dad.Core.ImageSizing;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace is_that_a_dad_form
{
  public partial class MainForm : Form
  {
    public Api Api = new Api();
    public Dadliness Dadliness = new Dadliness();
    public Image Loading;
    public Face Face;

    public MainForm() {
      InitializeComponent();
    }

    private void Button1Click(object sender, EventArgs e) {
      DadImageBox.Image = Properties.Resources.loading;

      var uri = UrlBox.Text;
      if (uri == "enter url for the image" || uri == null) {
        ResponseBox.Text = "i cant check the dadliness if you dont give me a url";
        return;
      }
      var faces = Api.Get(uri);

      var dadliness = "";
      //todo: expand functionality to check multiple dads
      dadliness = faces.First().Attribute.Age.Value == 0 ? "image failed to produce a result. you may never know their dadliness." : Dadliness.CheckDadliness(faces.First());
      Face = faces.First();
      DadImageBox.Load(uri);

      ResponseBox.Text = dadliness;
      AgeTextBox.Text = faces.First().Attribute.Age.Value.ToString(CultureInfo.InvariantCulture);
      ChangeBorder();
      //DadImageBoxPaint(sender, new PaintEventArgs(CreateGraphics(), new Rectangle()));
    }

    private void ChangeBorder() {
      var pictureSize = new DadDisplayImage {
        Height = DadImageBox.Image.Height,
        Width = DadImageBox.Image.Width
      };

      var enclosureGetter = new GetFaceEnclosure();
      var enclosureSize = enclosureGetter.GetEnclosure(pictureSize.Height, pictureSize.Width, DadImageBox.Height, DadImageBox.Width, Face);

      const int thickness = 5;
      var w = Convert.ToInt32(enclosureSize.Width) + thickness;
      var h = Convert.ToInt32(enclosureSize.Height) + thickness;

      var leftPoint = new System.Drawing.Point(Convert.ToInt32(DadImageBox.Location.X + enclosureSize.Center.X + enclosureSize.Width / 2), Convert.ToInt32(DadImageBox.Location.Y + enclosureSize.Center.Y + enclosureSize.Height / 2));

      if (DadImageBox.Image.Width < DadImageBox.Width) {
        leftPoint.X = Convert.ToInt32(leftPoint.X - (DadImageBox.Width - (double)DadImageBox.Image.Width) / 1.5 - thickness);
        w = Convert.ToInt32(w * ((double)DadImageBox.Image.Width / (double)DadImageBox.Width));
      }

      if (DadImageBox.Image.Height < DadImageBox.Height) {
        leftPoint.Y = leftPoint.Y - Convert.ToInt32(((double)DadImageBox.Height - (double)DadImageBox.Image.Height) / 2.5);
        leftPoint.X = Convert.ToInt32((double)leftPoint.X * .95);
        h = Convert.ToInt32(h * ((double)DadImageBox.Image.Height / (double)DadImageBox.Height));
      }

      var topPoint = leftPoint;
      var rightPoint = new System.Drawing.Point(leftPoint.X + w - thickness, leftPoint.Y);
      var bottomPoint = new System.Drawing.Point(leftPoint.X, leftPoint.Y + h - thickness);

      left.Location = leftPoint;
      left.Width = thickness;
      left.Height = h;

      top.Location = topPoint;
      top.Width = w;
      top.Height = thickness;

      right.Location = rightPoint;
      right.Width = thickness;
      right.Height = h;

      bottom.Location = bottomPoint;
      bottom.Width = w;
      bottom.Height = thickness;

      /*base.OnPaint(e);

      if (Face == null) return;
      var pictureSize = new DadDisplayImage {
        Height = DadImageBox.Image.Height,
        Width = DadImageBox.Image.Width
      };

      var enclosureGetter = new GetFaceEnclosure();
      var enclosureSize = enclosureGetter.GetEnclosure(pictureSize.Height, pictureSize.Width, DadImageBox.Height, DadImageBox.Width, Face);


      var blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 9);
      var topLeftX = Convert.ToInt32(DadImageBox.Left + enclosureSize.Center.X - enclosureSize.Width / 2);
      var topLeftY = Convert.ToInt32(DadImageBox.Top + enclosureSize.Center.Y - enclosureSize.Height / 2);
      e.Graphics.DrawRectangle(blackPen, 1, 1, 50, 50);//topLeftX, topLeftY, Convert.ToInt32(enclosureSize.Width), Convert.ToInt32(enclosureSize.Height));

      Face = null;*/
    }
  }
}
