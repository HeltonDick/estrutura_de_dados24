using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01
{
    public class Tipoenumerador{
        public enum Lenguage {
            PTBR, ENG, RU
        }

    public Lenguage _language = Language.PTBR;
    //variavel (public) do tipo (Language) com o nome (_language) que vai ter o atrubuto (PTBR) que está contido dentro de (Language)

    public Tipoenumerador() {
        
    }

    public TipoEnumerador(Tipoenumerador enum) {
        _language = enum;
    }

    public Lenguage GetLenguageEnum(string lang) {
        switch(lang.ToLower()) {
            case "português":
                return Lenguage.PTBR;
            case "Inglês":
                return Lenguage.ENG;
            case "Russo":
                return Lenguage.RU;
            default:
                return Lenguage.PTBR;        
        }
    }
    }
}