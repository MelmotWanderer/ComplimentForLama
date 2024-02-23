using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Remark", menuName = "Dialog/Remark", order = 1)]
public class Remark : ScriptableObject
{
    [TextAreaAttribute]
    public string Text;
}
