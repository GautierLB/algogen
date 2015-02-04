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
            this.Play1.Text = "Play";
            this.Play1.UseVisualStyleBackColor = true;
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
            this.Note1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 426);
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
    }
}

