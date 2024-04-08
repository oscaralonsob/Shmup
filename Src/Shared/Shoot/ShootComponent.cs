using Godot;

public partial class ShootComponent : Node2D
{
	[Export]
	private ShootInput ShootInput { set; get; }
	[Export]
	private PackedScene BulletScene { set; get; }
	[Export]
	private Timer Timer { set; get; }
	private bool InCd { set; get; } = false;
	//TODO: resource
	private	int CdTime = 5;

	public override void _Process(double delta) {
		Shoot();
	}

	private void Shoot() {
		if (ShootInput.ShootKey() && CanShoot()) {
			PutInCd();
			SpawnBullet();
		}
	}

	private void TimeOut() {
		InCd = false;
	}

	private bool CanShoot() {
		return !InCd;
	}

	private void PutInCd() {
		InCd = true;
		Timer.Start(CdTime);
	}

	private void SpawnBullet() {
		CharacterBody2D playerBulletMovementComponent = BulletScene.Instantiate<CharacterBody2D>();
		GetTree().Root.AddChild(playerBulletMovementComponent);
		playerBulletMovementComponent.Position = GlobalPosition;
		playerBulletMovementComponent.GlobalRotation = GlobalRotation;
	}
}
