using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static   class LamaData 
{
   static public Dictionary<string, float> plentyLama1 = new Dictionary<string, float>()
        {
            { "картошка",60 },
            { "горшки", 74 },
            { "персики", 100 },
            {"ткачество", 40 },
            {"ковры", 30 },
            {"химчистка", 30 },
            {"археология", 30 },
            {"приключения", 36 },
            {"тоннели" , 30},
            {"экстравагантность", 40 },
            {"расчески", 30 }

        };
    static public Dictionary<string, float> plentyLama2 = new Dictionary<string, float>()
        {
            { "картошка", 30 },
            { "горшки", 40 },
            { "персики", 30 },
            {"ткачество", 80 },
            {"ковры", 90 },
            {"химчистка", 30 },
            {"археология", 40 },
            {"приключения", 50 },
            {"тоннели" , 30},
            {"экстравагантность", 40 },
            {"расчески", 50 }

        };
    static public Dictionary<string, float> plentyLama3 = new Dictionary<string, float>()
        {
            { "картошка", 40 },
            { "горшки", 60 },
            { "персики", 0 },
            {"ткачество", 35 },
            {"ковры", 40 },
            {"химчистка", 90 },
            {"археология", 36 },
            {"приключения", 40 },
            {"тоннели" , 32},
            {"экстравагантность", 40 },
            {"расчески", 50 }
        };
    static public Dictionary<string, float> plentyLama4 = new Dictionary<string, float>()
        {
            { "картошка", 50 },
            { "горшки", 50 },
            { "персики", 40 },
            {"ткачество", 30 },
            {"ковры", 40 },
            {"химчистка", 30 },
            {"археология", 76 },
            {"приключения", 80 },
            {"тоннели" , 90},
            {"экстравагантность", 40 },
            {"расчески", 50 }
        };
    static public Dictionary<string, float> plentyLama5 = new Dictionary<string, float>()
        {
            { "картошка", 40 },
            { "горшки", 50 },
            { "персики", 50 },
            {"ткачество", 40 },
            {"ковры", 50 },
            {"химчистка", 40 },
            {"археология", 27 },
            {"приключения", 60 },
            {"тоннели" , 0f},
            {"экстравагантность", 70 },
            {"расчески", 80 }
        };

    static public List<Dictionary<string, float>> plentyLamas = new List<Dictionary<string, float>>()
    {
        plentyLama1,
        plentyLama2,
        plentyLama3, 
        plentyLama4,
        plentyLama5
    };
}
