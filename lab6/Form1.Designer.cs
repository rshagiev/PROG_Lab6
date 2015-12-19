namespace lab6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.ExtractMax = new System.Windows.Forms.Button();
            this.myView1 = new lab6.MyView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxAdd
            // 
            this.textboxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxAdd.BackColor = System.Drawing.Color.DarkViolet;
            this.textboxAdd.ForeColor = System.Drawing.Color.White;
            this.textboxAdd.Location = new System.Drawing.Point(600, 40);
            this.textboxAdd.Name = "textboxAdd";
            this.textboxAdd.Size = new System.Drawing.Size(111, 20);
            this.textboxAdd.TabIndex = 0;
            this.textboxAdd.Text = "Enter element";
            this.textboxAdd.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(600, 81);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 68);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Element";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.BackColor = System.Drawing.Color.DarkViolet;
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(600, 165);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(111, 74);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ExtractMax
            // 
            this.ExtractMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtractMax.BackColor = System.Drawing.Color.DarkViolet;
            this.ExtractMax.ForeColor = System.Drawing.Color.White;
            this.ExtractMax.Location = new System.Drawing.Point(600, 257);
            this.ExtractMax.Name = "ExtractMax";
            this.ExtractMax.Size = new System.Drawing.Size(111, 65);
            this.ExtractMax.TabIndex = 5;
            this.ExtractMax.Text = "Extract Max";
            this.ExtractMax.UseVisualStyleBackColor = false;
            this.ExtractMax.Click += new System.EventHandler(this.RemoveMax_Click);
            // 
            // myView1
            // 
            this.myView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myView1.Location = new System.Drawing.Point(45, 40);
            this.myView1.Name = "myView1";
            this.myView1.Size = new System.Drawing.Size(535, 433);
            this.myView1.TabIndex = 4;
            this.myView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myView1_MouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(600, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "Extract Random";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DarkViolet;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(600, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(723, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExtractMax);
            this.Controls.Add(this.myView1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textboxAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button removeButton;
        private MyView myView1;
        private System.Windows.Forms.Button ExtractMax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

