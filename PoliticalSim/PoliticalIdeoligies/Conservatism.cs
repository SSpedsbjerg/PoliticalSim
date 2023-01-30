using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliticalSim.PoliticalIdeoligies {
    public abstract class Conservatism : IIdeology{
        float ps = 0.6f;
        float freedomV = 0.5f;
        float familyV = 0.7f;
        float ind = 0.6f;
        float nv = 0.4f;
        float trad = 0.6f;
        float prog = 0.6f;
        float demo = 0.90f;
        float glo = 0.4f;
        float sec = -1f;
        float fed = -1f;
        float multi = 0.4f;
        float rac = -1f;
        float freeT = 0.5f;


        public float PoliceState { get { return ps; } set { this.ps = value; } }
        public float FreedomValue { get { return freedomV; } set { this.freedomV = value; } }
        public float FamilyValue { get { return familyV; } set { this.familyV = value; } }
        public float Individualism { get { return ind; } set { this.ind = value; } }
        public float NatinalValue { get { return nv; } set { this.nv = value; } }
        public float Tradidition { get { return trad; } set { this.trad = value; } }
        public float Progess { get { return prog; } set { this.prog = value; } }
        public float Democrazy { get { return demo; } set { this.demo = value; } }
        public float Globalism { get { return glo; } set { this.glo = value; } }
        public float Secular { get { return sec; } set { this.sec = value; } }
        public float Federalism { get { return fed; } set { this.fed = value; } }
        public float Multiculturislm { get { return multi; } set { this.multi = value; } }
        public float Racism { get { return rac; } set { this.rac = value; } }
        public float FreedomOfTrade { get { return freeT; } set { this.freeT = value; } }
    }
}
