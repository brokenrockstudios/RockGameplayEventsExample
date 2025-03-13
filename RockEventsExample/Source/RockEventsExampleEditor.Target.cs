// Copyright Broken Rock Studios LLC. All Rights Reserved.
// See the LICENSE file for details.

using UnrealBuildTool;
using System.Collections.Generic;

public class RockEventsExampleEditorTarget : TargetRules
{
	public RockEventsExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange(
			[
				"RockEventsExample"
			]
		);
	}
}