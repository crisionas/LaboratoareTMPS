using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Labs.Singletone
{
    static class RandomUtil
    {
        /// <summary>
        /// Get random string of 11 characters.
        /// </summary>
        /// <returns>Random string.</returns>
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.
            return path;
        }
    }
}
