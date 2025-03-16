// Copyright 2025 Broken Rock Studios LLC. All Rights Reserved.
// See the LICENSE file for details.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "ExampleBaseActor.generated.h"

UCLASS()
class ROCKEVENTSEXAMPLE_API AExampleBaseActor : public AActor
{
	GENERATED_BODY()

public:
	AExampleBaseActor();

protected:
	virtual void BeginPlay() override;

public:
	virtual void Tick(float DeltaTime) override;
};
