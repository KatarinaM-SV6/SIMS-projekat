using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SIMS_project.NaplatneStanice
{
    internal class NaplatnaStanicaJSONReferenceConverter : JsonConverter
    {
        internal static NaplatnaStanicaRepository Repo { get; set; }

        public NaplatnaStanicaJSONReferenceConverter()
        {
            if (Repo == null) throw new Exception();
        }
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(NaplatnaStanica);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object value, JsonSerializer serializer)
        {
            var naplatnaStanicaId = serializer.Deserialize<int>(reader);
            return Repo.GetAll().First(e => e.Id == naplatnaStanicaId);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((NaplatnaStanica)value).Id);
        }
    }
}
