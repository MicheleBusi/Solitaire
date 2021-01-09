using UnityEngine;

[CreateAssetMenu(menuName = "Variables/String")]
public class StringVariable : ScriptableObject
{
    [SerializeField] private string value = default;
    public string Value { get => value; set => this.value = value; }
}