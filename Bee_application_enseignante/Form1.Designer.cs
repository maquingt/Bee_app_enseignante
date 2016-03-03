namespace Bee_application_enseignante
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
            this.titre_textBox = new System.Windows.Forms.TextBox();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.label_ModuleLED = new System.Windows.Forms.Label();
            this.label_Allumer1LED = new System.Windows.Forms.Label();
            this.label_AllumerPlusieursLED = new System.Windows.Forms.Label();
            this.label_Algo = new System.Windows.Forms.Label();
            this.label_ModuleAfficheur7Segments = new System.Windows.Forms.Label();
            this.label_allumer_1_chiffre = new System.Windows.Forms.Label();
            this.panelContenu1 = new Bee_application_enseignante.PanelContenu();
            this.SuspendLayout();
            // 
            // titre_textBox
            // 
            this.titre_textBox.Location = new System.Drawing.Point(367, 91);
            this.titre_textBox.Name = "titre_textBox";
            this.titre_textBox.Size = new System.Drawing.Size(517, 20);
            this.titre_textBox.TabIndex = 0;
            this.titre_textBox.Text = "Le bon TP";
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Location = new System.Drawing.Point(809, 501);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.button_enregistrer.TabIndex = 2;
            this.button_enregistrer.Tag = "";
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregisrer_Click);
            // 
            // label_ModuleLED
            // 
            this.label_ModuleLED.AutoSize = true;
            this.label_ModuleLED.Location = new System.Drawing.Point(33, 157);
            this.label_ModuleLED.Name = "label_ModuleLED";
            this.label_ModuleLED.Size = new System.Drawing.Size(66, 13);
            this.label_ModuleLED.TabIndex = 4;
            this.label_ModuleLED.Text = "Module LED";
            // 
            // label_Allumer1LED
            // 
            this.label_Allumer1LED.AutoSize = true;
            this.label_Allumer1LED.Location = new System.Drawing.Point(48, 170);
            this.label_Allumer1LED.Name = "label_Allumer1LED";
            this.label_Allumer1LED.Size = new System.Drawing.Size(77, 13);
            this.label_Allumer1LED.TabIndex = 5;
            this.label_Allumer1LED.Text = "Allumer 1 LED ";
            // 
            // label_AllumerPlusieursLED
            // 
            this.label_AllumerPlusieursLED.AutoSize = true;
            this.label_AllumerPlusieursLED.Location = new System.Drawing.Point(48, 183);
            this.label_AllumerPlusieursLED.Name = "label_AllumerPlusieursLED";
            this.label_AllumerPlusieursLED.Size = new System.Drawing.Size(109, 13);
            this.label_AllumerPlusieursLED.TabIndex = 6;
            this.label_AllumerPlusieursLED.Text = "Allumer plusieurs LED";
            // 
            // label_Algo
            // 
            this.label_Algo.AutoSize = true;
            this.label_Algo.Location = new System.Drawing.Point(48, 196);
            this.label_Algo.Name = "label_Algo";
            this.label_Algo.Size = new System.Drawing.Size(56, 13);
            this.label_Algo.TabIndex = 8;
            this.label_Algo.Text = "Algorithme";
            // 
            // label_ModuleAfficheur7Segments
            // 
            this.label_ModuleAfficheur7Segments.AutoSize = true;
            this.label_ModuleAfficheur7Segments.Location = new System.Drawing.Point(36, 213);
            this.label_ModuleAfficheur7Segments.Name = "label_ModuleAfficheur7Segments";
            this.label_ModuleAfficheur7Segments.Size = new System.Drawing.Size(150, 13);
            this.label_ModuleAfficheur7Segments.TabIndex = 9;
            this.label_ModuleAfficheur7Segments.Text = "Module Afficheur 7 segements";
            // 
            // label_allumer_1_chiffre
            // 
            this.label_allumer_1_chiffre.AutoSize = true;
            this.label_allumer_1_chiffre.Location = new System.Drawing.Point(48, 226);
            this.label_allumer_1_chiffre.Name = "label_allumer_1_chiffre";
            this.label_allumer_1_chiffre.Size = new System.Drawing.Size(82, 13);
            this.label_allumer_1_chiffre.TabIndex = 10;
            this.label_allumer_1_chiffre.Text = "Allumer 1 chiffre";
            // 
            // panelContenu1
            // 
            this.panelContenu1.AllowDrop = true;
            this.panelContenu1.AutoScroll = true;
            this.panelContenu1.Location = new System.Drawing.Point(367, 157);
            this.panelContenu1.Name = "panelContenu1";
            this.panelContenu1.Size = new System.Drawing.Size(503, 292);
            this.panelContenu1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 574);
            this.Controls.Add(this.label_allumer_1_chiffre);
            this.Controls.Add(this.label_ModuleAfficheur7Segments);
            this.Controls.Add(this.label_Algo);
            this.Controls.Add(this.label_AllumerPlusieursLED);
            this.Controls.Add(this.label_Allumer1LED);
            this.Controls.Add(this.label_ModuleLED);
            this.Controls.Add(this.panelContenu1);
            this.Controls.Add(this.button_enregistrer);
            this.Controls.Add(this.titre_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titre_textBox;
        private System.Windows.Forms.Button button_enregistrer;
        private PanelContenu panelContenu1;
        private System.Windows.Forms.Label label_ModuleLED;
        private System.Windows.Forms.Label label_Allumer1LED;
        private System.Windows.Forms.Label label_AllumerPlusieursLED;
        private System.Windows.Forms.Label label_Algo;
        private System.Windows.Forms.Label label_ModuleAfficheur7Segments;
        private System.Windows.Forms.Label label_allumer_1_chiffre;
    }
}

