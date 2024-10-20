// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnrealArcProject : ModuleRules
{
	public UnrealArcProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "NavigationSystem", "AIModule", "Niagara", "EnhancedInput" });
    }
}
