namespace FinalExam321
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
            this.CreatedShapesListBox = new System.Windows.Forms.ListBox();
            this.FilteredLettersListBox = new System.Windows.Forms.ListBox();
            this.CompletedLettersListBox = new System.Windows.Forms.ListBox();
            this.SelectShapeListBox = new System.Windows.Forms.ListBox();
            this.SelectColorListBox = new System.Windows.Forms.ListBox();
            this.SelectTextureListBox = new System.Windows.Forms.ListBox();
            this.CreateShapeBtn = new System.Windows.Forms.Button();
            this.EditShapeBtn = new System.Windows.Forms.Button();
            this.DeleteShapeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedLetterListBox = new System.Windows.Forms.ListBox();
            this.CreateLetterBtn = new System.Windows.Forms.Button();
            this.DeleteLetterBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectNumberListBox = new System.Windows.Forms.ListBox();
            this.SelectFilterColorListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterColorBtn = new System.Windows.Forms.Button();
            this.FilterSizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatedShapesListBox
            // 
            this.CreatedShapesListBox.FormattingEnabled = true;
            this.CreatedShapesListBox.ItemHeight = 20;
            this.CreatedShapesListBox.Location = new System.Drawing.Point(490, 45);
            this.CreatedShapesListBox.Name = "CreatedShapesListBox";
            this.CreatedShapesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.CreatedShapesListBox.Size = new System.Drawing.Size(676, 224);
            this.CreatedShapesListBox.TabIndex = 0;
            // 
            // FilteredLettersListBox
            // 
            this.FilteredLettersListBox.FormattingEnabled = true;
            this.FilteredLettersListBox.ItemHeight = 20;
            this.FilteredLettersListBox.Location = new System.Drawing.Point(25, 528);
            this.FilteredLettersListBox.Name = "FilteredLettersListBox";
            this.FilteredLettersListBox.Size = new System.Drawing.Size(1151, 64);
            this.FilteredLettersListBox.TabIndex = 1;
            // 
            // CompletedLettersListBox
            // 
            this.CompletedLettersListBox.FormattingEnabled = true;
            this.CompletedLettersListBox.ItemHeight = 20;
            this.CompletedLettersListBox.Location = new System.Drawing.Point(25, 318);
            this.CompletedLettersListBox.Name = "CompletedLettersListBox";
            this.CompletedLettersListBox.Size = new System.Drawing.Size(1151, 64);
            this.CompletedLettersListBox.TabIndex = 2;
            // 
            // SelectShapeListBox
            // 
            this.SelectShapeListBox.FormattingEnabled = true;
            this.SelectShapeListBox.ItemHeight = 20;
            this.SelectShapeListBox.Location = new System.Drawing.Point(12, 12);
            this.SelectShapeListBox.Name = "SelectShapeListBox";
            this.SelectShapeListBox.Size = new System.Drawing.Size(120, 84);
            this.SelectShapeListBox.TabIndex = 3;
            // 
            // SelectColorListBox
            // 
            this.SelectColorListBox.FormattingEnabled = true;
            this.SelectColorListBox.ItemHeight = 20;
            this.SelectColorListBox.Location = new System.Drawing.Point(12, 111);
            this.SelectColorListBox.Name = "SelectColorListBox";
            this.SelectColorListBox.Size = new System.Drawing.Size(120, 64);
            this.SelectColorListBox.TabIndex = 4;
            // 
            // SelectTextureListBox
            // 
            this.SelectTextureListBox.FormattingEnabled = true;
            this.SelectTextureListBox.ItemHeight = 20;
            this.SelectTextureListBox.Location = new System.Drawing.Point(12, 191);
            this.SelectTextureListBox.Name = "SelectTextureListBox";
            this.SelectTextureListBox.Size = new System.Drawing.Size(120, 64);
            this.SelectTextureListBox.TabIndex = 5;
            // 
            // CreateShapeBtn
            // 
            this.CreateShapeBtn.Location = new System.Drawing.Point(151, 12);
            this.CreateShapeBtn.Name = "CreateShapeBtn";
            this.CreateShapeBtn.Size = new System.Drawing.Size(130, 41);
            this.CreateShapeBtn.TabIndex = 6;
            this.CreateShapeBtn.Text = "Create Shape";
            this.CreateShapeBtn.UseVisualStyleBackColor = true;
            this.CreateShapeBtn.Click += new System.EventHandler(this.CreateShapeBtn_Click);
            // 
            // EditShapeBtn
            // 
            this.EditShapeBtn.Location = new System.Drawing.Point(151, 85);
            this.EditShapeBtn.Name = "EditShapeBtn";
            this.EditShapeBtn.Size = new System.Drawing.Size(130, 41);
            this.EditShapeBtn.TabIndex = 7;
            this.EditShapeBtn.Text = "Edit Shape";
            this.EditShapeBtn.UseVisualStyleBackColor = true;
            this.EditShapeBtn.Click += new System.EventHandler(this.EditShapeBtn_Click);
            // 
            // DeleteShapeBtn
            // 
            this.DeleteShapeBtn.Location = new System.Drawing.Point(151, 154);
            this.DeleteShapeBtn.Name = "DeleteShapeBtn";
            this.DeleteShapeBtn.Size = new System.Drawing.Size(130, 41);
            this.DeleteShapeBtn.TabIndex = 8;
            this.DeleteShapeBtn.Text = "Delete Shape";
            this.DeleteShapeBtn.UseVisualStyleBackColor = true;
            this.DeleteShapeBtn.Click += new System.EventHandler(this.DeleteShapeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select a letter to form!";
            // 
            // SelectedLetterListBox
            // 
            this.SelectedLetterListBox.FormattingEnabled = true;
            this.SelectedLetterListBox.ItemHeight = 20;
            this.SelectedLetterListBox.Location = new System.Drawing.Point(337, 45);
            this.SelectedLetterListBox.Name = "SelectedLetterListBox";
            this.SelectedLetterListBox.Size = new System.Drawing.Size(61, 224);
            this.SelectedLetterListBox.TabIndex = 10;
            // 
            // CreateLetterBtn
            // 
            this.CreateLetterBtn.Location = new System.Drawing.Point(404, 55);
            this.CreateLetterBtn.Name = "CreateLetterBtn";
            this.CreateLetterBtn.Size = new System.Drawing.Size(80, 71);
            this.CreateLetterBtn.TabIndex = 11;
            this.CreateLetterBtn.Text = "Create Letter";
            this.CreateLetterBtn.UseVisualStyleBackColor = true;
            this.CreateLetterBtn.Click += new System.EventHandler(this.CreateLetterBtn_Click);
            // 
            // DeleteLetterBtn
            // 
            this.DeleteLetterBtn.Location = new System.Drawing.Point(409, 132);
            this.DeleteLetterBtn.Name = "DeleteLetterBtn";
            this.DeleteLetterBtn.Size = new System.Drawing.Size(75, 63);
            this.DeleteLetterBtn.TabIndex = 12;
            this.DeleteLetterBtn.Text = "Delete Letter";
            this.DeleteLetterBtn.UseVisualStyleBackColor = true;
            this.DeleteLetterBtn.Click += new System.EventHandler(this.DeleteLetterBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filter by color of shape within letters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Filter by number of shapes within letter";
            // 
            // SelectNumberListBox
            // 
            this.SelectNumberListBox.FormattingEnabled = true;
            this.SelectNumberListBox.ItemHeight = 20;
            this.SelectNumberListBox.Location = new System.Drawing.Point(844, 420);
            this.SelectNumberListBox.Name = "SelectNumberListBox";
            this.SelectNumberListBox.Size = new System.Drawing.Size(120, 84);
            this.SelectNumberListBox.TabIndex = 16;
            // 
            // SelectFilterColorListBox
            // 
            this.SelectFilterColorListBox.FormattingEnabled = true;
            this.SelectFilterColorListBox.ItemHeight = 20;
            this.SelectFilterColorListBox.Location = new System.Drawing.Point(104, 420);
            this.SelectFilterColorListBox.Name = "SelectFilterColorListBox";
            this.SelectFilterColorListBox.Size = new System.Drawing.Size(120, 84);
            this.SelectFilterColorListBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Completed Letters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Completed Shapes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Filtered Letters";
            // 
            // FilterColorBtn
            // 
            this.FilterColorBtn.Location = new System.Drawing.Point(230, 420);
            this.FilterColorBtn.Name = "FilterColorBtn";
            this.FilterColorBtn.Size = new System.Drawing.Size(75, 84);
            this.FilterColorBtn.TabIndex = 21;
            this.FilterColorBtn.Text = "Filter Color";
            this.FilterColorBtn.UseVisualStyleBackColor = true;
            this.FilterColorBtn.Click += new System.EventHandler(this.FilterColorBtn_Click);
            // 
            // FilterSizeBtn
            // 
            this.FilterSizeBtn.Location = new System.Drawing.Point(982, 420);
            this.FilterSizeBtn.Name = "FilterSizeBtn";
            this.FilterSizeBtn.Size = new System.Drawing.Size(82, 84);
            this.FilterSizeBtn.TabIndex = 22;
            this.FilterSizeBtn.Text = "Filter Size";
            this.FilterSizeBtn.UseVisualStyleBackColor = true;
            this.FilterSizeBtn.Click += new System.EventHandler(this.FilterSizeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 615);
            this.Controls.Add(this.FilterSizeBtn);
            this.Controls.Add(this.FilterColorBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectFilterColorListBox);
            this.Controls.Add(this.SelectNumberListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteLetterBtn);
            this.Controls.Add(this.CreateLetterBtn);
            this.Controls.Add(this.SelectedLetterListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteShapeBtn);
            this.Controls.Add(this.EditShapeBtn);
            this.Controls.Add(this.CreateShapeBtn);
            this.Controls.Add(this.SelectTextureListBox);
            this.Controls.Add(this.SelectColorListBox);
            this.Controls.Add(this.SelectShapeListBox);
            this.Controls.Add(this.CompletedLettersListBox);
            this.Controls.Add(this.FilteredLettersListBox);
            this.Controls.Add(this.CreatedShapesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CreatedShapesListBox;
        private System.Windows.Forms.ListBox FilteredLettersListBox;
        private System.Windows.Forms.ListBox CompletedLettersListBox;
        protected System.Windows.Forms.ListBox SelectShapeListBox;
        protected System.Windows.Forms.ListBox SelectColorListBox;
        protected System.Windows.Forms.ListBox SelectTextureListBox;
        private System.Windows.Forms.Button CreateShapeBtn;
        private System.Windows.Forms.Button EditShapeBtn;
        private System.Windows.Forms.Button DeleteShapeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SelectedLetterListBox;
        private System.Windows.Forms.Button CreateLetterBtn;
        private System.Windows.Forms.Button DeleteLetterBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox SelectNumberListBox;
        private System.Windows.Forms.ListBox SelectFilterColorListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FilterColorBtn;
        private System.Windows.Forms.Button FilterSizeBtn;
    }
}

