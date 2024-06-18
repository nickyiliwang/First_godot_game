using Godot;
using System;

public partial class kill_zone : Area2D
{
    public override void _Ready() { }

    private void OnBodyEntered(Node body)
    {
        GD.Print("You died !");

        var timer = GetNode<Timer>("Timer");
        timer.Start();
        GetTree().ReloadCurrentScene();
    }
}
