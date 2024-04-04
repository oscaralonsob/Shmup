using Godot;

public abstract partial class DirectionInput: Resource
{
	public abstract Vector2 DirectionVector(CharacterBody2D character);
}
