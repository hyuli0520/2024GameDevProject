using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Type", menuName = "SO/Type")]
public class Type : ScriptableObject
{
    public string typeName;
    public Type weakType;
    public Type strongType;
}
