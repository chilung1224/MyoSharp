﻿using System;
using System.Collections.Generic;
using System.Text;

using MyoSharp.Device;

namespace MyoSharp.Communication
{
    /// <summary>
    /// A class that contains information about an event for routing Myo events.
    /// </summary>
    public class RouteMyoEventArgs : EventArgs
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteMyoEventArgs"/> class.
        /// </summary>
        /// <param name="myoHandle">The Myo handle.</param>
        /// <param name="evt">The event handle.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="timestamp">The timestamp of the event.</param>
        /// <exception cref="ArgumentException">
        /// The exception that is thrown when <paramref name="myoHandle"/> or <paramref name="evt"/> are <see cref="IntPtr.Zero"/>.
        /// </exception>
        public RouteMyoEventArgs(
            IntPtr myoHandle, 
            IntPtr evt, 
            MyoEventType eventType, 
            DateTime timestamp)
        {
            if (myoHandle == IntPtr.Zero)
            {
                throw new ArgumentException("The handle to the Myo must be set.", "myoHandle");
            }

            if (evt == IntPtr.Zero)
            {
                throw new ArgumentException("The handle to the event must be set.", "evt");
            }

            this.MyoHandle = myoHandle;
            this.Event = evt;
            this.EventType = eventType;
            this.Timestamp = timestamp;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the Myo handle.
        /// </summary>
        public IntPtr MyoHandle { get; private set; }

        /// <summary>
        /// Gets the event handle.
        /// </summary>
        public IntPtr Event { get; private set; }

        /// <summary>
        /// Gets the type of the event.
        /// </summary>
        public MyoEventType EventType { get; private set; }

        /// <summary>
        /// Gets the timestamp of the event.
        /// </summary>
        public DateTime Timestamp { get; private set; }
        #endregion
    }
}
