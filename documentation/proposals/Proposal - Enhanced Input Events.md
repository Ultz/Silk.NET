# Summary
Proposal for adding important missing functionality to input, as well as other enhancements.

# Contributors
- ThomasMiz

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- Event parameters will be turned into readonly structures to prevent long parameter lists in some cases and allow more parameters (such as deltas) to be added in the future without breaking.

# Proposed API
The only API changes will be to the events presented by IMouse, IKeyboard and possibly other device interfaces.

## Enums

#### KeyModifiers
Based on [the modifier keys flag from GLFW](https://www.glfw.org/docs/latest/group__mods.html).
```cs
[Flags]
public enum KeyModifiers
{
    Shift = 1 << 0,
    Control = 1 << 1,
    Alt = 1 << 2,
    Super = 1 << 3,
    CapsLock = 1 << 4,
    NumLock = 1 << 5
}
```

## Structs

#### KeyDownEvent
```cs
public readonly struct KeyDownEvent
{
    public IKeyboard Keyboard { get; }
    public Key Key { get; }
    public int KeyCode { get; }
    public KeyModifiers Modifiers { get; }
    public bool IsRepeat { get; }
    
    public KeyDownEvent(IKeyboard keyboard, Key key, int keyCode, KeyModifiers modifiers, bool isRepeat);
}
```

#### KeyUpEvent
```cs
public readonly struct KeyUpEvent
{
    public IKeyboard Keyboard { get; }
    public Key Key { get; }
    public int KeyCode { get; }
    public KeyModifiers Modifiers { get; }
    
    public KeyUpEvent(IKeyboard keyboard, Key key, int keyCode, KeyModifiers modifiers);
}
```

#### KeyCharEvent
```cs
public readonly struct KeyCharEvent
{
    public IKeyboard Keyboard { get; }
    public char Character { get; }
    public int KeyCode { get; }
    
    public KeyCharEvent(IKeyboard keyboard, char character, int keyCode);
}
```

#### MouseMoveEvent
```cs
public readonly struct MouseMoveEvent
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    public Vector2 Delta { get; }
    
    public MouseMoveEvent(IMouse mouse, Vector2 position, Vector2 delta);
}
```

#### MouseButtonEvent
```cs
public readonly struct MouseButtonEvent
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    public MouseButton Button { get; }
    public KeyModifiers Modifiers { get; }
    
    public MouseButtonEvent(IMouse mouse, Vector2 position, MouseButton button, KeyModifiers modifiers);
}
```

#### MouseScrollEvent
```cs
public readonly struct MouseScrollEvent
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    public Vector2 WheelPosition { get; }
    public Vector2 Delta { get; }
    
    public MouseScrollEvent(IMouse mouse, Vector2 position, Vector2 wheelPosition, Vector2 delta);
}
```

#### MouseClickEvent
```cs
public readonly struct MouseClickEvent
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    public MouseButton Button { get; }
    public KeyModifiers Modifiers { get; }
    
    public MouseClickEvent(IMouse mouse, Vector2 position, MouseButton button, KeyModifiers modifiers)
}
```

## Interface changes

#### IKeyboard
```cs
public interface IKeyboard : IInputDevice
{
    // The old events get removed:
    // event Action<IKeyboard, Key> KeyDown;
    // event Action<IKeyboard, Key> KeyUp;
    // event Action<IKeyboard, char> KeyChar;
    
    // KeyDown reports key down and key repeats
    event Action<KeyDownEvent> KeyDown;
    event Action<KeyUpEvent> KeyUp;
    
    event Action<KeyCharEvent> KeyChar;
}
```

#### IMouse
```cs
public interface IMouse : IInputDevice
{
    // The old events get removed:
    // event Action<IMouse, Vector2> MouseMove;
    // event Action<IMouse, MouseButton> MouseDown;
    // event Action<IMouse, MouseButton> MouseUp;
    // event Action<IMouse, ScrollWheel> Scroll;
    // event Action<IMouse, MouseButton, Vector2> Click;
    // event Action<IMouse, MouseButton, Vector2> DoubleClick;
    
    event Action<MouseMoveEvent> MouseMove;
    event Action<MouseButtonEvent> MouseDown;
    event Action<MouseButtonEvent> MouseUp;
    event Action<MouseScrollEvent> Scroll;
    event Action<MouseClickEvent> Click;
    event Action<MouseClickEvent> DoubleClick;
}
```

These changes can also be applied to other IDevices to keep consistency across our API.
