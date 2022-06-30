using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Deonice.Cenovnik
{
    class CenovnikJSONReferenceConverter : JsonConverter
    {
        public static CenovnikRepository Repo { get; set; }

        public CenovnikJSONReferenceConverter()
        {
            if (Repo == null) throw new Exception();
        }
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Cenovnik);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object value, JsonSerializer serializer)
        {
            var cenovnikId = serializer.Deserialize<int>(reader);
            return Repo.GetAll().First(e => e.Id == cenovnikId);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((Cenovnik)value).Id);
        }
    }
}
