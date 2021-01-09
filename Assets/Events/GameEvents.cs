using UnityEngine;
using UnityEngine.Events;

public struct VoidArgs { };
[CreateAssetMenu(menuName = "Game Events/Void")]
public class VoidEvent : BaseGameEvent<VoidArgs> { public void Raise() => Raise(new VoidArgs()); }
public class VoidEventListener : BaseGameEventListener<VoidArgs, VoidEvent, UnityVoidEvent> { }
[System.Serializable] public class UnityVoidEvent : UnityEvent<VoidArgs> { }



[CreateAssetMenu(menuName = "Game Events/Int")]
public class IntEvent : BaseGameEvent<int> { }
public class IntEventListener : BaseGameEventListener<int, IntEvent, UnityIntEvent> { }
[System.Serializable] public class UnityIntEvent : UnityEvent<int> { }



[CreateAssetMenu(menuName = "Game Events/Float")]
public class FloatEvent : BaseGameEvent<float> { }
public class FloatEventListener : BaseGameEventListener<float, FloatEvent, UnityFloatEvent> { }
[System.Serializable] public class UnityFloatEvent : UnityEvent<float> { }



[CreateAssetMenu(menuName = "Game Events/String")]
public class StringEvent : BaseGameEvent<string> { }
public class StringEventListener : BaseGameEventListener<string, StringEvent, UnityStringEvent> { }
[System.Serializable] public class UnityStringEvent : UnityEvent<string> { }



public struct StringFloatArgs
{
    string s;
    float f;
};
[CreateAssetMenu(menuName = "Game Events/StringFloat")]
public class StringFloatEvent : BaseGameEvent<StringFloatArgs> { }
public class StringFloatEventListener : BaseGameEventListener<StringFloatArgs, StringFloatEvent, UnityStringFloatEvent> { }
[System.Serializable] public class UnityStringFloatEvent : UnityEvent<StringFloatArgs> { }

