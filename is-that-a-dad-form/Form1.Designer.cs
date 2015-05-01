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
      ((System.ComponentModel.ISupportInitialize)(this.DadImageBox)).BeginInit();
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
      this.button1.Click += new System.EventHandler(this.button1_Click);
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
      this.DadImageBox.TabIndex = 2;
      this.DadImageBox.TabStop = false;
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
      this.ResponseBox.Size = new System.Drawing.Size(458, 144);
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Honeydew;
      this.ClientSize = new System.Drawing.Size(583, 770);
      this.Controls.Add(this.Title);
      this.Controls.Add(this.ResponseBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.DadImageBox);
      this.Controls.Add(this.UrlBox);
      this.Controls.Add(this.button1);
      this.Name = "MainForm";
      this.Text = "is that a dad?";
      this.TransparencyKey = System.Drawing.Color.SpringGreen;
      ((System.ComponentModel.ISupportInitialize)(this.DadImageBox)).EndInit();
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
  }
}

