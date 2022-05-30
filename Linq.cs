using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStuff
{
    public class Linq
    {
        
        public class Country
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class DipMission // Дипломатическая миссия
        {
            public int Id { get; set; }
            public int CountryId { get; set; }
            public string Name { get; set; }// Официальное название
            public int Amount { get; set; }//Кол-во дипломатов
        }

        public void Run()
        {
            var countries = new List<Country>
            {
                new Country { Id = 1, Name = "Федеративная республика Амогусов" },
                new Country { Id = 2, Name = "Конфедерация Абобусов" },
                new Country { Id = 3, Name = "Царство Бибабобусов" },
                new Country { Id = 4, Name = "Священная империя Бибабобабибусов" },
                new Country { Id = 5, Name = "Великое княжество Буль-Буль" },
                new Country { Id = 6, Name = "Теократическая республика Свинина-Халяль" },
                new Country { Id = 7, Name = "Вольный домен Чинчопа" },
                new Country { Id = 8, Name = "Город-государство им.Егора Летова"},
                new Country { Id = 9, Name = "Ржавый бункер моя свобода,сладкий пряник засох давно,сапогом моего народа старшина тормозит г***о!" },
                new Country { Id = 10, Name = "Королевство императорских демократических царей" }
            };

            var dipMissions = new List<DipMission>
            {
                new DipMission { Id = 1, CountryId = 1, Name = "Послы доброй воли", Amount = 10 },
                new DipMission { Id = 2, CountryId = 2, Name = "Послы не самой доброй воли", Amount = 6 },
                new DipMission { Id = 3, CountryId = 4, Name = "Послы откровенной злой воли", Amount = 5 },
                new DipMission { Id = 4, CountryId = 3, Name = "Просто враждебно настроенные люди", Amount = 3 },
                new DipMission { Id = 5, CountryId = 10, Name = "Мутные дипломаты", Amount = 64},
                new DipMission { Id = 6, CountryId = 5, Name = "Хитрые купцы", Amount = 7 },
                new DipMission { Id = 7, CountryId = 8, Name = "Дипломаты, которые правда хотят что-то решить", Amount = 2 },
                new DipMission { Id = 8, CountryId = 9, Name = "Убей в себе Государство!!!", Amount = 10000 },
                new DipMission { Id = 9, CountryId = 6, Name = "Вроде татарин, а вроде башкир", Amount = 1 },
                new DipMission { Id = 10, CountryId = 7, Name = "Ответ на Главный вопрос жизни, Вселенной и всего такого", Amount = 42 },
                new DipMission { Id = 11, CountryId = 4, Name = "Аааааа", Amount = 11 },
                new DipMission { Id = 12, CountryId = 1, Name = "Я гуль", Amount = 18 }
            };
            var list1 = from c in countries
                            join d in dipMissions on c.Name equals d.Name
                            select new { Country = c.Name, MissionName = d.Name };
            foreach (var i in list1)
                Console.WriteLine($"{i.Country} - {i.MissionName}");
        }
        
        //Создать список стран(id страны, название страны) не менее 10 и список дипломатических представительств
        //(id представительства, id страны, официальное название, количество дипломатов).
        //В одной стране может быть более 1 представительства
        //1)  Вывести список название страны, официальное название дип представительства(без циклов foreach/for/while)
        //2)  Вывести список название страны, количество дипломатов в этой стране, среднее количество дипломатов по представительствам в этой стране
        //3)  Вычислить среднее количество дипломатов в представительствах для стран, у которых более 2 представлительств
    }
}
