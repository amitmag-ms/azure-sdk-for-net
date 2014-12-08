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
using System.Linq;
using Microsoft.Azure.Management.StreamAnalytics.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The response of the input CreateOrUpdate operation.
    /// </summary>
    public partial class InputCreateOrUpdateResponse : OperationResponse
    {
        private DateTime _date;
        
        /// <summary>
        /// Optional. Gets a UTC date/time value generated by the service that
        /// indicates the time at which the response was initiated.
        /// </summary>
        public DateTime Date
        {
            get { return this._date; }
            set { this._date = value; }
        }
        
        private Input _input;
        
        /// <summary>
        /// Optional. Gets or sets the input response content.
        /// </summary>
        public Input Input
        {
            get { return this._input; }
            set { this._input = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the InputCreateOrUpdateResponse class.
        /// </summary>
        public InputCreateOrUpdateResponse()
        {
        }
    }
}
