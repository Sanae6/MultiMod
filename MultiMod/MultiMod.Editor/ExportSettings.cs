﻿using UnityEngine;

namespace MultiMod.Editor
{
    /// <summary>
    ///     Stores the exporter's settings.
    /// </summary>
    public class ExportSettings : EditorScriptableSingleton<ExportSettings>
    {
        [SerializeField] private string _author;

        [SerializeField] private string _description;

        [SerializeField] private string _name;

        [SerializeField] private string _outputDirectory;

        [SerializeField] private string _version;

        /// <summary>
        ///     The Mod's name.
        /// </summary>
        public new string name => _name;

        /// <summary>
        ///     The Mod's author.
        /// </summary>
        public string author => _author;

        /// <summary>
        ///     The Mod's description.
        /// </summary>
        public string description => _description;

        /// <summary>
        ///     The Mod's version.
        /// </summary>
        public string version => _version;

        /// <summary>
        ///     The directory to which the Mod will be exported.
        /// </summary>
        public string outputDirectory => _outputDirectory;
    }
}