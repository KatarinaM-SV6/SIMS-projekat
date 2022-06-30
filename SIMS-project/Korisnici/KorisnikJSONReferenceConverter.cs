using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SIMS_project.Korisnici
{
    internal class KorisnikJSONReferenceConverter : JsonConverter 
    {
		internal static KorisnikRepository Repo { get; set; }

		public KorisnikJSONReferenceConverter()
		{
			if (Repo == null) throw new Exception();
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Korisnik);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var korisnikID = serializer.Deserialize<int>(reader);
			return Repo.GetAll().First(eq => eq.Id == korisnikID);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			serializer.Serialize(writer, ((Korisnik)value).Id);
		}
	}
}
