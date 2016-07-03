using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace SublimeLogger
{
    public class LoggerImpl : Logger
    {
        private int m_errorCount;
        private string m_projectDirectory;
        private int m_warningCount;

        public override void Initialize(IEventSource eventSource)
        {
            Debug.Assert(eventSource != null, "eventSource != null");
            eventSource.ProjectStarted += HandleProjectStarted;
            eventSource.BuildFinished += HandleBuildFinished;
            eventSource.ErrorRaised += HandleErrorRaised;
            eventSource.WarningRaised += HandleWarningRaised;
            m_errorCount = 0;
            m_warningCount = 0;
        }

        private void HandleProjectStarted(object sender, ProjectStartedEventArgs e)
        {
            m_projectDirectory = Path.GetDirectoryName(e.ProjectFile);
        }

        private void HandleBuildFinished(object sender, BuildFinishedEventArgs e)
        {
            if (e.Succeeded)
            {
                Console.WriteLine("Build succeeded. Warnings:{0}", m_warningCount);
            }
            else
            {
                Console.WriteLine("Build failed. Errors:{0} Warnings:{1}", m_errorCount, m_warningCount);
            }
        }

        private void HandleErrorRaised(object sender, BuildErrorEventArgs e)
        {
            var fullPath = m_projectDirectory != null ? Path.Combine(m_projectDirectory, e.File) : e.File;
            Console.WriteLine("{0}:{1}:{2}: Error: {3}", fullPath, e.LineNumber, e.ColumnNumber, e.Message);
            m_errorCount++;
        }

        private void HandleWarningRaised(object sender, BuildWarningEventArgs e)
        {
            var fullPath = m_projectDirectory != null ? Path.Combine(m_projectDirectory, e.File) : e.File;
            if (e.Code != null)
            {
                Console.WriteLine("{0}:{1}:{2}: Warning: {3}", fullPath, e.LineNumber, e.ColumnNumber, e.Message);
                m_warningCount++;
            }
        }
    }
}
