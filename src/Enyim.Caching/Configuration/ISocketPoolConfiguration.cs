using System;
using Enyim.Caching.Memcached;

namespace Enyim.Caching.Configuration
{
    /// <summary>
    /// Defines an interface for configuring the socket pool for the <see cref="T:MemcachedClient"/>.
    /// </summary>
    public interface ISocketPoolConfiguration
    {
        /// <summary>
        /// Gets or sets a value indicating the minimum amount of sockets per server in the socket pool.
        /// </summary>
        /// <returns>The minimum amount of sockets per server in the socket pool.</returns>
        int MinPoolSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the maximum amount of sockets per server in the socket pool.
        /// </summary>
        /// <returns>The maximum amount of sockets per server in the socket pool.</returns>
        int MaxPoolSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that specifies the amount of time after which the connection attempt will fail.
        /// </summary>
        /// <returns>The value of the connection timeout.</returns>
        TimeSpan ConnectionTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that specifies the amount of time after which the getting a connection from the pool will fail.
        /// </summary>
        /// <returns>The value of the queue timeout.</returns>
        TimeSpan QueueTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that specifies the amount of time after which receiving data from the socket will fail.
        /// </summary>
        /// <returns>The value of the receive timeout.</returns>
        TimeSpan ReceiveTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that specifies the amount of time after which an unresponsive (dead) server will be checked if it is working.
        /// </summary>
        /// <returns>The value of the dead timeout.</returns>
        TimeSpan DeadTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the number of seconds that the socket will linger after Close is called if LingerEnabled is true
        /// </summary>
        TimeSpan LingerTime { get; set; }

        /// <summary>
        /// If true sets the LingerOptions on a socket to the value specified by the LingerTime property.
        /// </summary>
        bool LingerEnabled { get; set; }

        INodeFailurePolicyFactory FailurePolicyFactory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether enable TCP keep alives.
        /// </summary>
        /// <value>
        /// <c>true</c> to enable TCP keep alives; otherwise, <c>false</c>.
        /// </value>
        bool EnableTcpKeepAlives { get; set; }

        /// <summary>
        /// Specifies the timeout, in milliseconds, with no activity until the first keep-alive packet is sent.
        /// </summary>
        /// <value>
        /// The TCP keep alive time in milliseconds.
        /// </value>
        /// <remarks>The default is 2hrs.</remarks>
        uint TcpKeepAliveTime { get; set; }

        /// <summary>
        /// Specifies the interval, in milliseconds, between when successive keep-alive packets are sent if no acknowledgement is received.
        /// </summary>
        /// <value>
        /// The TCP keep alive interval in milliseconds..
        /// </value>
        /// <remarks>The default is 1 second.</remarks>
        uint TcpKeepAliveInterval { get; set; }
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    Copyright (c) 2010 Attila Kisk�, enyim.com
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion