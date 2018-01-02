using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviControl
{
    public static class Variables
    {
        public static string BeamerIP { get; set; }
        public static string PhoneIP { get; set; }
        public static Boolean BeamerActive { get; set; }

        public static string[] Route1Items = new string[] { "start","a_l_4", "a_l_2", "a_l_0", "a_r_4", "a_r_0", "a_r_4", "a_r_0", "dreieck", "a_l_4", "a_l_0", "a_l_4", "a_l_3", "a_l_1", "a_l_0", "a_hl_4", "a_hl_2", "a_hl_0", "a_l_4", "kreis", "a_l_3", "a_l_2", "a_l_1", "a_l_0", "a_4", "quadrat", "a_3", "a_2", "a_1", "goal", "quadrat", "kreis", "dreieck", "goal" };
        public static string[] Route1Descriptions = new string[] { "Zum Starten drücken", "Wenn es losgeht", "Bei Treppen von links", "Kurz vor Einmuendung", "Auf Kreuzung", "Nach abbiegen", "Wenn Teilnehmer abbiegt", "Kurz vor den Treppen", "Am Anfang der Treppen", "Nach Dreieck", "Am Ende der Treppen", "Wenn Teilnehmer auf Strasse", "Bei Einmuendung von links","Bei Weg von links", "An Kreuzung", "Nach dem Abbiegen", "ca 10m nach Beginn der Halle", "Wenn Strasse einen Knick macht", "Nach dem Knick", "Bei kleinem Weg von links", "Anschliessend", "Bei Strasse von rechts", "Bei Gebaeudeeinfahrt rechts", "Bei Weg nach links", "Wenn Teilnehmer abbiegt", "Auf Treppen", "Anschliessend", "Bei Knick", "Bei Weg von rechts", "Vor Gebaeudeeingang", "Wenn Teilnehmer vor Ort", "Wenn Teilnehmer vor Ort", "Wenn Teilnehmer vor Ort", "Bitte ins Hauptmenü zurück"};

        public static string[] Route2Items = new string[] { "start", "a_l_4", "a_l_2", "a_l_0", "a_r_4", "kreis", "a_r_3", "a_r_2", "a_r_1", "a_r_0", "a_r_4", "a_r_3", "a_r_2", "a_r_1", "a_r_0", "a_l_4", "a_l_3", "a_l_2", "dreieck", "a_l_1","a_l_0", "a_r_4", "a_r_3", "a_r_1", "a_r_0", "a_l_4", "a_l_3", "a_l_2", "quadrat", "a_l_2", "a_l_1", "a_l_0", "a_r_4", "a_r_0", "a_l_4", "a_l_2", "a_l_0", "a_4", "a_2", "goal", "quadrat", "dreieck", "kreis", "goal"};
        public static string[] Route2Descriptions = new string[] { "Zum Starten drücken", "Wenn es losgeht", "Querab von blauen Containern", "Bei Kreuzung", "Nach dem Abbiegen", "Auf Höhe Balkon", "anschliessend", "Hallenende rechts", "Ende Kühlanlage rechts", "Nach Rohrbrücke", "Nach dem Abbiegen", "Bei Weg von rechts", "Bei Stützpfeiler Rohrbrücke", "Bei Baum zum Ausweichen", "Bei großem Baum", "Nach Abbiegen", "Strassenlaternen rechts", "Blauer Container rechts", "Ende Gebäude", "Anschliessend", "Bei Kreuzung", "Nach dem Abbiegen", "VOR Parkplatzeinfahrt links", "Zwischen den Einfahrten", "Bei Wegkreuzung", "Nach dem Abbiegen",  "Bei Bäumen l+r","Gebäudeanfang rechts", "Bei Gebäudeeinang", "Anschliessend", "Gebäudeende", "Bei Kreuzung", "Oben an den Treppen", "Unten an den Treppen", "Nach dem Abbiegen", "Bei Gebäudeeinfahrt links", "Bei Einmündung", "Nach Abbiegen", "Nach Gebäudeanfang", "etwa Gebäudemitte", "Wenn Teilnehmer vor Ort", "Wenn Teilnehmer vor Ort", "wenn Teilnehmer vor Ort", "Bitte ins Hauptmenü zurück" };
    }
}
