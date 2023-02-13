using System;
using System.Collections.Generic;

class LearnDictionary
{
    public void PrintDistrictPopulation()
    {
         //Create a datastructure to store district and it's population

        Dictionary<string, long> districtPopulation = new();
        {
            districtPopulation.Add("Jhapa",9898787);
            districtPopulation.Add("Morang",898787);
            districtPopulation.Add("Sunsari",1998787);
            districtPopulation.Add("Ilam",4598787);
            districtPopulation.Add("Panchtar",3898787);

        }
    }
}