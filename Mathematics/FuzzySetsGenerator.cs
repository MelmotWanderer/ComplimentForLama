using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuzzySetsGenerator 
{
    public Dictionary<float, float> Triangle_FS(float a, float b, float c, float d, float h)
    {
        Dictionary<float, float> Mu = new Dictionary<float, float>();
        for (int i = 0; i < 101; i++)
        {
            Mu.Add(i, 0);
        }
        if (a > 0)
        {
            for (int i = 0; i < 101; i++)
            {
                if (i <= a)
                {
                    Mu[i] = 0;

                }
            }
        }
        if (c < 100)
        {
            for (int i = 0; i < 101; i++)
            {
                float r = 0;
                float z = Mu[i];
                if (i >= c)
                {
                    if (r > z)
                    {
                        Mu[i] = r;
                    }
                    else
                    {
                        Mu[i] = z;
                    }

                }
            }
        }
        if (a < b)
        {
            for (int i = 0; i < 101; i++)
            {
                if (i >= a && i <= b)
                {
                    float r = h * (float)(i - a) / (b - a);
                    float z = Mu[i];
                    if (z < r) { Mu[i] = r; }
                    else { Mu[i] = z; }
                }
            }
        }
        if (b < d)
        {
            for (int i = 0; i < 101; i++)
            {
                if (i >= b && i <= d)
                {
                    float r = h;
                    float z = Mu[i];
                    if (r > z) { Mu[i] = r; } else { Mu[i] = z; }
                }
            }
        }
        if (d < c)
        {
            for (int i = 0; i < 101; i++)
            {
                if (i >= d && i <= c)
                {
                    float r = h * (float)(c - i) / (c - d);
                    float z = Mu[i];
                    if (z < r) { Mu[i] = r; }
                    else { Mu[i] = z; }
                }
            }
        }
        return Mu;
    }

   
}
