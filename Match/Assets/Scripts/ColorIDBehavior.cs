using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDDataList colorIDDataListobj;

    private void Awake()
    {
        idObj = colorIDDataListobj.curentColor;
    }
}
