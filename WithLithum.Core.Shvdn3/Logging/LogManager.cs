using System;
using System.IO;
using GTA;

namespace WithLithum.Core.Logging
{
    /// <summary>
    /// Provides utilties to manipulate and manage <see cref="Logger"/>s.
    /// </summary>
    /// <remarks>
    /// Patterns are made of pattern placeholders. Below is a list of all placeholders available:
    /// <list type="bullet">
    ///     <item>{time} - current time in current culture</item>
    ///     <item>{timeutc} - current time in UTC</item>
    ///     <item>{newline} - <see cref="Environment.NewLine"/></item>
    ///     <item>{message} - the actual message</item>
    ///     <item>{name} - the name of the logger</item>
    ///     <item>{level} - the log level</item>
    ///     <item>{owner} - the owner of the logger</item>
    ///     <item>{master} - the masterowner of the logger</item>
    /// </list>
    /// </remarks>
    public class LogManager
    {
        private readonly Script _ownerScript;
        private readonly string _fileName;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogManager"/> class.
        /// </summary>
        /// <param name="fileName">The name of the file to log.</param>
        /// <param name="script">The script.</param>
        public LogManager(string fileName, Script script)
        {
            // Check file name
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("File name is either null, empty or white space.", nameof(fileName));
            }

            _fileName = fileName;
            _ownerScript = script ?? throw new ArgumentNullException(nameof(fileName));

            // Add header timestamp
            File.WriteAllText(fileName, "Log started: " + DateTime.Now);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogManager"/> class.
        /// </summary>
        /// <param name="fileName">The name of the file to log.</param>
        /// <param name="script">The script.</param>
        /// <param name="pattern">The pattern.</param>
        public LogManager(string fileName, Script script, string pattern) : this(fileName, script)
        {
            Pattern = pattern;
        }

        /// <summary>
        /// Gets or sets the pattern of this instance.
        /// </summary>
        public string Pattern { get; set; } = "[{time}] [{name}/{lvl}] {message} {newline}";

        /// <summary>
        /// Creates a new <see cref="Logger"/> owned by the master script.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>An instance of <see cref="Logger"/>.</returns>
        public Logger GetLogger(string name)
        {
            return new Logger(name, _fileName, _ownerScript, _ownerScript, this);
        }

        /// <summary>
        /// Creates a new <see cref="Logger"/> owned by the specified script.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <returns>An instance of <see cref="Logger"/>.</returns>
        public Logger GetLogger(string name, Script owner)
        {
            return new Logger(name, _fileName, owner, _ownerScript, this);
        }
    }
}
