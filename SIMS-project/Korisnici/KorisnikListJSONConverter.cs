using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIMS_project.Korisnici
{
    internal class KorisnikListJSONConverter : JsonConverter
	{
		internal static KorisnikRepository Repo { get; set; }

		public KorisnikListJSONConverter()
		{
		}

		public override bool CanConvert(Type objectType)
		{
			return (objectType == typeof(List<Korisnik>));
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JToken token = JToken.Load(reader);

			if (token.Type == JTokenType.Array)
			{
				return token.ToObject<List<Korisnik>>();
			}

			return new List<Korisnik> { token.ToObject<Korisnik>() };
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			List<Korisnik> list = (List<Korisnik>)value;

			if (list.Count() == 1)
			{
				value = list[0];
			}

			serializer.Serialize(writer, value);
		}
	}
}
