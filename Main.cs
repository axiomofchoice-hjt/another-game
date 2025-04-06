using Godot;
using System;

public partial class Main : Node2D {
    Sprite2D sprite;
    Sprite2D green;

    public override void _Ready() {
        var texture = (Texture2D)GD.Load("res://icon.svg");
        sprite = new Sprite2D {
            Texture = texture,
            Position = new Vector2(0, 0)
        };
        AddChild(sprite);
        var texture1 = (Texture2D)GD.Load("res://green.png");
        green = new Sprite2D {
            Texture = texture1,
            Position = new Vector2(0, 0)
        };
        AddChild(green);
    }

    public override void _Process(double delta) {
        // 控制 sprite 移动
        var velocity = Joy.Move() + Keyboard.Move();
        if (velocity.Length() > 0.2f) {
            if (velocity.Length() > 1f) {
                velocity = velocity.Normalized();
            }
            sprite.Position += velocity * 1000 * (float)delta;
        }
        if (Input.IsMouseButtonPressed(MouseButton.Left)) {
            green.Position = GetGlobalMousePosition();
        }
    }
}
