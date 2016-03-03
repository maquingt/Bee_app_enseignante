using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee_application_enseignante
{
    public class PanelEtape : Panel
    {
        private Label leLabel;
        private PictureBox laPictureBox;
        private RichTextBox leRichTextBox;

        public PanelEtape() : base()
        {
            this.leLabel = new Label();
            this.laPictureBox = new PictureBox();
            this.leRichTextBox = new RichTextBox();

            this.leLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leLabel.Location = new System.Drawing.Point(0, 3);
            this.leLabel.Size = new System.Drawing.Size(326, 30);          
            this.leLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.laPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
           | System.Windows.Forms.AnchorStyles.Right)));
            this.laPictureBox.Image = global::Bee_application_enseignante.Properties.Resources.croix_fermeture_compte;
            this.laPictureBox.Location = new System.Drawing.Point(342, 3);
            this.laPictureBox.Size = new System.Drawing.Size(24, 27);
            this.laPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.leRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leRichTextBox.Location = new System.Drawing.Point(3, 36);
            this.leRichTextBox.Size = new System.Drawing.Size(363, 156);
            this.leRichTextBox.Text = "Entrez votre consigne ici...";

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.Size = new System.Drawing.Size(371, 195);

            this.Controls.Add(this.leLabel);
            this.Controls.Add(this.laPictureBox);
            this.Controls.Add(this.leRichTextBox);
        }
    }
}
