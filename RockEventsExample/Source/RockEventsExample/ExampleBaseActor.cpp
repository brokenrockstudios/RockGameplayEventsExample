// Copyright Broken Rock Studios LLC. All Rights Reserved.
// See the LICENSE file for details.

#include "ExampleBaseActor.h"

AExampleBaseActor::AExampleBaseActor()
{
	PrimaryActorTick.bCanEverTick = true;
}

void AExampleBaseActor::BeginPlay()
{
	Super::BeginPlay();
}

void AExampleBaseActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}
