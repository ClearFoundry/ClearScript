// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Microsoft.ClearScript.V8
{
    /// <summary>
    /// Defines <see href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise">promise</see> rejection event kinds.
    /// </summary>
    public enum V8PromiseRejectionEventKind
    {
        // IMPORTANT: maintain bitwise equivalence with unmanaged enum V8Context::PromiseRejectionEventKind

        /// <summary>
        /// Indicates that a promise was rejected without a handler.
        /// </summary>
        RejectedWithoutHandler,
        
        /// <summary>
        /// Indicates that a handler was added for a previously rejected promise.
        /// </summary>
        HandlerAddedAfterRejection,
        
        /// <summary>
        /// Indicates that a settled promise was subsequently rejected.
        /// </summary>
        RejectedAfterSettlement,
        
        /// <summary>
        /// Indicates that a settled promise was subsequently resolved.
        /// </summary>
        ResolvedAfterSettlement
    }

    /// <summary>
    /// Represents a callback for <see href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise">promise</see> rejection events.
    /// </summary>
    /// <param name="kind">The promise rejection event that occurred.</param>
    /// <param name="promise">The promise for which the rejection event occurred.</param>
    /// <param name="value">The value associated with the rejection event if applicable, <c>null</c> otherwise (see remarks).</param>
    /// <remarks>
    /// For unhandled rejection, <paramref name="value"/> is the rejection reason. For an attempt
    /// to settle a previously settled promise, it is the ignored settlement value.
    /// </remarks>
    public delegate void V8PromiseRejectionCallback(V8PromiseRejectionEventKind kind, ScriptObject promise, object value);
}
