using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3
{
    /**/
    public static class Stockage
    {
        private static readonly JsonSerializerOptions Options =
            new(JsonSerializerDefaults.Web) { WriteIndented = true };

        public static void Sauver(string chemin, List<Note> notes)
        {
            string json = JsonSerializer.Serialize(notes, Options);
            File.WriteAllText(chemin, json);

        }
        public static List<Note> Charger(string chemin)
        {
            var json = File.ReadAllText(chemin);
            return JsonSerializer.Deserialize<List<Note>>(json, Options) ?? new List<Note>();
        }
    }
}
