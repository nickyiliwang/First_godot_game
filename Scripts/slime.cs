using Godot;
using System;

public partial class slime : Node2D
{
	float speed = 60;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 position = this.Position;

		position.X = speed * (float)delta;
		
	}
}
