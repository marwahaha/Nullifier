﻿using HGV.Nullifier;
using HGV.Nullifier.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HGV.Nullifier.Tools.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultLogger = new DefaultLogger();
            var cancellationSource = new CancellationTokenSource();

            Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) => { cancellationSource.Cancel(); };

            StatCollectionHandler.Run(cancellationSource.Token, defaultLogger);
        }
    }
}
