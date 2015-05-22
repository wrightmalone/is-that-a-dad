

using System.Windows.Forms;

namespace is_that_a_dad_form
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.button1 = new System.Windows.Forms.Button();
      this.UrlBox = new System.Windows.Forms.TextBox();
      this.DadImageBox = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.ResponseBox = new System.Windows.Forms.TextBox();
      this.Title = new System.Windows.Forms.Label();
      this.AgeLabel = new System.Windows.Forms.Label();
      this.AgeTextBox = new System.Windows.Forms.TextBox();
      this.top = new System.Windows.Forms.PictureBox();
      this.bottom = new System.Windows.Forms.PictureBox();
      this.left = new System.Windows.Forms.PictureBox();
      this.right = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.DadImageBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bottom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(384, 496);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(130, 29);
      this.button1.TabIndex = 0;
      this.button1.Text = "check dad status";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1Click);
      // 
      // UrlBox
      // 
      this.UrlBox.BackColor = System.Drawing.SystemColors.MenuText;
      this.UrlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.UrlBox.ForeColor = System.Drawing.SystemColors.Window;
      this.UrlBox.Location = new System.Drawing.Point(54, 496);
      this.UrlBox.Name = "UrlBox";
      this.UrlBox.Size = new System.Drawing.Size(324, 29);
      this.UrlBox.TabIndex = 1;
      this.UrlBox.Text = "enter url for the image";
      // 
      // DadImageBox
      // 
      this.DadImageBox.BackColor = System.Drawing.Color.Black;
      this.DadImageBox.Image = global::is_that_a_dad_form.Properties.Resources.hesADadForSure;
      this.DadImageBox.InitialImage = global::is_that_a_dad_form.Properties.Resources.hesADadForSure;
      this.DadImageBox.Location = new System.Drawing.Point(135, 140);
      this.DadImageBox.Name = "DadImageBox";
      this.DadImageBox.Size = new System.Drawing.Size(308, 318);
      this.DadImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.DadImageBox.TabIndex = 2;
      this.DadImageBox.TabStop = false;
      //this.DadImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(216, 549);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(126, 27);
      this.label1.TabIndex = 3;
      this.label1.Text = "Dad Status:";
      // 
      // ResponseBox
      // 
      this.ResponseBox.Enabled = false;
      this.ResponseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ResponseBox.Location = new System.Drawing.Point(56, 579);
      this.ResponseBox.Multiline = true;
      this.ResponseBox.Name = "ResponseBox";
      this.ResponseBox.Size = new System.Drawing.Size(458, 73);
      this.ResponseBox.TabIndex = 4;
      this.ResponseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(88, 29);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(417, 73);
      this.Title.TabIndex = 5;
      this.Title.Text = "is that a dad?";
      // 
      // AgeLabel
      // 
      this.AgeLabel.AutoSize = true;
      this.AgeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AgeLabel.Location = new System.Drawing.Point(251, 666);
      this.AgeLabel.Name = "AgeLabel";
      this.AgeLabel.Size = new System.Drawing.Size(58, 27);
      this.AgeLabel.TabIndex = 6;
      this.AgeLabel.Text = "Age:";
      // 
      // AgeTextBox
      // 
      this.AgeTextBox.Enabled = false;
      this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AgeTextBox.Location = new System.Drawing.Point(222, 696);
      this.AgeTextBox.Multiline = true;
      this.AgeTextBox.Name = "AgeTextBox";
      this.AgeTextBox.Size = new System.Drawing.Size(110, 73);
      this.AgeTextBox.TabIndex = 7;
      this.AgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // top
      // 
      this.top.BackColor = System.Drawing.Color.Black;
      this.top.Location = new System.Drawing.Point(200, 239);
      this.top.Name = "top";
      this.top.Size = new System.Drawing.Size(174, 5);
      this.top.TabIndex = 8;
      this.top.TabStop = false;
      // 
      // bottom
      // 
      this.bottom.BackColor = System.Drawing.Color.Black;
      this.bottom.Location = new System.Drawing.Point(200, 396);
      this.bottom.Name = "bottom";
      this.bottom.Size = new System.Drawing.Size(174, 5);
      this.bottom.TabIndex = 9;
      this.bottom.TabStop = false;
      // 
      // left
      // 
      this.left.BackColor = System.Drawing.Color.Black;
      this.left.Location = new System.Drawing.Point(200, 239);
      this.left.Name = "left";
      this.left.Size = new System.Drawing.Size(5, 160);
      this.left.TabIndex = 10;
      this.left.TabStop = false;
      // 
      // right
      // 
      this.right.BackColor = System.Drawing.Color.Black;
      this.right.Location = new System.Drawing.Point(369, 240);
      this.right.Name = "right";
      this.right.Size = new System.Drawing.Size(5, 160);
      this.right.TabIndex = 11;
      this.right.TabStop = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Honeydew;
      this.ClientSize = new System.Drawing.Size(583, 815);
      this.Controls.Add(this.right);
      this.Controls.Add(this.left);
      this.Controls.Add(this.bottom);
      this.Controls.Add(this.top);
      this.Controls.Add(this.AgeTextBox);
      this.Controls.Add(this.AgeLabel);
      this.Controls.Add(this.Title);
      this.Controls.Add(this.ResponseBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.DadImageBox);
      this.Controls.Add(this.UrlBox);
      this.Controls.Add(this.button1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.Text = "is that a dad?";
      this.TransparencyKey = System.Drawing.Color.SpringGreen;
      ((System.ComponentModel.ISupportInitialize)(this.DadImageBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bottom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox UrlBox;
    private System.Windows.Forms.PictureBox DadImageBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox ResponseBox;
    private System.Windows.Forms.Label Title;
    private System.Windows.Forms.Label AgeLabel;
    private System.Windows.Forms.TextBox AgeTextBox;
    private PictureBox top;
    private PictureBox bottom;
    private PictureBox left;
    private PictureBox right;
  }
}

