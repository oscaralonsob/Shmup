using Godot;

public abstract partial class MovementInput: Resource
{
	public abstract Vector2 MovementVector(CharacterBody2D character);
}
