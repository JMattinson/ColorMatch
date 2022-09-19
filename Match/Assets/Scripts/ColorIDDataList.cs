using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;
    
    public ColorID curentColor;

    private int num;

    public void SetCurrentColorRandomly()
    {
        num = UnityEngine.Random.Range(0, colorIDList.Capacity);
        
        curentColor = colorIDList[num];
        
    }

}

