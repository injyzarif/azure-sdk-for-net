// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The list hub operation response.
    /// </summary>
    public partial class HubListResponse : OperationResponse
    {
        private IList<Hub> _hubs;
        
        /// <summary>
        /// Optional. A list of the returned hub instances.
        /// </summary>
        public IList<Hub> Hubs
        {
            get { return this._hubs; }
            set { this._hubs = value; }
        }
        
        private string _nextLink;
        
        /// <summary>
        /// Required. The link (url) to the next page of results.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HubListResponse class.
        /// </summary>
        public HubListResponse()
        {
            this.Hubs = new LazyList<Hub>();
        }
        
        /// <summary>
        /// Initializes a new instance of the HubListResponse class with
        /// required arguments.
        /// </summary>
        public HubListResponse(string nextLink)
            : this()
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException("nextLink");
            }
            this.NextLink = nextLink;
        }
    }
}
