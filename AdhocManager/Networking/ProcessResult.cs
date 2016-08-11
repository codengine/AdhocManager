using System;
using System.Diagnostics;

namespace AdhocManager.Networking
{
    public class ProcessResult
    {
        public ProcessResult(Process process, string output)
        {
            Output = output;
            ExitCode = process.ExitCode;
        }

        private ProcessResult(string output)
        {
            Output = output;
            ExitCode = -1;
        }

        public int ExitCode { get; private set; }
        public string Output { get; private set; }

        public static ProcessResult Of(Exception ex)
        {
            return new ProcessResult(ex.Message);
        }

        public bool IsSuccessful()
        {
            return ExitCode == 0;
        }

        public override string ToString()
        {
            return string.Format("Exit Code: {0}, Output: {1}", ExitCode, Output);
        }

        public string Print()
        {
            return ToString();
        }
    }
}