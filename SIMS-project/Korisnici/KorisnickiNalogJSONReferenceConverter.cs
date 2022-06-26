using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Korisnici
{
    internal class KorisnickiNalogJSONReferenceConverter : JsonConverter
    {
        internal static KorisnickiNalogRepository Repo { get; set; }

        public KorisnickiNalogJSONReferenceConverter()
        {
            if (Repo == null) throw new Exception();
        }
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(KorisnickiNalog);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object value, JsonSerializer serializer)
        {
            var korisnickiNalogId = serializer.Deserialize<int>(reader);
            return Repo.GetAll().First(e => e.Id == korisnickiNalogId);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((KorisnickiNalog)value).Id);
        }
    }
}
