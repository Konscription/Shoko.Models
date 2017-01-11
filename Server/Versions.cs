﻿namespace Shoko.Models
{
    public class Versions
    {
        public Versions()
        {
        }
        public int VersionsID { get; private set; }
        public string VersionType { get; set; }
        public string VersionValue { get; set; }
        public string VersionRevision { get; set; }
        public string VersionCommand { get; set; }
        public string VersionProgram { get; set; }
    }
}