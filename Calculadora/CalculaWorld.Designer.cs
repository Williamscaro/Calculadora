namespace Calculadora
{
    partial class CalculaWorld
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculaWorld));
            this.Screen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TopForm = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CloseForm = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.PictureBox();
            this.minus = new System.Windows.Forms.PictureBox();
            this.multiply = new System.Windows.Forms.PictureBox();
            this.divide = new System.Windows.Forms.PictureBox();
            this.C = new System.Windows.Forms.PictureBox();
            this.CE = new System.Windows.Forms.Panel();
            this.btnCE1 = new System.Windows.Forms.PictureBox();
            this.btnCE = new System.Windows.Forms.PictureBox();
            this.moverForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.equals = new Bunifu.Framework.UI.BunifuImageButton();
            this.dot = new System.Windows.Forms.Button();
            this.TopForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C)).BeginInit();
            this.CE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equals)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.Screen.Location = new System.Drawing.Point(12, 59);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Screen.Size = new System.Drawing.Size(328, 54);
            this.Screen.TabIndex = 0;
            this.Screen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(100, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TopForm
            // 
            this.TopForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopForm.BackgroundImage")));
            this.TopForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopForm.Controls.Add(this.txtTitle);
            this.TopForm.Controls.Add(this.CloseForm);
            this.TopForm.Controls.Add(this.logo);
            this.TopForm.Controls.Add(this.Screen);
            this.TopForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopForm.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.TopForm.GradientBottomRight = System.Drawing.Color.White;
            this.TopForm.GradientTopLeft = System.Drawing.Color.White;
            this.TopForm.GradientTopRight = System.Drawing.Color.White;
            this.TopForm.Location = new System.Drawing.Point(0, 0);
            this.TopForm.Name = "TopForm";
            this.TopForm.Quality = 10;
            this.TopForm.Size = new System.Drawing.Size(352, 125);
            this.TopForm.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTitle.Font = new System.Drawing.Font("Agency FB", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(80, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(113, 35);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Text = "Calculator!";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseForm
            // 
            this.CloseForm.Image = ((System.Drawing.Image)(resources.GetObject("CloseForm.Image")));
            this.CloseForm.Location = new System.Drawing.Point(303, 0);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(50, 50);
            this.CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseForm.TabIndex = 2;
            this.CloseForm.TabStop = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(24, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(50, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(183, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(12, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 54);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(100, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 54);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(183, 226);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 54);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button7.Location = new System.Drawing.Point(12, 297);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 54);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button8.Location = new System.Drawing.Point(100, 297);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 54);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button9.Location = new System.Drawing.Point(183, 297);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 54);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button0.Location = new System.Drawing.Point(101, 357);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 54);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // plus
            // 
            this.plus.Image = ((System.Drawing.Image)(resources.GetObject("plus.Image")));
            this.plus.Location = new System.Drawing.Point(274, 158);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 60);
            this.plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plus.TabIndex = 3;
            this.plus.TabStop = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Image = ((System.Drawing.Image)(resources.GetObject("minus.Image")));
            this.minus.Location = new System.Drawing.Point(274, 223);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 60);
            this.minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minus.TabIndex = 14;
            this.minus.TabStop = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Image = ((System.Drawing.Image)(resources.GetObject("multiply.Image")));
            this.multiply.Location = new System.Drawing.Point(274, 289);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 60);
            this.multiply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.multiply.TabIndex = 15;
            this.multiply.TabStop = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Image = ((System.Drawing.Image)(resources.GetObject("divide.Image")));
            this.divide.Location = new System.Drawing.Point(275, 354);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 60);
            this.divide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.divide.TabIndex = 16;
            this.divide.TabStop = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // C
            // 
            this.C.Image = ((System.Drawing.Image)(resources.GetObject("C.Image")));
            this.C.Location = new System.Drawing.Point(4, 421);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(52, 52);
            this.C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C.TabIndex = 17;
            this.C.TabStop = false;
            this.C.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // CE
            // 
            this.CE.Controls.Add(this.btnCE1);
            this.CE.Controls.Add(this.btnCE);
            this.CE.Location = new System.Drawing.Point(183, 357);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(75, 62);
            this.CE.TabIndex = 18;
            this.CE.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCE1
            // 
            this.btnCE1.Image = ((System.Drawing.Image)(resources.GetObject("btnCE1.Image")));
            this.btnCE1.Location = new System.Drawing.Point(41, 13);
            this.btnCE1.Name = "btnCE1";
            this.btnCE1.Size = new System.Drawing.Size(36, 36);
            this.btnCE1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCE1.TabIndex = 20;
            this.btnCE1.TabStop = false;
            this.btnCE1.Click += new System.EventHandler(this.btnCE1_Click);
            // 
            // btnCE
            // 
            this.btnCE.Image = ((System.Drawing.Image)(resources.GetObject("btnCE.Image")));
            this.btnCE.Location = new System.Drawing.Point(3, 13);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(40, 36);
            this.btnCE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCE.TabIndex = 19;
            this.btnCE.TabStop = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // moverForm
            // 
            this.moverForm.Fixed = true;
            this.moverForm.Horizontal = true;
            this.moverForm.TargetControl = this.TopForm;
            this.moverForm.Vertical = true;
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.equals.Image = ((System.Drawing.Image)(resources.GetObject("equals.Image")));
            this.equals.ImageActive = null;
            this.equals.Location = new System.Drawing.Point(62, 425);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(272, 49);
            this.equals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.equals.TabIndex = 4;
            this.equals.TabStop = false;
            this.equals.Zoom = 10;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // dot
            // 
            this.dot.Image = ((System.Drawing.Image)(resources.GetObject("dot.Image")));
            this.dot.Location = new System.Drawing.Point(13, 357);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 54);
            this.dot.TabIndex = 19;
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // CalculaWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 487);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.C);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TopForm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculaWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculaWorld";
            this.TopForm.ResumeLayout(false);
            this.TopForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C)).EndInit();
            this.CE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuGradientPanel TopForm;
        private System.Windows.Forms.PictureBox CloseForm;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.PictureBox plus;
        private System.Windows.Forms.PictureBox minus;
        private System.Windows.Forms.PictureBox multiply;
        private System.Windows.Forms.PictureBox divide;
        private System.Windows.Forms.PictureBox C;
        private System.Windows.Forms.Panel CE;
        private System.Windows.Forms.PictureBox btnCE1;
        private System.Windows.Forms.PictureBox btnCE;
        private Bunifu.Framework.UI.BunifuDragControl moverForm;
        private Bunifu.Framework.UI.BunifuCustomLabel txtTitle;
        private Bunifu.Framework.UI.BunifuImageButton equals;
        private System.Windows.Forms.Button dot;
    }
}

