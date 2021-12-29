using System;
using System.IO;
using GTA;

namespace WithLithum.Core.Logging
{
    /// <summary>
    /// Provides logging features to GTA scripts.
    /// </summary>
    /// <remarks>
    /// Logger instances are created by <see cref="LogManager"/>.
    /// </remarks>
    public class Logger
    {
        private readonly Script _owner;
        private readonly Script _master;
        private readonly string _targetFile;
        private readonly LogManager _manager;

        /// <summary>
        /// The text for trace level.
        /// </summary>
        public const string TraceLevel = "TRACE";

        /// <summary>
        /// The text for debug level.
        /// </summary>
        public const string DebugLevel = "DEBUG";
        
        /// <summary>
        /// The text for information level.
        /// </summary>
        public const string InformationLevel = "INFO";

        /// <summary>
        /// The text for warning level.
        /// </summary>
        public const string WarningLevel = "WARN";
        
        /// <summary>
        /// The text for error level.
        /// </summary>
        public const string ErrorLevel = "ERROR";

        /// <summary>
        /// The text for fatal level.
        /// </summary>
        public const string FatalLevel = "FATAL";

        internal Logger(string name, string fileName, Script ownerScript, Script masterScript, LogManager manager)
        {
            Name = name;
            _owner = ownerScript;
            _targetFile = fileName;
            _master = masterScript;
            _manager = manager;
        }

        /// <summary>
        /// Gets the name of this <see cref="Logger"/>.
        /// </summary>
        /// <value>
        /// The name of this instance.
        /// </value>
        public string Name { get; }

        /// <summary>
        /// Logs the specified information into the log file.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="level">The level.</param>
        public void Log(string text, string level)
        {
            File.AppendAllText(_targetFile, ParseFromPattern(text, level));
        }

        private string ParseFromPattern(string text, string level)
        {
            var result = _manager.Pattern;
            result = result.Replace("{time}", DateTime.Now.ToString());
            result = result.Replace("{timeutc}", DateTime.UtcNow.ToString());
            result = result.Replace("{newline}", Environment.NewLine);
            result = result.Replace("{message}", text);
            result = result.Replace("{name}", Name);
            result = result.Replace("{level}", level);
            result = result.Replace("{owner}", _owner.ToString());
            result = result.Replace("{master}", _master.ToString());
            return result;
        }

        /// <summary>
        /// Logs the specified text, with level specified as <see cref="TraceLevel"/>.
        /// </summary>
        /// <param name="text">The text to log.</param>
        public void Trace(string text) => Log(text, TraceLevel);

        /// <summary>
        /// Logs the specified exception, with the level specified as <see cref="TraceLevel"/>.
        /// </summary>
        /// <param name="ex">The exception to log.</param>
        public void Trace(Exception ex) => Log(ex.ToString(), TraceLevel);

        /// <summary>
        /// Logs the specified object, with the level specified as <see cref="TraceLevel"/>.
        /// </summary>
        /// <param name="obj">The obj to log.</param>
        public void Trace(object obj) => Log(obj.ToString(), TraceLevel);

        /// <summary>
        /// Logs the specified text, with level specified as <see cref="DebugLevel"/>.
        /// </summary>
        /// <param name="text">The text to log.</param>
        public void Debug(string text) => Log(text, DebugLevel);

        /// <summary>
        /// Logs the specified exception, with the level specified as <see cref="DebugLevel"/>.
        /// </summary>
        /// <param name="ex">The exception to log.</param>
        public void Debug(Exception ex) => Log(ex.ToString(), DebugLevel);

        /// <summary>
        /// Logs the specified object, with the level specified as <see cref="DebugLevel"/>.
        /// </summary>
        /// <param name="obj">The obj to log.</param>
        public void Debug(object obj) => Log(obj.ToString(), DebugLevel);

        /// <summary>
        /// Logs the specified text, with level specified as <see cref="InformationLevel"/>.
        /// </summary>
        /// <param name="text">The text to log.</param>
        public void Information(string text) => Log(text, InformationLevel);

        /// <summary>
        /// Logs the specified exception, with the level specified as <see cref="InformationLevel"/>.
        /// </summary>
        /// <param name="ex">The exception to log.</param>
        public void Information(Exception ex) => Log(ex.ToString(), InformationLevel);

        /// <summary>
        /// Logs the specified object, with the level specified as <see cref="InformationLevel"/>.
        /// </summary>
        /// <param name="obj">The obj to log.</param>
        public void Information(object obj) => Log(obj.ToString(), InformationLevel);

        /// <summary>
        /// Logs the specified text, with level specified as <see cref="WarningLevel"/>.
        /// </summary>
        /// <param name="text">The text to log.</param>
        public void Warning(string text) => Log(text, WarningLevel);

        /// <summary>
        /// Logs the specified exception, with the level specified as <see cref="WarningLevel"/>.
        /// </summary>
        /// <param name="ex">The exception to log.</param>
        public void Warning(Exception ex) => Log(ex.ToString(), WarningLevel);

        /// <summary>
        /// Logs the specified object, with the level specified as <see cref="WarningLevel"/>.
        /// </summary>
        /// <param name="obj">The obj to log.</param>
        public void Warning(object obj) => Log(obj.ToString(), WarningLevel);

        /// <summary>
        /// Logs the specified text, with level specified as <see cref="ErrorLevel"/>.
        /// </summary>
        /// <param name="text">The text to log.</param>
        public void Error(string text) => Log(text, ErrorLevel);

        /// <summary>
        /// Logs the specified exception, with the level specified as <see cref="ErrorLevel"/>.
        /// </summary>
        /// <param name="ex">The exception to log.</param>
        public void Error(Exception ex) => Log(ex.ToString(), ErrorLevel);

        /// <summary>
        /// Logs the specified object, with the level specified as <see cref="ErrorLevel"/>.
        /// </summary>
        /// <param name="obj">The obj to log.</param>
        public void Error(object obj) => Log(obj.ToString(), ErrorLevel);

        /// <summary>
        /// Logs the specified text, with level specified as <see cref="FatalLevel"/>.
        /// </summary>
        /// <param name="text">The text to log.</param>
        public void Fatal(string text) => Log(text, FatalLevel);

        /// <summary>
        /// Logs the specified exception, with the level specified as <see cref="FatalLevel"/>.
        /// </summary>
        /// <param name="ex">The exception to log.</param>
        public void Fatal(Exception ex) => Log(ex.ToString(), FatalLevel);

        /// <summary>
        /// Logs the specified object, with the level specified as <see cref="FatalLevel"/>.
        /// </summary>
        /// <param name="obj">The obj to log.</param>
        public void Fatal(object obj) => Log(obj.ToString(), FatalLevel);
    }
}
