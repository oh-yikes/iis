using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setee
{
    class Generator
    {
        List<Entity> Entites = new List<Entity>();
        List<Connection> connections = new List<Connection>();
        public IReadOnlyList<Entity> entity => Entites;
        public IReadOnlyList<Connection> connection => connections;

        public Generator()
        {

            Entites.Add(new Entity("Животное"));//0
            Entites.Add(new Entity("Назначение"));//1
            Entites.Add(new Entity("Кому"));//2
            Entites.Add(new Entity("Рыбка"));//3
            Entites.Add(new Entity("Собака"));//4
            Entites.Add(new Entity("Кошка"));//5
            Entites.Add(new Entity("Ящерка"));//6
            Entites.Add(new Entity("Попугай"));//7
            Entites.Add(new Entity("Интерактивное"));//8
            Entites.Add(new Entity("Декоративное"));//9
            Entites.Add(new Entity("Себе"));//10
            Entites.Add(new Entity("Ребенку"));//11
            Entites.Add(new Entity("В офис"));//12
            Entites.Add(new Entity("Шерсть"));//13
            Entites.Add(new Entity("Наличие шерсти"));//14
            Entites.Add(new Entity("Отсутствие шерсти"));//15
            Entites.Add(new Entity("Готовность тратиться"));//16
            Entites.Add(new Entity("Есть готовность тратиться"));//17
            Entites.Add(new Entity("Нет готовности тратиться"));//18
            Entites.Add(new Entity("Терпимость к шуму"));//19
            Entites.Add(new Entity("Наличие терпимости к шуму"));//20
            Entites.Add(new Entity("Отсутствие терпимости к шуму"));//21
            Entites.Add(new Entity("Аллергия"));//22
            Entites.Add(new Entity("Наличие аллергии"));//23
            Entites.Add(new Entity("Отсутствие аллергии"));//24
            Entites.Add(new Entity("Свободное время"));//25
            Entites.Add(new Entity("Наличие свободного времени"));//26
            Entites.Add(new Entity("Отсутствие свободного времени"));//27
            Entites.Add(new Entity("Экзотичность"));//28
            Entites.Add(new Entity("Экзотичное"));//29
	        Entites.Add(new Entity("Не экзотичное"));//30
            Entites.Add(new Entity("Либо себе, либо ребенку"));//31
            Entites.Add(new Entity("Либо себе, либо ребенку, либо в офис"));//32
            Entites.Add(new Entity("Либо себе, либо в офис"));//33





            connections.AddRange(new List<Connection>()
            {
                new Connection("Влияет").SetEntitys(Entites[4], Entites[14]),
                new Connection("Влияет").SetEntitys(Entites[5], Entites[14]),
                new Connection("Влияет").SetEntitys(Entites[3], Entites[15]),
                new Connection("Влияет").SetEntitys(Entites[6], Entites[15]),
                new Connection("Влияет").SetEntitys(Entites[7], Entites[15]),
                new Connection("Влияет").SetEntitys(Entites[3], Entites[20]),
                new Connection("Влияет").SetEntitys(Entites[6], Entites[20]),
                new Connection("Влияет").SetEntitys(Entites[3], Entites[21]),
                new Connection("Влияет").SetEntitys(Entites[4], Entites[21]),
                new Connection("Влияет").SetEntitys(Entites[5], Entites[21]),

            });
            connections.AddRange(new List<Connection>()
            {
                new Connection("Шерсть").SetEntitys(Entites[15], Entites[6]),
                new Connection("Шерсть").SetEntitys(Entites[15], Entites[7]),
                new Connection("Шерсть").SetEntitys(Entites[15], Entites[3]),
                new Connection("Шерсть").SetEntitys(Entites[14], Entites[4]),
                new Connection("Шерсть").SetEntitys(Entites[14], Entites[5]),

            });


            connections.AddRange(new List<Connection>()
            {
                new Connection("Тип животного").SetEntitys(Entites[29], Entites[6]),
                new Connection("Тип животного").SetEntitys(Entites[29], Entites[7]),
                new Connection("Тип животного").SetEntitys(Entites[30], Entites[3]),
                new Connection("Тип животного").SetEntitys(Entites[30], Entites[4]),
                new Connection("Тип животного").SetEntitys(Entites[30], Entites[5]),
           
            });



            //  connections.AddRange(new List<Connection>()
            //  {
            //      new Connection("Шум").SetEntitys(Entites[20], Entites[4]),
            //      new Connection("Шум").SetEntitys(Entites[20], Entites[7]),
            //      new Connection("Шум").SetEntitys(Entites[21], Entites[3]),
            //      new Connection("Шум").SetEntitys(Entites[21], Entites[5]),
            //      new Connection("Шум").SetEntitys(Entites[21], Entites[6]),

            //  });

            connections.AddRange(new List<Connection>()
            {
                new Connection("AKO").SetEntitys(Entites[0], Entites[3]),
                new Connection("AKO").SetEntitys(Entites[0], Entites[4]),
                new Connection("AKO").SetEntitys(Entites[0], Entites[5]),
                new Connection("AKO").SetEntitys(Entites[0], Entites[6]),
                new Connection("AKO").SetEntitys(Entites[0], Entites[7]),
                new Connection("AKO").SetEntitys(Entites[1], Entites[8]),
                new Connection("AKO").SetEntitys(Entites[1], Entites[9]),
                new Connection("AKO").SetEntitys(Entites[2], Entites[10]),
                new Connection("AKO").SetEntitys(Entites[2], Entites[11]),
                new Connection("AKO").SetEntitys(Entites[2], Entites[12]),
                new Connection("AKO").SetEntitys(Entites[13], Entites[14]),
                new Connection("AKO").SetEntitys(Entites[13], Entites[15]),
                new Connection("AKO").SetEntitys(Entites[16], Entites[17]),
                new Connection("AKO").SetEntitys(Entites[16], Entites[18]),
                new Connection("AKO").SetEntitys(Entites[19], Entites[20]),
                new Connection("AKO").SetEntitys(Entites[19], Entites[21]),
                new Connection("AKO").SetEntitys(Entites[22], Entites[23]),
                new Connection("AKO").SetEntitys(Entites[22], Entites[24]),
                new Connection("AKO").SetEntitys(Entites[25], Entites[26]),
		        new Connection("AKO").SetEntitys(Entites[25], Entites[27]),
		        new Connection("AKO").SetEntitys(Entites[28], Entites[29]),
		        new Connection("AKO").SetEntitys(Entites[28], Entites[30]),
            });
            connections.AddRange(new List<Connection>()
            {
                new Connection("Is_a").SetEntitys(Entites[24], Entites[4]),
                new Connection("Is_a").SetEntitys(Entites[24], Entites[5]),
                new Connection("Is_a").SetEntitys(Entites[23], Entites[3]),
                new Connection("Is_a").SetEntitys(Entites[23], Entites[6]),
                new Connection("Is_a").SetEntitys(Entites[23], Entites[7]),
                //new Connection("Is_a").SetEntitys(Entites[30], Entites[26]),
                //new Connection("Is_a").SetEntitys(Entites[29], Entites[22]),
                //new Connection("Is_a").SetEntitys(Entites[29], Entites[23]),

            });

        }
    }
}