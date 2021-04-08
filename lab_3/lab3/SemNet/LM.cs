using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setee
{
    class LM
    {
        Generator Generator;
        IReadOnlyList<Entity> eneties;
        IReadOnlyList<Connection> connections;

        public LM()
        {
            Generator = new Generator();
            connections = Generator.connection;
            eneties = Generator.entity;
        }
        public bool question1(string quest1, string quest2)
        {
            Entity CurrentQuest1=null;
            foreach(var enety in eneties)
            {
                if(enety.Name== quest1)
                {
                    CurrentQuest1 = enety;
                }
            }
            bool v = false ;
            bool Answer = false;
            do
            {
                v = false;
                foreach (var conn in CurrentQuest1.Connections)
                {
                    if (conn.Qust2.Name != CurrentQuest1.Name)
                    {
                        if (conn.ConnectionType == "AKO" || conn.ConnectionType == "Is_a" )
   
                        {
                            if (conn.Qust2.Name == quest2)
                            {
                                Answer = true;
                                break;
                            }
                            else
                            {
                                CurrentQuest1 = conn.Qust2;
                                v = true;
                                break;
                            }
                        }
                    }
                }
            } while (v);
            return Answer;
        }
        public bool question2(string quest1, string quest2)
        {
            Entity CurrentQuest1 = null;
            foreach (var enety in eneties)
            {
                if (enety.Name == quest1)
                {
                    CurrentQuest1 = enety;
                }
            }
            bool v = false;
            bool Answer = false;
            do
            {
                v = false;
                foreach (var conn in CurrentQuest1.Connections)
                {
                    if (conn.Qust2.Name != CurrentQuest1.Name)
                    {
                        if ( conn.ConnectionType == "Влияет" || conn.ConnectionType == "Тип животного")

                        {
                            if (conn.Qust2.Name == quest2)
                            {
                                Answer = true;
                                break;
                            }
                            else
                            {
                                CurrentQuest1 = conn.Qust2;
                                v = true;
                                break;
                            }
                        }
                    }
                }
            } while (v);
            return Answer;
        }
        public string questionresponse(string nameEntity)
        {
            string Fur=null;

            Entity CurrentQuest = null;
            foreach (var enety in eneties)
            {
                if (enety.Name == nameEntity)
                {
                    CurrentQuest = enety;
                }
            }
            foreach (var conn in CurrentQuest.Connections)
            {
                if (conn.ConnectionType == "Шерсть")
                {
                    Fur=conn.Qust2.Name;
                }
            }
            return Fur;
        }
        
        
    }
}
