﻿using System;
using System.Collections.Generic;

namespace FFImageLoading
{
    [Preserve(AllMembers = true)]
    public class DownloadAggregateException : AggregateException
    {
        public DownloadAggregateException()
        {
        }

        public DownloadAggregateException(IEnumerable<Exception> exceptions) : base(exceptions)
        {
        }
    }
}
