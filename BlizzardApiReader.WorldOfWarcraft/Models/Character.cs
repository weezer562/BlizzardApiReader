﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Character
    {
        public string Name { get; set; }

        public string Realm { get; set; }

        public string BattleGroup { get; set; }

        public int Class { get; set; }
        public int Race { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public int AchivementPoints { get; set; }
        public string Thumbnail { get; set; }

        public Spec Spec { get; set; }

        public string Guild { get; set; }

        public string GuildRealm { get; set; }

        //TODO: Review format, sometimes comes with a value of 0, sometimes with >0
        //TODO: Look for which format is used and how to deal with the 0 values.
        public string LastModified { get; set; }

        // Fields comming from profile

        public string CalcClass { get; set; }

        public int Faction { get; set; }

        public int TotalHonorableKills { get; set; }

    }
}
