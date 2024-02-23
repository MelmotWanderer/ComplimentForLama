using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static   class LamaData 
{
   static public Dictionary<string, float> plentyLama1 = new Dictionary<string, float>()
        {
            { "��������",60 },
            { "������", 74 },
            { "�������", 100 },
            {"���������", 40 },
            {"�����", 30 },
            {"���������", 30 },
            {"����������", 30 },
            {"�����������", 36 },
            {"�������" , 30},
            {"�����������������", 40 },
            {"��������", 30 }

        };
    static public Dictionary<string, float> plentyLama2 = new Dictionary<string, float>()
        {
            { "��������", 30 },
            { "������", 40 },
            { "�������", 30 },
            {"���������", 80 },
            {"�����", 90 },
            {"���������", 30 },
            {"����������", 40 },
            {"�����������", 50 },
            {"�������" , 30},
            {"�����������������", 40 },
            {"��������", 50 }

        };
    static public Dictionary<string, float> plentyLama3 = new Dictionary<string, float>()
        {
            { "��������", 40 },
            { "������", 60 },
            { "�������", 0 },
            {"���������", 35 },
            {"�����", 40 },
            {"���������", 90 },
            {"����������", 36 },
            {"�����������", 40 },
            {"�������" , 32},
            {"�����������������", 40 },
            {"��������", 50 }
        };
    static public Dictionary<string, float> plentyLama4 = new Dictionary<string, float>()
        {
            { "��������", 50 },
            { "������", 50 },
            { "�������", 40 },
            {"���������", 30 },
            {"�����", 40 },
            {"���������", 30 },
            {"����������", 76 },
            {"�����������", 80 },
            {"�������" , 90},
            {"�����������������", 40 },
            {"��������", 50 }
        };
    static public Dictionary<string, float> plentyLama5 = new Dictionary<string, float>()
        {
            { "��������", 40 },
            { "������", 50 },
            { "�������", 50 },
            {"���������", 40 },
            {"�����", 50 },
            {"���������", 40 },
            {"����������", 27 },
            {"�����������", 60 },
            {"�������" , 0f},
            {"�����������������", 70 },
            {"��������", 80 }
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
