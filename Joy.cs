using Godot;

public static partial class Joy {
    public static Vector2 Move() {
        return new() {
            X = Input.GetJoyAxis(0, JoyAxis.LeftX),
            Y = Input.GetJoyAxis(0, JoyAxis.LeftY),
        };
    }
}
