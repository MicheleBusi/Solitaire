using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Bool")]
public class BoolVariable : ScriptableObject
{
    [SerializeField] bool value = default;
    public bool Value { get => value; set => this.value = value; }
}