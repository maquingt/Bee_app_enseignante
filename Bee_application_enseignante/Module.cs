using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee_application_enseignante
{
    public class Module
    {
        public enum nomsModule {MODULE_LED, MODULE_AFFICHEUR, MODULE_CARREFOUR };
        public enum fonctionnalitesModule
        {
            ALLUMER_UNE_LED,
            ALLUMER_PLUSIEURS_LED,
            ALLUMER_UN_SEGMENT,
            ALLUMER_PLUSIEURS_SEGMENTS,
            ENVOYER_UNE_LISTE_DE_VALEURS,
            ALGORITHME,
        };

        public string nomModule { get; set; }

        public string fonctionnaliteModule { get; set; }
    }
}
