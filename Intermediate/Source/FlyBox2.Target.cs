using UnrealBuildTool;

public class FlyBox2Target : TargetRules
{
	public FlyBox2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FlyBox2");
	}
}
