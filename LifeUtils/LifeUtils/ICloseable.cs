﻿#region Header

// 
//        LifeUtils - LifeUtils - ICloseable.cs
//                  24.10.2018 03:24

#endregion

namespace LifeUtils
{
    /// <summary>
    ///     Represents a closeable object.
    /// </summary>
    public interface ICloseable
    {
        /// <summary>
        ///     Closes this object.
        /// </summary>
        void Close();
    }

    /// <summary>
    ///     Represents a closeable object that returns a value after closing.
    /// </summary>
    /// <typeparam name="T">The returned values type.</typeparam>
    public interface ICloseable<out T>
    {
        /// <summary>
        ///     Closes this object.
        /// </summary>
        /// <returns>The result of the termination.</returns>
        T Close();
    }
}