using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Deonice
{
    class DeonicaJSONReferenceConverter : JsonConverter
    {
        public static DeonicaRepository Repo { get; set; }

        public DeonicaJSONReferenceConverter()
        {
            if (Repo == null) throw new Exception();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Deonica);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            int deonicaId = serializer.Deserialize<int>(reader);
            return Repo.GetAll().First(e => e.Id == deonicaId);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((Deonica)value).Id);
        }
    }
}
