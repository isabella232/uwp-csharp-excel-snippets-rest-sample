﻿/*
 *  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
 *  See LICENSE in the source repository root for complete license information.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Windows.Data.Json;
using Windows.Storage.Streams;

namespace Office365Service
{
    public interface IRestApi
    {
        #region Constructor
        #endregion
        #region Properties
        RESTService Service { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Method { get; set; }
        string ResourceFormat { get; set; }
        string Resource { get; }
        string QueryParameters { get; set; }
        ObservableDictionary Headers { get; set; }
        ObservableDictionary BodyProperties { get; set; }
        JsonObject BodyAsJson { get; }
        string BodyAsText { get; }
        IRandomAccessStreamWithContentType FileStream { get; set; }
        Type ResultType { get; set; }
        Uri RequestUri { get; set; }
        #endregion
        #region Methods
        Task<object> InvokeAsync();
        #endregion
    }
}