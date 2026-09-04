// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Microsoft.ClearScript.V8
{
    /// <summary>
    /// Defines <see href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise">promise</see> lifecycle event kinds.
    /// </summary>
    public enum V8PromiseEventKind
    {
        // IMPORTANT: maintain bitwise equivalence with unmanaged enum V8Context::PromiseEventKind

        /// <summary>
        /// Indicates that a promise was created.
        /// </summary>
        Created,
        
        /// <summary>
        /// Indicates that a promise was resolved or rejected.
        /// </summary>
        Settled,
        
        /// <summary>
        /// Indicates that a promise reaction job is about to run.
        /// </summary>
        BeforeReaction,
        
        /// <summary>
        /// Indicates that a promise reaction job has finished running.
        /// </summary>
        AfterReaction
    }

    /// <summary>
    /// Represents a callback for <see href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise">promise</see> lifecycle events.
    /// </summary>
    /// <param name="kind">The promise event that occurred.</param>
    /// <param name="promise">The promise for which the event occurred.</param>
    /// <param name="parent">The parent promise if applicable, <c>null</c> otherwise (see remarks).</param>
    /// <remarks>
    /// When a promise is created as part of a chain, the callback is invoked with
    /// <paramref name="kind"/> set to <c><see cref="V8PromiseEventKind.Created"/></c> and
    /// <paramref name="parent"/> set to the parent promise. In all other situations,
    /// <paramref name="parent"/> is set to <c>null</c>.
    /// </remarks>
    public delegate void V8PromiseHook(V8PromiseEventKind kind, ScriptObject promise, ScriptObject parent);
}
