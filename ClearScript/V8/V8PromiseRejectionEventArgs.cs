// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Microsoft.ClearScript.V8
{
    /// <summary>
    /// Identifies a V8 promise rejection lifecycle operation.
    /// </summary>
    public enum V8PromiseRejectionOperation
    {
        /// <summary>
        /// A promise was rejected without a handler.
        /// </summary>
        RejectWithNoHandler,

        /// <summary>
        /// A handler was added to a previously rejected promise.
        /// </summary>
        HandlerAddedAfterReject
    }

    /// <summary>
    /// Provides data for V8 promise rejection lifecycle notifications.
    /// </summary>
    public sealed class V8PromiseRejectionEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the promise rejection lifecycle operation.
        /// </summary>
        public V8PromiseRejectionOperation Operation { get; }

        /// <summary>
        /// Gets the original JavaScript promise.
        /// </summary>
        public ScriptObject Promise { get; }

        /// <summary>
        /// Gets the promise rejection reason. This value can be any JavaScript value.
        /// </summary>
        public object Reason { get; }

        internal V8PromiseRejectionEventArgs(V8PromiseRejectionOperation operation, ScriptObject promise, object reason)
        {
            Operation = operation;
            Promise = promise;
            Reason = reason;
        }
    }
}
