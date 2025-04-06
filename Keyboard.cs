using Godot;

public static partial class Keyboard {
    public static Vector2 Move() {
        return new() {
            X = (Input.IsKeyPressed(Key.D) ? 1 : 0) - (Input.IsKeyPressed(Key.A) ? 1 : 0),
            Y = (Input.IsKeyPressed(Key.S) ? 1 : 0) - (Input.IsKeyPressed(Key.W) ? 1 : 0),
        };
    }
}
