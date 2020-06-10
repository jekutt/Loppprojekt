using System;
using System.Collections.Generic;
using System.Linq;
using Loppprojekt.Data.Cars.Generations;
using Loppprojekt.Data.Cars.Marks;
using Loppprojekt.Data.Cars.Models;

namespace Loppprojekt.Infra.Cars.CarsDb
{
    public static class CarsDbInitializer
    {
        internal static MarkData bmw = new MarkData
        {
            Name = "BMW",
            Country = "Germany",
            Description = "German car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData mercedes = new MarkData
        {
            Name = "Mercedes-Benz",
            Country = "Germany",
            Description = "German car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData honda = new MarkData
        {
            Name = "Honda",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData audi = new MarkData
        {
            Name = "Audi",
            Country = "Germany",
            Description = "German car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData lamborghini = new MarkData
        {
            Name = "Lamborghini",
            Country = "Italy",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData mitsubishi = new MarkData
        {
            Name = "Mitsubishi",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData porsche = new MarkData
        {
            Name = "Porsche",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData subaru = new MarkData
        {
            Name = "Subaru",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData toyota = new MarkData
        {
            Name = "Toyota",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static MarkData volkswagen = new MarkData
        {
            Name = "Volkswagen",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<MarkData> marks => new List<MarkData>
        {
            bmw, mercedes, honda, audi, lamborghini, mitsubishi, porsche, subaru, toyota, volkswagen
        };

        internal static ModelData series3 = new ModelData
        {
            MarkId = "BMW",
            Name = "3.series",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData series5 = new ModelData
        {
            MarkId = "BMW",
            Name = "5.series",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData x5 = new ModelData
        {
            MarkId = "BMW",
            Name = "X5",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> bmwModels => new List<ModelData>
        {
            series3, series5, x5
        };

        internal static ModelData a4 = new ModelData
        {
            MarkId = "Audi",
            Name = "A4",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData q7 = new ModelData
        {
            MarkId = "Audi",
            Name = "Q7",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData tt = new ModelData
        {
            MarkId = "Audi",
            Name = "TT",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> audiModels => new List<ModelData>
        {
            a4, q7, tt
        };

        internal static ModelData accord = new ModelData
        {
            MarkId = "Honda",
            Name = "Accord",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData civic = new ModelData
        {
            MarkId = "Honda",
            Name = "Civic",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData crv = new ModelData
        {
            MarkId = "Honda",
            Name = "CR-V",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> hondaModels => new List<ModelData>
        {
            accord, civic, crv
        };

        internal static ModelData lancer = new ModelData
        {
            MarkId = "Mitsubishi",
            Name = "Lancer",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData galant = new ModelData
        {
            MarkId = "Mitsubishi",
            Name = "Galant",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData pajero = new ModelData
        {
            MarkId = "Mitsubishi",
            Name = "Pajero",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> mitsubishiModels => new List<ModelData>
        {
            lancer, galant, pajero
        };

        internal static ModelData camry = new ModelData
        {
            MarkId = "Toyota",
            Name = "Camry",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData hilux = new ModelData
        {
            MarkId = "Toyota",
            Name = "Hilux",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData supra = new ModelData
        {
            MarkId = "Toyota",
            Name = "Supra",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> toyotaModels => new List<ModelData>
        {
            camry, hilux, supra
        };

        internal static ModelData impreza = new ModelData
        {
            MarkId = "Subaru",
            Name = "Impreza",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData forester = new ModelData
        {
            MarkId = "Subaru",
            Name = "Forester",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData legacy = new ModelData
        {
            MarkId = "Subaru",
            Name = "Legacy",
            Country = "Japan",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> subaruModels => new List<ModelData>
        {
            impreza, forester, legacy
        };

        internal static ModelData eclass = new ModelData
        {
            MarkId = "Mercedes-Benz",
            Name = "E-class",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData sclass = new ModelData
        {
            MarkId = "Mercedes-Benz",
            Name = "S-class",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData gclass = new ModelData
        {
            MarkId = "Mercedes-Benz",
            Name = "G-class",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> mercedesModels => new List<ModelData>
        {
            eclass, sclass, gclass
        };

        internal static ModelData m911 = new ModelData
        {
            MarkId = "Porsche",
            Name = "911",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData cayenne = new ModelData
        {
            MarkId = "Porsche",
            Name = "Cayenne",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData panamera = new ModelData
        {
            MarkId = "Porsche",
            Name = "Panamera",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> porscheModels => new List<ModelData>
        {
            m911, cayenne, panamera
        };

        internal static ModelData golf = new ModelData
        {
            MarkId = "Volkswagen",
            Name = "Golf",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData passat = new ModelData
        {
            MarkId = "Volkswagen",
            Name = "Passat",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData caravelle = new ModelData
        {
            MarkId = "Volkswagen",
            Name = "Caravelle",
            Country = "Germany",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> volkswagenModels => new List<ModelData>
        {
            golf, passat, caravelle
        };

        internal static ModelData diablo = new ModelData
        {
            MarkId = "Lamborghini",
            Name = "Diablo",
            Country = "Italy",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData gallardo = new ModelData
        {
            MarkId = "Lamborghini",
            Name = "Gallardo",
            Country = "Italy",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static ModelData murcielago = new ModelData
        {
            MarkId = "Lamborghini",
            Name = "Murcielago",
            Country = "Italy",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<ModelData> lamborghiniModels => new List<ModelData>
        {
            diablo, gallardo, murcielago
        };

        internal static GenerationData b5 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "A4",
            Name = "B5",
            Country = "Germany",
            BodyType = "Wagon",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData b7 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "A4",
            Name = "B7",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData b9 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "A4",
            Name = "B9",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> a4Generation => new List<GenerationData>
        {
            b5, b7, b9
        };

        internal static GenerationData firstGen = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "Q7",
            Name = "Q7 1st gen",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData secondGen = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "Q7",
            Name = "Q7 2nd gen",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> q7Generation => new List<GenerationData>
        {
            firstGen, secondGen
        };

        internal static GenerationData n8 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "TT",
            Name = "8N",
            Country = "Germany",
            BodyType = "Coupe",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData j8 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "TT",
            Name = "8J",
            Country = "Germany",
            BodyType = "Coupe",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData j8Face = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "TT",
            Name = "8J (facelift)",
            Country = "Germany",
            BodyType = "Coupe",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> ttGeneration => new List<GenerationData>
        {
            n8, j8, j8Face
        };

        internal static GenerationData e36 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "3.series",
            Name = "E36",
            Country = "Germany",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData e46 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "3.series",
            Name = "E46",
            Country = "Germany",
            BodyType = "Wagon",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData f30 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "3.series",
            Name = "F30",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> series3Generation => new List<GenerationData>
        {
            e36, e46, f30
        };

        internal static GenerationData e34 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "5.series",
            Name = "E34",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData e60 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "5.series",
            Name = "E60",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData f10 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "5.series",
            Name = "F10",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> series5Generation => new List<GenerationData>
        {
            e34, e60, f10
        };

        internal static GenerationData e53 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "X5",
            Name = "E53",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData e70 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "X5",
            Name = "E70",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData f15 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "X5",
            Name = "F15",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> x5Generation => new List<GenerationData>
        {
            e53, e70, f15
        };

        internal static GenerationData w124 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "E-class",
            Name = "W124",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData w211 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "E-class",
            Name = "W211",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData w212 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "E-class",
            Name = "W212",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> eClassGeneration => new List<GenerationData>
        {
            w124, w211, w212
        };

        internal static GenerationData w140 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "S-class",
            Name = "W140",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData w221 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "S-class",
            Name = "W221",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData w222 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "S-class",
            Name = "W222",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> sClassGeneration => new List<GenerationData>
        {
            w140, w221, w222
        };

        internal static GenerationData w463 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "G-class",
            Name = "W463",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData w463Face = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "G-class",
            Name = "W463 (facelift)",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData w463Face2 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "G-class",
            Name = "W463 (facelift 2)",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> gClassGeneration => new List<GenerationData>
        {
            w463, w463Face, w463Face2
        };

        internal static GenerationData p996 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "911",
            Name = "996",
            Country = "Germany",
            BodyType = "Targa",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData p997 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "911",
            Name = "997",
            Country = "Germany",
            BodyType = "Convertible",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData p991 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "911",
            Name = "991",
            Country = "Germany",
            BodyType = "Convertible",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> p911Generation => new List<GenerationData>
        {
            p991, p996, p997
        };

        internal static GenerationData p955 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Cayenne",
            Name = "955",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData p957 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Cayenne",
            Name = "957",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData p958 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Cayenne",
            Name = "958",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> cayenneGeneration => new List<GenerationData>
        {
            p955, p957, p958
        };

        internal static GenerationData e2b = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Panamera",
            Name = "E2B",
            Country = "Germany",
            BodyType = "Fastback",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData e2bFace = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Panamera",
            Name = "E2B (facelift)",
            Country = "Germany",
            BodyType = "Fastback",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> panameraGeneration => new List<GenerationData>
        {
           e2b, e2bFace
        };

        internal static GenerationData firstGener = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Golf",
            Name = "Golf 1st gen",
            Country = "Germany",
            BodyType = "Hatchback",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData fifthGener = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Golf",
            Name = "Golf 5th gen",
            Country = "Germany",
            BodyType = "Hatchback",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData sixthGener = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Golf",
            Name = "Golf 6th gen",
            Country = "Germany",
            BodyType = "Hatchback",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> golfGeneration => new List<GenerationData>
        {
            firstGener, fifthGener, sixthGener
        };

        internal static GenerationData b3 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Passat",
            Name = "Passat B3",
            Country = "Germany",
            BodyType = "Wagon",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData b6 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Passat",
            Name = "Passat B6",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData b7w = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Passat",
            Name = "Passat B7",
            Country = "Germany",
            BodyType = "Wagon",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> passatGeneration => new List<GenerationData>
        {
            b3, b6, b7w
        };

        internal static GenerationData t4 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Caravelle",
            Name = "Caravelle 1st gen",
            Country = "Germany",
            BodyType = "Van",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData t5 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Caravelle",
            Name = "Caravelle 5th gen",
            Country = "Germany",
            BodyType = "Van",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData t6 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Caravelle",
            Name = "Caravelle 6th gen",
            Country = "Germany",
            BodyType = "Van",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> caravelleGeneration => new List<GenerationData>
        {
            t4, t5, t6
        };

        internal static GenerationData firstG = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Diablo",
            Name = "Diablo 1st gen",
            Country = "Italy",
            BodyType = "Roadster",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData secondG = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Diablo",
            Name = "Diablo 2nd gen",
            Country = "Italy",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData segondGFace = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Diablo",
            Name = "Diablo 2nd gen(facelift)",
            Country = "Italy",
            BodyType = "Coupe",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> diabloGeneration => new List<GenerationData>
        {
            firstG, secondG, segondGFace
        };

        internal static GenerationData firstGenerat = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Gallardo",
            Name = "Gallardo 1st gen",
            Country = "Italy",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData firstGeneratFace = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Gallardo",
            Name = "Gallardo 1st gen(facelift)",
            Country = "Italy",
            BodyType = "Convertible",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> gallardoGeneration => new List<GenerationData>
        {
            firstGenerat, firstGeneratFace
        };

        internal static GenerationData firstGenerati = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Murcielago",
            Name = "Murcielago 1st gen",
            Country = "Italy",
            BodyType = "Roadster",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData secondGenerati = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Murcielago",
            Name = "Murcielago 2nd gen",
            Country = "Italy",
            BodyType = "Coupe",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> murcielagoGeneration => new List<GenerationData>
        {
            firstGenerati, secondGenerati
        };

        internal static GenerationData seventhG = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Accord",
            Name = "Accord 7th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData eightG = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Accord",
            Name = "Accord 8th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData ninthG= new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Accord",
            Name = "Accord 9th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> accordGeneration => new List<GenerationData>
        {
            seventhG, eightG, ninthG
        };

        internal static GenerationData fifthGen = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Civic",
            Name = "Civic 5th gen",
            Country = "Japan",
            BodyType = "Coupe",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData sevenhtGen = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Civic",
            Name = "Civic 7th gen",
            Country = "Japan",
            BodyType = "Coupe",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData ninthGen = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Civic",
            Name = "Civic 9th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> civicGeneration => new List<GenerationData>
        {
            fifthGen, sevenhtGen, ninthGen
        };

        internal static GenerationData secondGene = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "CR-V",
            Name = "CR-V 2nd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData thirdGene = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "CR-V",
            Name = "CR-V 3rd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData fourthGene = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "CR-V",
            Name = "CR-V 4th gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> crvGeneration => new List<GenerationData>
        {
            secondGene, thirdGene, fourthGene
        };

        internal static GenerationData m4G = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Lancer",
            Name = "Lancer 4th gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData m5G = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Lancer",
            Name = "Lancer 5th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData m6G = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Lancer",
            Name = "Lancer 6th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> lancerGeneration => new List<GenerationData>
        {
            m4G, m5G, m6G
        };

        internal static GenerationData g5m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Galant",
            Name = "Galant 5th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData g6m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Galant",
            Name = "Galant 6th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData g7m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Galant",
            Name = "Galant 7th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> galantGeneration => new List<GenerationData>
        {
            g5m, g6m, g7m
        };

        internal static GenerationData ge3m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Pajero",
            Name = "Pajero 3rd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData ge4m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Pajero",
            Name = "Pajero 4th gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData ge5m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Pajero",
            Name = "Pajero 5th gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> pajeroGeneration => new List<GenerationData>
        {
            ge3m, ge4m, ge5m
        };

        internal static GenerationData s1G = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Impreza",
            Name = "Impreza 1st gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData s2G = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Impreza",
            Name = "Impreza 2nd gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData s3G = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Impreza",
            Name = "Impreza 3rd gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> imprezaGeneration => new List<GenerationData>
        {
            s1G, s2G, s3G
        };

        internal static GenerationData s2Ge = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Forester",
            Name = "Forester 2nd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData s3Ge = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Forester",
            Name = "Forester 3rd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData s4Ge = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Forester",
            Name = "Forester 4th gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> foresterGeneration => new List<GenerationData>
        {
            s2Ge, s3Ge, s4Ge
        };

        internal static GenerationData s2Gen = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Legacy",
            Name = "Legacy 2nd gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData s3Gen = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Legacy",
            Name = "Legacy 3rd gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData s4Gen = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Legacy",
            Name = "Legacy 4th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> legacyGeneration => new List<GenerationData>
        {
            s2Gen, s3Gen, s4Gen
        };

        internal static GenerationData xv40 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Camry",
            Name = "XV40",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData xv50 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Camry",
            Name = "XV50",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData t8G = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Camry",
            Name = "Camry 8th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };

        internal static List<GenerationData> camryGeneration => new List<GenerationData>
        {
            xv40, xv50, t8G
        };

        internal static GenerationData t5Ge = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Hilux",
            Name = "Hilux 5th gen",
            Country = "Japan",
            BodyType = "Pickup",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData t7Ge = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Hilux",
            Name = "Hilux 7th gen",
            Country = "Japan",
            BodyType = "Pickup",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData t8Ge = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Hilux",
            Name = "Hilux 8th gen",
            Country = "Japan",
            BodyType = "Pickup",
            DrivenWheel = "AWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> hiluxGeneration => new List<GenerationData>
        {
            t5Ge, t7Ge, t8Ge
        };

        internal static GenerationData a70 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Supra",
            Name = "A70",
            Country = "Japan",
            BodyType = "Targa",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData a80 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Supra",
            Name = "A80",
            Country = "Japan",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static GenerationData a90 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Supra",
            Name = "A90",
            Country = "Japan",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "Japan car",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> supraGeneration => new List<GenerationData>
        {
            a70, a80, a90
        };

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
            db.Models.AddRange(toyotaModels);
            db.Models.AddRange(lamborghiniModels);
            db.Models.AddRange(porscheModels);
            db.Models.AddRange(subaruModels);
            db.Models.AddRange(mitsubishiModels);
            db.Models.AddRange(volkswagenModels);
            db.Models.AddRange(audiModels);

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
            db.Generations.AddRange(ttGeneration);
            db.Generations.AddRange(a4Generation);
            db.Generations.AddRange(q7Generation);
            db.Generations.AddRange(series3Generation);
            db.Generations.AddRange(series5Generation);
            db.Generations.AddRange(x5Generation);
            db.Generations.AddRange(accordGeneration);
            db.Generations.AddRange(civicGeneration); 
            db.Generations.AddRange(crvGeneration);
            db.Generations.AddRange(diabloGeneration);
            db.Generations.AddRange(gallardoGeneration);
            db.Generations.AddRange(murcielagoGeneration);
            db.Generations.AddRange(eClassGeneration);
            db.Generations.AddRange(sClassGeneration);
            db.Generations.AddRange(gClassGeneration);
            db.Generations.AddRange(lancerGeneration);
            db.Generations.AddRange(galantGeneration);
            db.Generations.AddRange(pajeroGeneration);
            db.Generations.AddRange(p911Generation);
            db.Generations.AddRange(cayenneGeneration);
            db.Generations.AddRange(panameraGeneration);
            db.Generations.AddRange(imprezaGeneration);
            db.Generations.AddRange(foresterGeneration);
            db.Generations.AddRange(legacyGeneration);
            db.Generations.AddRange(camryGeneration);
            db.Generations.AddRange(hiluxGeneration);
            db.Generations.AddRange(supraGeneration);
            db.Generations.AddRange(golfGeneration);
            db.Generations.AddRange(passatGeneration);
            db.Generations.AddRange(caravelleGeneration);
            db.SaveChanges();
        }

    }
}
