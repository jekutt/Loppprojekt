using System.Collections.Generic;
using System.Linq;
using Loppprojekt.Data.Cars;

namespace Loppprojekt.Infra.Cars
{
    public static class CarsDbInitializer
    {
        internal static MakeData bmw = new MakeData
        {
            Id = "BMW",
            Name = "BMW",
            Code = "BMW",
            Definition = "German car"
        };
        internal static MakeData mercedes = new MakeData
        {
            Id = "Mercedes",
            Name = "Mercedes",
            Code = "Mercedes",
            Definition = "German car"
        };
        internal static MakeData honda = new MakeData
        {
            Id = "Honda",
            Name = "Honda",
            Code = "Honda",
            Definition = "Japan car"
        };
        
        internal static List<MakeData> makes => new List<MakeData>
        {
            bmw, mercedes, honda
        };
        public const string E39Name = "E39";
        public const string E60Name = "E60";
        public const string X5Name = "X5";

        internal static List<ModelData> bmwModels => new List<ModelData>
        {
            createModelData(bmw.Id, E39Name),
            createModelData(bmw.Id, E60Name),
            createModelData(bmw.Id, X5Name)
        };

        public const string SClassName = "SClass";
        public const string EClassName = "EClass";
        public const string CClassName = "CClass";
        internal static List<ModelData> mercedesModels => new List<ModelData>
        {
            createModelData(mercedes.Id, SClassName),
            createModelData(mercedes.Id, EClassName),
            createModelData(mercedes.Id, CClassName)
        };
        public const string CRVName = "CRV";
        public const string CivicName = "Civic";
        internal static List<ModelData> hondaModels => new List<ModelData>
        {
            createModelData(honda.Id, CRVName),
            createModelData(honda.Id, CivicName)
        };

        private static ModelData createModelData(string makeId, string id, string name = null, string code = null)
        {
            return new ModelData
            {
                Id = id,
                MakeId = makeId,
                Name = name ?? id,
                Code = code
            };
        }

        public static void Initialize(CarsDbContext db)
        {
            initializeMakes(db);
            initializeModels(db);
        }

        private static void initializeModels(CarsDbContext db)
        {
            if (db.Models.Count() != 0) return;
            db.Models.AddRange(bmwModels);
            db.Models.AddRange(mercedesModels);
            db.Models.AddRange(hondaModels);
            db.SaveChanges();
        }

        private static void initializeMakes(CarsDbContext db)
        {
            if (db.Makes.Count() != 0) return;
            db.Makes.AddRange(makes);
            db.SaveChanges();
        }

    }
}
