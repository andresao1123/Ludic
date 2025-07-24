using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CorrectAdjacent", menuName = "ContentType/Adjacent", order = 1)]

public class CorrectAdjacentSO : ScriptableObject
{
    [SerializeField]
    public Dictionary<string,List<string>> CorrectAdjacents = new Dictionary<string,List<string>>();
}
