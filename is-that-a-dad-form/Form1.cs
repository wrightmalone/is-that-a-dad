using is_that_a_dad.Core.Api;
using is_that_a_dad.Core.Dadliness;
using is_that_a_dad.Core.Entities.FaceEnclosureBox;
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

      DadImageBox.Load(uri);

      var pictureSize = new DadDisplayImage {
        Height = DadImageBox.Image.Height,
        Width = DadImageBox.Image.Width
      };

      ResponseBox.Text = dadliness;
      AgeTextBox.Text = faces.First().Attribute.Age.Value.ToString(CultureInfo.InvariantCulture);

      textBox1.Text = string.Format("{0}, {1}, {2}, {3}", pictureSize.Height, pictureSize.Width, DadImageBox.Height, DadImageBox.Width);
    }
  }
}
