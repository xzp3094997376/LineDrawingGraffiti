using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BoundsTest : MonoBehaviour
{
    Bounds bd;
    SpriteRenderer spr;
    // Start is called before the first frame update
    void Start()
    {
        bd = GetComponent<MeshRenderer>().bounds;//bounds就是模型包围盒的大小
        //spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Start();
        Debug.Log(bd.size+"  update");
        //Debug.Log(spr.bounds.size+ "  update "+ " size= "+spr.sprite.rect.width);

    }
}
