using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Int")]
public class IntVariable : ScriptableObject
{
    [SerializeField] private int value = default;
    public int Value { get => value; set => this.value = value; }
}