using System.Collections.Generic;
using System.Linq;
using Loppprojekt.Data.Cars;

namespace Loppprojekt.Infra.Cars
{
    public static class CarsDbInitializer
    {

        

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
            db.SaveChanges();
        }

        private static void initializeMakes(CarsDbContext db)
        {
            if (db.Makes.Count() != 0) return;
            db.SaveChanges();
        }

    }
}
