namespace Ramon_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtDisplay = new TextBox();
            buttonZero = new Button();
            buttonDecimal = new Button();
            buttonNP = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonAdd = new Button();
            buttonMul = new Button();
            buttonSub = new Button();
            buttonDiv = new Button();
            button17 = new Button();
            button18 = new Button();
            buttonEqual = new Button();
            buttonClear = new Button();
            darkMode = new CheckBox();
            scientificMode = new RadioButton();
            standardMode = new RadioButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pi = new Button();
            x2 = new Button();
            xy = new Button();
            sine = new Button();
            tabPage2 = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            message = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplay.Location = new Point(5, 23);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(419, 57);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0.";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonZero
            // 
            buttonZero.BackColor = SystemColors.ActiveCaptionText;
            buttonZero.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZero.ForeColor = SystemColors.ButtonFace;
            buttonZero.Location = new Point(23, 322);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(55, 52);
            buttonZero.TabIndex = 1;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = false;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.BackColor = SystemColors.ActiveCaptionText;
            buttonDecimal.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecimal.ForeColor = SystemColors.ButtonFace;
            buttonDecimal.Location = new Point(84, 322);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(55, 52);
            buttonDecimal.TabIndex = 2;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = false;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // buttonNP
            // 
            buttonNP.BackColor = SystemColors.ActiveCaptionText;
            buttonNP.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNP.ForeColor = SystemColors.ButtonFace;
            buttonNP.Location = new Point(145, 322);
            buttonNP.Name = "buttonNP";
            buttonNP.Size = new Size(55, 52);
            buttonNP.TabIndex = 3;
            buttonNP.Text = "+-";
            buttonNP.UseVisualStyleBackColor = false;
            buttonNP.Click += buttonNP_Click;
            // 
            // buttonOne
            // 
            buttonOne.BackColor = SystemColors.ActiveCaptionText;
            buttonOne.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOne.ForeColor = SystemColors.ButtonFace;
            buttonOne.Location = new Point(23, 264);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(55, 52);
            buttonOne.TabIndex = 4;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = SystemColors.ActiveCaptionText;
            buttonTwo.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTwo.ForeColor = SystemColors.ButtonFace;
            buttonTwo.Location = new Point(84, 264);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(55, 52);
            buttonTwo.TabIndex = 5;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonThree
            // 
            buttonThree.BackColor = SystemColors.ActiveCaptionText;
            buttonThree.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThree.ForeColor = SystemColors.ButtonFace;
            buttonThree.Location = new Point(145, 264);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(55, 52);
            buttonThree.TabIndex = 6;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = false;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonFour
            // 
            buttonFour.BackColor = SystemColors.ActiveCaptionText;
            buttonFour.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFour.ForeColor = SystemColors.ButtonFace;
            buttonFour.Location = new Point(23, 204);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(55, 52);
            buttonFour.TabIndex = 7;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonFive
            // 
            buttonFive.BackColor = SystemColors.ActiveCaptionText;
            buttonFive.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFive.ForeColor = SystemColors.ButtonFace;
            buttonFive.Location = new Point(84, 205);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(55, 52);
            buttonFive.TabIndex = 8;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = false;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonSix
            // 
            buttonSix.BackColor = SystemColors.ActiveCaptionText;
            buttonSix.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSix.ForeColor = SystemColors.ButtonFace;
            buttonSix.Location = new Point(145, 206);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(55, 52);
            buttonSix.TabIndex = 9;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = false;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.BackColor = SystemColors.ActiveCaptionText;
            buttonSeven.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeven.ForeColor = SystemColors.ButtonFace;
            buttonSeven.Location = new Point(23, 146);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(55, 52);
            buttonSeven.TabIndex = 10;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = false;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonEight
            // 
            buttonEight.BackColor = SystemColors.ActiveCaptionText;
            buttonEight.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEight.ForeColor = SystemColors.ButtonFace;
            buttonEight.Location = new Point(84, 147);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(55, 52);
            buttonEight.TabIndex = 11;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = false;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonNine
            // 
            buttonNine.BackColor = SystemColors.ActiveCaptionText;
            buttonNine.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNine.ForeColor = SystemColors.ButtonFace;
            buttonNine.Location = new Point(145, 147);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(55, 52);
            buttonNine.TabIndex = 12;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = false;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Violet;
            buttonAdd.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = SystemColors.ButtonFace;
            buttonAdd.Location = new Point(234, 184);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(55, 52);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonMul
            // 
            buttonMul.BackColor = Color.Violet;
            buttonMul.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMul.ForeColor = SystemColors.ButtonFace;
            buttonMul.Location = new Point(234, 242);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(55, 52);
            buttonMul.TabIndex = 14;
            buttonMul.Text = "*";
            buttonMul.UseVisualStyleBackColor = false;
            buttonMul.Click += buttonMul_Click;
            // 
            // buttonSub
            // 
            buttonSub.BackColor = Color.Violet;
            buttonSub.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSub.ForeColor = SystemColors.ButtonFace;
            buttonSub.Location = new Point(293, 184);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(55, 52);
            buttonSub.TabIndex = 15;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = false;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.BackColor = Color.Violet;
            buttonDiv.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDiv.ForeColor = SystemColors.ButtonFace;
            buttonDiv.Location = new Point(293, 243);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(55, 52);
            buttonDiv.TabIndex = 16;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = false;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.MediumSlateBlue;
            button17.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button17.ForeColor = SystemColors.ButtonFace;
            button17.Location = new Point(234, 302);
            button17.Name = "button17";
            button17.Size = new Size(55, 52);
            button17.TabIndex = 17;
            button17.Text = "1/X";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.MediumSlateBlue;
            button18.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button18.ForeColor = SystemColors.ButtonFace;
            button18.Location = new Point(295, 301);
            button18.Name = "button18";
            button18.Size = new Size(55, 52);
            button18.TabIndex = 18;
            button18.Text = "√";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = Color.MediumSlateBlue;
            buttonEqual.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEqual.ForeColor = SystemColors.ButtonFace;
            buttonEqual.Location = new Point(356, 184);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(55, 170);
            buttonEqual.TabIndex = 19;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.AppWorkspace;
            buttonClear.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(234, 126);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(177, 52);
            buttonClear.TabIndex = 20;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // darkMode
            // 
            darkMode.AutoSize = true;
            darkMode.Location = new Point(295, 86);
            darkMode.Name = "darkMode";
            darkMode.Size = new Size(84, 19);
            darkMode.TabIndex = 21;
            darkMode.Text = "Dark Mode";
            darkMode.UseVisualStyleBackColor = true;
            darkMode.CheckedChanged += darkMode_CheckedChanged;
            // 
            // scientificMode
            // 
            scientificMode.AutoSize = true;
            scientificMode.Location = new Point(145, 88);
            scientificMode.Name = "scientificMode";
            scientificMode.Size = new Size(73, 19);
            scientificMode.TabIndex = 22;
            scientificMode.Text = "Scientific";
            scientificMode.UseVisualStyleBackColor = true;
            scientificMode.CheckedChanged += scientificMode_CheckedChanged;
            // 
            // standardMode
            // 
            standardMode.AutoSize = true;
            standardMode.Checked = true;
            standardMode.Location = new Point(6, 88);
            standardMode.Name = "standardMode";
            standardMode.Size = new Size(72, 19);
            standardMode.TabIndex = 23;
            standardMode.TabStop = true;
            standardMode.Text = "Standard";
            standardMode.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(440, 498);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtDisplay);
            tabPage1.Controls.Add(pi);
            tabPage1.Controls.Add(buttonNP);
            tabPage1.Controls.Add(x2);
            tabPage1.Controls.Add(buttonDecimal);
            tabPage1.Controls.Add(xy);
            tabPage1.Controls.Add(buttonZero);
            tabPage1.Controls.Add(sine);
            tabPage1.Controls.Add(buttonThree);
            tabPage1.Controls.Add(button18);
            tabPage1.Controls.Add(buttonSix);
            tabPage1.Controls.Add(button17);
            tabPage1.Controls.Add(buttonTwo);
            tabPage1.Controls.Add(buttonDiv);
            tabPage1.Controls.Add(buttonEqual);
            tabPage1.Controls.Add(buttonMul);
            tabPage1.Controls.Add(buttonFive);
            tabPage1.Controls.Add(buttonOne);
            tabPage1.Controls.Add(buttonFour);
            tabPage1.Controls.Add(buttonSub);
            tabPage1.Controls.Add(buttonAdd);
            tabPage1.Controls.Add(buttonNine);
            tabPage1.Controls.Add(standardMode);
            tabPage1.Controls.Add(buttonClear);
            tabPage1.Controls.Add(buttonEight);
            tabPage1.Controls.Add(scientificMode);
            tabPage1.Controls.Add(buttonSeven);
            tabPage1.Controls.Add(darkMode);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(432, 470);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Calculator";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // pi
            // 
            pi.BackColor = Color.Violet;
            pi.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            pi.ForeColor = SystemColors.ButtonFace;
            pi.Location = new Point(293, 415);
            pi.Name = "pi";
            pi.Size = new Size(55, 52);
            pi.TabIndex = 27;
            pi.Text = "π";
            pi.UseVisualStyleBackColor = false;
            pi.Visible = false;
            pi.Click += pi_Click;
            // 
            // x2
            // 
            x2.BackColor = Color.Violet;
            x2.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            x2.ForeColor = SystemColors.ButtonFace;
            x2.Location = new Point(234, 414);
            x2.Name = "x2";
            x2.Size = new Size(55, 52);
            x2.TabIndex = 28;
            x2.Text = "x^2";
            x2.UseVisualStyleBackColor = false;
            x2.Visible = false;
            x2.Click += x2_Click;
            // 
            // xy
            // 
            xy.BackColor = Color.Violet;
            xy.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            xy.ForeColor = SystemColors.ButtonFace;
            xy.Location = new Point(295, 359);
            xy.Name = "xy";
            xy.Size = new Size(55, 52);
            xy.TabIndex = 26;
            xy.Text = "X^Y";
            xy.UseVisualStyleBackColor = false;
            xy.Visible = false;
            xy.Click += xy_Click;
            // 
            // sine
            // 
            sine.BackColor = Color.Violet;
            sine.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sine.ForeColor = SystemColors.ButtonFace;
            sine.Location = new Point(234, 360);
            sine.Name = "sine";
            sine.Size = new Size(55, 52);
            sine.TabIndex = 25;
            sine.Text = "SIN";
            sine.UseVisualStyleBackColor = false;
            sine.Visible = false;
            sine.Click += sine_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(message);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(432, 470);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "About Me";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(268, 317);
            button1.Name = "button1";
            button1.Size = new Size(131, 71);
            button1.TabIndex = 3;
            button1.Text = "click for fun!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(245, 14);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 297);
            textBox1.TabIndex = 2;
            textBox1.Text = "Hello, Im Ramon Evidente! I am a software engineering student at Centennial College. \r\nI love programming and going to the gym! ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(230, 322);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // message
            // 
            message.Location = new Point(268, 403);
            message.Name = "message";
            message.Size = new Size(131, 23);
            message.TabIndex = 4;
            message.TextChanged += message_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 492);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ramon Calculator";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDisplay;
        private Button buttonZero;
        private Button buttonDecimal;
        private Button buttonNP;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonAdd;
        private Button buttonMul;
        private Button buttonSub;
        private Button buttonDiv;
        private Button button17;
        private Button button18;
        private Button buttonEqual;
        private Button buttonClear;
        private CheckBox darkMode;
        private RadioButton scientificMode;
        private RadioButton standardMode;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button sine;
        private Button xy;
        private Button pi;
        private Button x2;
        private TabPage tabPage2;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
        private TextBox message;
    }
}