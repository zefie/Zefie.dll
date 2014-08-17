﻿using System.IO;

namespace Zefie
{
    public class Path
    {
        /// <summary>
        /// Finds the drive letter of the drive with the specified label
        /// </summary>
        /// <param name="label">Label of the drive to search for (case sensitive)</param>
        /// <returns>Drive letter in format of X:\, or null if no results</returns>
        public static string getDriveLetterFromLabel(string label)
        {
            foreach (DriveInfo DI in DriveInfo.GetDrives())
            {
                try
                {
                    if (DI.VolumeLabel.Length > 0)
                    {
                        if (DI.VolumeLabel == label)
                        {
                            return DI.Name;
                        }
                    }
                }
                catch { }
            }
            return null;
        }
    }
}
