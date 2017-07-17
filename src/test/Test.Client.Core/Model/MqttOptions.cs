﻿using System;
using System.Collections.Generic;
using System.Text;
using IMQTTClientRx.Model;

namespace Test.Client.Core.Model
{
    internal class Options : TlsOptions, IClientOptions
    {
        public string Server { get; internal set; }
        public int? Port { get; internal set; }
        public string UserName { get; internal set; }
        public string Password { get; internal set; }
        public string ClientId { get; internal set; }
        public bool CleanSession { get; internal set; }
        public TimeSpan KeepAlivePeriod { get; internal set; }
        public TimeSpan DefaultCommunicationTimeout { get; internal set; }
    }
}