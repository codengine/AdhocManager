using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using log4net;

namespace AdhocManager.Networking
{
    public enum CommandAlias
    {
        ConfigureHostedNetwork,
        StartHostedNetwork,
        StopHostedNetwork,
        ListWirelessDrivers,
        ListHostedNetworks,
        ListWirelessInterfaces
    }

    internal class Commands
    {
        private static readonly Dictionary<CommandAlias, string> commands = new Dictionary<CommandAlias, string>
        {
            {CommandAlias.ConfigureHostedNetwork, "netsh wlan set hostednetwork mode=allow ssid=\"{0}\" key=\"{1}\""},
            {CommandAlias.StartHostedNetwork, "netsh wlan start hostednetwork"},
            {CommandAlias.StopHostedNetwork, "netsh wlan stop hostednetwork"},
            {CommandAlias.ListWirelessDrivers, "netsh wlan show drivers"},
            {CommandAlias.ListHostedNetworks, "netsh wlan show hostednetwork"},
            {CommandAlias.ListWirelessInterfaces, "netsh wlan show interfaces"}
        };

        public static string Get(CommandAlias command)
        {
            if (!commands.ContainsKey(command))
            {
                throw new ArgumentException(string.Format("The command {0} does not exist", command));
            }
            return commands[command];
        }

        public static string Get(CommandAlias command, params object[] args)
        {
            if (!commands.ContainsKey(command))
            {
                throw new ArgumentException(string.Format("The command {0} does not exist", command));
            }
            return string.Format(commands[command], args);
        }
    }

    public class NetshManager
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public ProcessResult ConfigureHostedNetwork(string ssid = "", string password = "")
        {
            Logger.Info(string.Format("Setting up hosted network, SSID and password with parameters: {0}, {1}", ssid,
                password));
            return RunCommand(Commands.Get(CommandAlias.ConfigureHostedNetwork, ssid, password));
        }

        public ProcessResult StartHostedNetwork()
        {
            Logger.Info("Starting hosted network...");
            return RunCommand(CommandAlias.StartHostedNetwork);
        }

        public ProcessResult StopHostedNetwork()
        {
            Logger.Info("Stopping hosted network...");
            return RunCommand(CommandAlias.StopHostedNetwork);
        }

        public ProcessResult RunCommand(CommandAlias command)
        {
            return RunCommand(Commands.Get(command));
        }

        private static ProcessResult RunCommand(string command)
        {
            Logger.Debug(string.Format("Executing command {0}...", command));
            var procStartInfo = new ProcessStartInfo("cmd", "/c " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.GetEncoding(858)
            };

            try
            {
                using (var proc = new Process {StartInfo = procStartInfo})
                {
                    Logger.Debug("Process is starting...");
                    proc.Start();
                    var output = proc.StandardOutput.ReadToEnd();
                    Logger.Debug("Waiting for exit...");
                    proc.WaitForExit();
                    var result = new ProcessResult(proc, output);
                    LogResult(result);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Unable to run command {0}", command), ex);
                return ProcessResult.Of(ex);
            }
        }

        private static void LogResult(ProcessResult result)
        {
            if (!result.IsSuccessful())
            {
                Logger.Warn(string.Format("Result is unsuccessful - {0}", result.Print()));
            }
            else
            {
                Logger.Info("Result was OK");
            }
        }
    }
}