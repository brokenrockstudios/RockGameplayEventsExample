// Copyright 2025 Broken Rock Studios LLC. All Rights Reserved.
// See the LICENSE file for details.

using UnrealBuildTool;
using System.Collections.Generic;

public class RockEventsExampleTarget : TargetRules
{
	public RockEventsExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange(
			[
				"RockEventsExample"
			]
		);
	}
}