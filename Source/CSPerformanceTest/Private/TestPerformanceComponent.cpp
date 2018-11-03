// Fill out your copyright notice in the Description page of Project Settings.

#include "TestPerformanceComponent.h"


// Sets default values for this component's properties
UTestPerformanceComponent::UTestPerformanceComponent()
{
	// Set this component to be initialized when the game starts, and to be ticked every frame.  You can turn these features
	// off to improve performance if you don't need them.
	PrimaryComponentTick.bCanEverTick = true;

	// ...
}


// Called when the game starts
void UTestPerformanceComponent::BeginPlay()
{
	Super::BeginPlay();

	// ...
	
}


// Called every frame
void UTestPerformanceComponent::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);

	// ...
}

float UTestPerformanceComponent::GetTotalSum(float N) 
{
	float result = 0;
	for (int i = 1; i <= N; i++)
	{
		result += SumN(i);
	}
	return result;
}

float UTestPerformanceComponent::SumN(float n) 
{
	float _temp = 0;
	for (int i = 1; i <= n; i++)
	{
		_temp += i;
	}
	return _temp;
}

float UTestPerformanceComponent::GetTotalSumFromOwner(float N)
{
	float result = 0;
	for (int i = 1; i <= N; i++)
	{
		result += GetOwnerSumNTest(i);
	}
	return result;
}

float UTestPerformanceComponent::GetOwnerSumNTest(float n)
{
	float _temp = 0;
	for (int i = 1; i <= n; i++)
	{
		_temp += GetOwner()->GetActorLocation().X;
	}
	return _temp;
}