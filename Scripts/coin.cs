using Godot;
using System;

public partial class coin : Area2D
{
    private void OnBodyEntered(Node body)
    {
        GD.Print("+1 coin", body);
        QueueFree();
    }
}
