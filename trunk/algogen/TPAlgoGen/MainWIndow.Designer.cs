namespace TPAlgoGen
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextGen = new System.Windows.Forms.Button();
            this.numGen = new System.Windows.Forms.Label();
            this.lb_numGen = new System.Windows.Forms.Label();
            this.Play1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Note1 = new System.Windows.Forms.ComboBox();
            this.Play2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Play3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Play4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Note4 = new System.Windows.Forms.ComboBox();
            this.Note3 = new System.Windows.Forms.ComboBox();
            this.Note2 = new System.Windows.Forms.ComboBox();
            this.Note5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Play5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextGen
            // 
            this.nextGen.Location = new System.Drawing.Point(476, 342);
            this.nextGen.Name = "nextGen";
            this.nextGen.Size = new System.Drawing.Size(217, 58);
            this.nextGen.TabIndex = 0;
            this.nextGen.Text = "Génération Suivante";
            this.nextGen.UseVisualStyleBackColor = true;
            this.nextGen.Click += new System.EventHandler(this.nextGen_Click);
            // 
            // numGen
            // 
            this.numGen.AutoSize = true;
            this.numGen.Location = new System.Drawing.Point(29, 23);
            this.numGen.Name = "numGen";
            this.numGen.Size = new System.Drawing.Size(77, 13);
            this.numGen.TabIndex = 1;
            this.numGen.Text = "Génération N° ";
            // 
            // lb_numGen
            // 
            this.lb_numGen.AutoSize = true;
            this.lb_numGen.Location = new System.Drawing.Point(112, 23);
            this.lb_numGen.Name = "lb_numGen";
            this.lb_numGen.Size = new System.Drawing.Size(0, 13);
            this.lb_numGen.TabIndex = 2;
            // 
            // Play1
            // 
            this.Play1.Location = new System.Drawing.Point(68, 74);
            this.Play1.Name = "Play1";
            this.Play1.Size = new System.Drawing.Size(75, 23);
            this.Play1.TabIndex = 3;
            this.Play1.Tag = "1";
            this.Play1.Text = "Play";
            this.Play1.UseVisualStyleBackColor = true;
            this.Play1.Click += new System.EventHandler(this.Play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Son 1";
            // 
            // Note1
            // 
            this.Note1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Note1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Note1.Location = new System.Drawing.Point(179, 74);
            this.Note1.Name = "Note1";
            this.Note1.Size = new System.Drawing.Size(121, 21);
            this.Note1.TabIndex = 5;
            this.Note1.Tag = "1";
            // 
            // Play2
            // 
            this.Play2.Location = new System.Drawing.Point(68, 103);
            this.Play2.Name = "Play2";
            this.Play2.Size = new System.Drawing.Size(75, 23);
            this.Play2.TabIndex = 6;
            this.Play2.Tag = "2";
            this.Play2.Text = "Play";
            this.Play2.UseVisualStyleBackColor = true;
            this.Play2.Click += new System.EventHandler(this.Play_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Son 2";
            // 
            // Play3
            // 
            this.Play3.Location = new System.Drawing.Point(68, 132);
            this.Play3.Name = "Play3";
            this.Play3.Size = new System.Drawing.Size(75, 23);
            this.Play3.TabIndex = 8;
            this.Play3.Tag = "3";
            this.Play3.Text = "Play";
            this.Play3.UseVisualStyleBackColor = true;
            this.Play3.Click += new System.EventHandler(this.Play_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Son 3";
            // 
            // Play4
            // 
            this.Play4.Location = new System.Drawing.Point(68, 161);
            this.Play4.Name = "Play4";
            this.Play4.Size = new System.Drawing.Size(75, 23);
            this.Play4.TabIndex = 10;
            this.Play4.Tag = "4";
            this.Play4.Text = "Play";
            this.Play4.UseVisualStyleBackColor = true;
            this.Play4.Click += new System.EventHandler(this.Play_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Son 4";
            // 
            // Note4
            // 
            this.Note4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Note4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Note4.Location = new System.Drawing.Point(179, 161);
            this.Note4.Name = "Note4";
            this.Note4.Size = new System.Drawing.Size(121, 21);
            this.Note4.TabIndex = 12;
            this.Note4.Tag = "4";
            // 
            // Note3
            // 
            this.Note3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Note3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Note3.Location = new System.Drawing.Point(179, 134);
            this.Note3.Name = "Note3";
            this.Note3.Size = new System.Drawing.Size(121, 21);
            this.Note3.TabIndex = 13;
            this.Note3.Tag = "3";
            // 
            // Note2
            // 
            this.Note2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Note2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Note2.Location = new System.Drawing.Point(179, 105);
            this.Note2.Name = "Note2";
            this.Note2.Size = new System.Drawing.Size(121, 21);
            this.Note2.TabIndex = 14;
            this.Note2.Tag = "2";
            // 
            // Note5
            // 
            this.Note5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Note5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Note5.Location = new System.Drawing.Point(179, 188);
            this.Note5.Name = "Note5";
            this.Note5.Size = new System.Drawing.Size(121, 21);
            this.Note5.TabIndex = 17;
            this.Note5.Tag = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Son 5";
            // 
            // Play5
            // 
            this.Play5.Location = new System.Drawing.Point(68, 188);
            this.Play5.Name = "Play5";
            this.Play5.Size = new System.Drawing.Size(75, 23);
            this.Play5.TabIndex = 15;
            this.Play5.Tag = "5";
            this.Play5.Text = "Play";
            this.Play5.UseVisualStyleBackColor = true;
            this.Play5.Click += new System.EventHandler(this.Play_Click);

            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 426);
            this.Controls.Add(this.Note5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Play5);
            this.Controls.Add(this.Note2);
            this.Controls.Add(this.Note3);
            this.Controls.Add(this.Note4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Play4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Play3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Play2);
            this.Controls.Add(this.Note1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Play1);
            this.Controls.Add(this.lb_numGen);
            this.Controls.Add(this.numGen);
            this.Controls.Add(this.nextGen);
            this.Name = "MainWindow";
            this.Text = "Algo Gen";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextGen;
        private System.Windows.Forms.Label numGen;
        private System.Windows.Forms.Label lb_numGen;
        private System.Windows.Forms.Button Play1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Note1;
        private System.Windows.Forms.Button Play2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Play3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Play4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Note4;
        private System.Windows.Forms.ComboBox Note3;
        private System.Windows.Forms.ComboBox Note2;
        private System.Windows.Forms.ComboBox Note5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Play5;
    }
}

