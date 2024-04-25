using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameNetty
{
    [AsyncMethodBuilder(typeof(AsyncGameVoidMethodBuilder))]
    [StructLayout(LayoutKind.Auto)]
    internal struct GameVoid : ICriticalNotifyCompletion
    {
        [DebuggerHidden]
        public void Coroutine()
        {
            
        }
        
        [DebuggerHidden]
        public void OnCompleted(Action continuation)
        {
            
        }
        
        [DebuggerHidden]
        public void UnsafeOnCompleted(Action continuation)
        {
            
        }
    }
}