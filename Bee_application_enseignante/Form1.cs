using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;



namespace Bee_application_enseignante
{
    public partial class Form1 : Form
    {
        private const char ParseurText = '§';
        private const char ParseurModule = ',';

        private List<Label> laListeDeLabel;
    
        public Form1()
        {
            InitializeComponent();
            laListeDeLabel = new List<Label>();

        }

        public Sujet parseTp(String tpADecouper)
        {
            if (tpADecouper == "")
                return null;
            String[] contenuTp =  tpADecouper.Split(ParseurText);



            Sujet nouveauSujet = new Sujet();
            nouveauSujet.titre = this.titre_textBox.Text;
            nouveauSujet.listeDEtapes = new List<Etape>();            

            for(int i = 0; i < contenuTp.Length-1; i+=2 )
            {
                Etape nouvelleEtape = new Etape();

                nouvelleEtape.consigne = contenuTp[i];

                Module nouveauModule = new Module();
                String[] contenuModule =  contenuTp[i+1].Split(ParseurModule);
                nouveauModule.nomModule = contenuModule[0];
                nouveauModule.fonctionnaliteModule = contenuModule[1];
                nouvelleEtape.module = nouveauModule;  

                nouveauSujet.listeDEtapes.Add(nouvelleEtape);
            }
            return nouveauSujet;
        }



        private void button_enregisrer_Click(object sender, EventArgs e)
        {
           Sujet leSujet =  this.parseTp("");

            if (leSujet == null)
                return;

            SaveFileDialog leBonEndroit = new SaveFileDialog();
            leBonEndroit.Filter = ".BEE | .bee";

            if(leBonEndroit.ShowDialog() == DialogResult.OK )
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Sujet));
                StreamWriter writer = new StreamWriter(leBonEndroit.FileName, false);

                serializer.Serialize(writer, leSujet);
                writer.Close();
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.DoDragDrop("a", DragDropEffects.Move);
        }



        private void dragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void  dragDrop(object sender, DragEventArgs e)
        {
           MessageBox.Show(e.Data.GetData(DataFormats.Text).ToString());
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.laListeDeLabel.Add(label_Allumer1LED);
            this.laListeDeLabel.Add(label_AllumerPlusieursLED);
            this.laListeDeLabel.Add(label_allumer_1_chiffre);
            this.laListeDeLabel.Add(label_Algo);

            foreach (Label l in this.laListeDeLabel)
            {
                l.MouseDown += new MouseEventHandler(label1_MouseDown);
            }
            
            this.panelContenu1.DragEnter += new DragEventHandler(dragEnter);
            this.panelContenu1.DragDrop += new DragEventHandler(dragDrop);
        }
    }
}
