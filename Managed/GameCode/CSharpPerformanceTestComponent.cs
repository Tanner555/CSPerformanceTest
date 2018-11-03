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
            for (int i = 1; i < N; i++)
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
                _temp += 1;
            }
            return _temp;
        }
    }
}
