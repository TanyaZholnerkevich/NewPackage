using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNamespace
{
   public static class NewPackage
   {
       public static void AddYPosition(this Transform _transform, float _y)
       {
           _transform.position += new Vector3(0, _y*Time.deltaTime, 0);
       } 
    }
}
