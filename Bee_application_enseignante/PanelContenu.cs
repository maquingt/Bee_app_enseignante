using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee_application_enseignante
{
    public class PanelContenu : Panel 
    {
        private List<PanelEtape> laListe;

        public PanelContenu() : base()
        {
            this.laListe = new List<PanelEtape>();
            this.AutoScroll = true;
        }

        public void ajouteEtape(PanelEtape lePanelEtapeAAjouter)
        {
            this.laListe.Add(lePanelEtapeAAjouter);
            this.actualiseAffichage();
        }

        public void actualiseAffichage()
        {
            this.Controls.Clear();


            int y = 10;
            foreach(PanelEtape p in this.laListe)
            {
                p.Location = new Point(10, y);
                y += p.Height + 10;

                this.Controls.Add(p);
            }
        }
    }
}
