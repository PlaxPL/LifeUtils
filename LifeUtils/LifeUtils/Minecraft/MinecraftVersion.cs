﻿#region Header

// 
//        LifeUtils - LifeUtils - MinecraftVersion.cs
//                  24.10.2018 03:24

#endregion

namespace LifeUtils.Minecraft
{
    /// <summary>
    ///     A static class contains standard, supported minecraft versions.
    /// </summary>
    //TODO Also update this in every minecraft release.
    public static class MinecraftVersion
    {
        /// <summary>
        ///     The legacy 1.7.10 version of Minecraft.
        /// </summary>
        public static readonly Version _1_7_10 =
            new Version(1, 7, 10);

        /// <summary>
        ///     The popular 1.8.8 version of Minecraft.
        /// </summary>
        public static readonly Version _1_8_8 =
            new Version(1, 8, 8);

        /// <summary>
        ///     The (also popular) last stable 1.12.2 version of Minecraft.
        /// </summary>
        public static readonly Version _1_12_2 =
            new Version(1, 12, 2);

        /// <summary>
        ///     The most recent 1.13.2 version of the Minecraft.
        /// </summary>
        public static readonly Version _1_13_2 =
            new Version(1, 13, 2);

        /// <summary>
        ///     Returns a version matches the given version string.
        /// </summary>
        /// <param name="versionString">The version string to parse.</param>
        /// <returns>A version matches the given version string.</returns>
        public static Version From(string versionString) => new Version(versionString);

        /// <summary>
        ///     Returns a version with pre configured major, minor and revision values.
        /// </summary>
        /// <param name="major">The major version of the version, e.g: 1 for 1.12.2.</param>
        /// <param name="minor">The minor version of the version, e.g: 12 for 1.12.2.</param>
        /// <param name="revision">The revision number of the version, e.g: 2 for 1.12.2.</param>
        /// <returns></returns>
        public static Version From(int major, int minor, int revision) => new Version(major, minor, revision);
    }
}