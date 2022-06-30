using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Uredjaji.DojaveOKvaru
{
    class DojavaOKvaruJSONReferenceConverter : JsonConverter
    {
        public static DojavaOKvaruRepository Repo { get; set; }

        public DojavaOKvaruJSONReferenceConverter()
        {
            if (Repo == null) throw new Exception();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DojavaOKvaru);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            int dojavaId = serializer.Deserialize<int>(reader);
            return Repo.GetAll().First(e => e.Id == dojavaId);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((DojavaOKvaru)value).Id);
        }
    }
}
