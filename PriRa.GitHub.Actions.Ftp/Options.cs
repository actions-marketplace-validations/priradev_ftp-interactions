﻿using System;
using CommandLine;

namespace PriRa.GitHub.Actions.Ftp
{
        public class Options
        {
                public Options()
                {
                        Server = string.Empty;
                        Port = 21;
                        Username = string.Empty;
                        Password = string.Empty;
                        SourcePath = string.Empty;
                        DestinationPath = string.Empty;
                        SkipDirectories = string.Empty;
                }

                // Connection.

                [Option("server",
                        Required = true,
                        HelpText = "Address for the destination server.")]
                public string Server { get; set; }

                [Option("port",
                        Required = false, Default = 21,
                        HelpText = "Port for the destination server.")]
                public int Port { get; set; }

                [Option("username",
                        Required = true,
                        HelpText = "Username for the destination server.")]
                public string Username { get; set; }

                [Option("password",
                        Required = true,
                        HelpText = "Password for the destination server.")]
                public string Password { get; set; }

                // Data.

                [Option("source",
                        Required = false, Default = "/",
                        HelpText = "Directory in source from which to upload.")]
                public string SourcePath { get; set; }

                [Option("destination",
                        Required = false, Default = "/",
                        HelpText = "Directory in destination to which to upload.")]
                public string DestinationPath { get; set; }

                // Options.

                [Option("deleteFileAppOfflineHtm",
                        Required = false, Default = false,
                        HelpText = "Delete app_offline.htm from server")]
                public bool DeleteFileAppOfflineHtm { get; set; }

                [Option("ignoreCertificateErrors",
                        Required = false, Default = false,
                        HelpText = "Ignore certificate errors.")]
                public bool IgnoreCertificateErrors { get; set; }

                [Option("skipUnchanged",
                        Required = false, Default = false,
                        HelpText = "Only upload files that have changed.")]
                public bool? SkipUnchanged { get; set; }

                [Option("skipDirectories",
                        Required = false, Default = ".github|.well-known",
                        HelpText =
                                "Folders to be ignored in both source and destination, separated by a pipe (|) character.")]
                public string SkipDirectories { get; set; }

                [Option("test",
                        Required = false, Default = false,
                        HelpText = "Do not perform file deletions or uploads; just output intended actions.")]
                public bool? TestOnly { get; set; }

        }
}