using System;
using System.Collections.Generic;
using System.Linq;
using Loppprojekt.Data.Cars;

namespace Loppprojekt.Infra.Cars
{
    public static class CarsDbInitializer
    {
        internal static MarkData bmw = new MarkData
        {
            Name = "BMW",
            Country = "GR",
            Description = "German car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData mercedes = new MarkData
        {
            Name = "Mercedes",
            Country = "GR",
            Description = "German car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData honda = new MarkData
        {
            Name = "Honda",
            Country = "JP",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        
        internal static List<MarkData> marks => new List<MarkData>
        {
            bmw, mercedes, honda
        };
        public const string series3 = "3.series";
        public const string series5 = "5.series";
        public const string X5 = "X5";

        internal static List<ModelData> bmwModels => new List<ModelData>
        {
            createModelData(bmw.Name, series3),
            createModelData(bmw.Name, series5),
            createModelData(bmw.Name, X5)
        };

        public const string SClassName = "SClass";
        public const string EClassName = "EClass";
        public const string CClassName = "CClass";
        internal static List<ModelData> mercedesModels => new List<ModelData>
        {
            createModelData(mercedes.Name, SClassName),
            createModelData(mercedes.Name, EClassName),
            createModelData(mercedes.Name, CClassName)
        };
        public const string CRVName = "CRV";
        public const string CivicName = "Civic";
        internal static List<ModelData> hondaModels => new List<ModelData>
        {
            createModelData(honda.Name, CRVName),
            createModelData(honda.Name, CivicName)
        };

        public const string E36 = "E36";
        public const string E46 = "E46";

        internal static List<GenerationData> series3Generation => new List<GenerationData>
        {
            createGenerationData(bmw.Name, series3, E36),
            createGenerationData(bmw.Name, series3, E46)
        };
        public const string E34 = "E34";
        public const string E60 = "E60";
        internal static List<GenerationData> series5Generation => new List<GenerationData>
        {
            createGenerationData(bmw.Name, series5, E34),
            createGenerationData(bmw.Name, series5, E60)
        };

        private static ModelData createModelData(string markId, string name, string description = null, string country = null, string yearOfManufacture = null)
        {
            return new ModelData
            {
                MarkId = markId,
                Name = name,
                Country = country,
                Description = description,
                YearOfManufacture = Convert.ToDateTime(yearOfManufacture)
            };
        }

        private static GenerationData createGenerationData(string markId, string modelsId, string name, string description = null, string country = null, string yearOfManufacture = null)
        {
            return new GenerationData
            {
                MarkId = markId,
                ModelsId = modelsId,
                Name = name,
                Country = country,
                Description = description,
                YearOfManufacture = Convert.ToDateTime(yearOfManufacture)
            };
        }

        public static void Initialize(CarsDbContext db)
        {
            initializeMarks(db);
            initializeModels(db);
            initializeGenerations(db);
        }

        private static void initializeModels(CarsDbContext db)
        {
            if (db.Models.Count() != 0) return;
            db.Models.AddRange(bmwModels);
            db.Models.AddRange(mercedesModels);
            db.Models.AddRange(hondaModels);
            db.SaveChanges();
        }

        private static void initializeMarks(CarsDbContext db)
        {
            if (db.Marks.Count() != 0) return;
            db.Marks.AddRange(marks);
            db.SaveChanges();
        }

        private static void initializeGenerations(CarsDbContext db)
        {
            if (db.Generations.Count() != 0) return;
            db.Generations.AddRange(series3Generation);
            db.Generations.AddRange(series5Generation);
            db.SaveChanges();
        }

    }
}
