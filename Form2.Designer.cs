namespace QuizGame
{
    partial class Form2
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
            this.LevelOne = new System.Windows.Forms.Button();
            this.LevelTwo = new System.Windows.Forms.Button();
            this.LevelThree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LevelOne
            // 
            this.LevelOne.Location = new System.Drawing.Point(111, 191);
            this.LevelOne.Name = "LevelOne";
            this.LevelOne.Size = new System.Drawing.Size(75, 23);
            this.LevelOne.TabIndex = 0;
            this.LevelOne.Text = "LevelOne";
            this.LevelOne.UseVisualStyleBackColor = true;
            this.LevelOne.Click += new System.EventHandler(this.LevelOne_Click);
            // 
            // LevelTwo
            // 
            this.LevelTwo.Location = new System.Drawing.Point(350, 191);
            this.LevelTwo.Name = "LevelTwo";
            this.LevelTwo.Size = new System.Drawing.Size(75, 23);
            this.LevelTwo.TabIndex = 1;
            this.LevelTwo.Text = "LevelTwo";
            this.LevelTwo.UseVisualStyleBackColor = true;
            this.LevelTwo.Click += new System.EventHandler(this.LevelTwo_Click);
            // 
            // LevelThree
            // 
            this.LevelThree.Location = new System.Drawing.Point(588, 191);
            this.LevelThree.Name = "LevelThree";
            this.LevelThree.Size = new System.Drawing.Size(75, 23);
            this.LevelThree.TabIndex = 2;
            this.LevelThree.Text = "LevelThree";
            this.LevelThree.UseVisualStyleBackColor = true;
            this.LevelThree.Click += new System.EventHandler(this.LevelThree_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LevelThree);
            this.Controls.Add(this.LevelTwo);
            this.Controls.Add(this.LevelOne);
            this.Name = "Form2";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LevelOne;
        private System.Windows.Forms.Button LevelTwo;
        private System.Windows.Forms.Button LevelThree;
    }
}