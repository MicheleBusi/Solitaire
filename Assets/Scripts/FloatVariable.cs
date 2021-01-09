using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Float")]
public class FloatVariable : ScriptableObject
{
    [SerializeField] private float value = default;
    public float Value { get => value; set => this.value = value; }
}