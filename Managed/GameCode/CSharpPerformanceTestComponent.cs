using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnrealEngine.Runtime;
using UnrealEngine.Engine;

namespace HelloUSharp
{
    [UClass, Blueprintable, BlueprintType]
    class CSharpPerformanceTestComponent : UActorComponent
    {
        [UFunction, BlueprintCallable]
        public float GetTotalSum(float N)
        {
            float result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += SumN(i);
            }
            return result;
        }

        [UFunction, BlueprintCallable]
        public float SumN(float n)
        {
            float _temp = 0;
            for (int i = 1; i <= n; i++)
            {
                _temp += i;
            }
            return _temp;
        }

        [UFunction, BlueprintCallable]
        public float GetTotalSumFromOwner(float N)
        {
            float result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += GetOwnerSumNTest(i);
            }
            return result;
        }

        [UFunction, BlueprintCallable]
        public float GetOwnerSumNTest(float n)
        {
            float _temp = 0;
            for (int i = 1; i <= n; i++)
            {
                _temp += GetOwner().GetActorLocation().X;
            }
            return _temp;
        }

        AActor myOwner;
        [UFunction, BlueprintCallable]
        public float GetTotalSumFromCachedOwner(float N)
        {
            myOwner = GetOwner();
            float result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += CacheOwnerSumNTest(i);
            }
            return result;
        }

        [UFunction, BlueprintCallable]
        public float CacheOwnerSumNTest(float n)
        {
            float _temp = 0;
            for (int i = 1; i <= n; i++)
            {
                _temp += myOwner.GetActorLocation().X;
            }
            return _temp;
        }
    }
}
