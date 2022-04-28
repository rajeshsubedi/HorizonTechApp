using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HorizonTech.FeaturesDatabase
{


    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Subscribed { get; set; }

    }
}