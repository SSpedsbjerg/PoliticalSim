using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliticalSim.PoliticalIdeoligies
{
    public interface IIdeology {
        float PoliceState { get; set; }
        float FreedomValue { get; set; }
        float FamilyValue { get; set; }
        float Individualism { get; set; }
        float NatinalValue { get; set; }
        float Tradidition { get; set; }
        float Progess { get; set; }
        float Democrazy { get; set; }
        float Globalism { get; set; }
        float Secular { get; set; }
        float Federalism { get; set; }
        float Multiculturislm { get; set; }
        float Racism { get; set; }
        float FreedomOfTrade { get; set; }

    }
}
