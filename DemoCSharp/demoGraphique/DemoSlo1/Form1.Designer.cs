
namespace DemoSlo1
{
    partial class Form1
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
            this.BOUTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BOUTON
            // 
            this.BOUTON.BackColor = System.Drawing.Color.Lime;
            this.BOUTON.Location = new System.Drawing.Point(341, 112);
            this.BOUTON.Name = "BOUTON";
            this.BOUTON.Size = new System.Drawing.Size(75, 23);
            this.BOUTON.TabIndex = 0;
            this.BOUTON.Text = "Appui";
            this.BOUTON.UseVisualStyleBackColor = false;
            this.BOUTON.Click += new System.EventHandler(this.BOUTON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BOUTON);
            this.Name = "Form1";
            this.Text = "DEMO_SLO2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BOUTON;
    }
}

