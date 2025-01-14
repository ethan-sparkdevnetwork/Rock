// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System.ComponentModel;
using Rock.Model;
using Rock.Web.UI;

namespace RockWeb.Blocks.Core
{
    /// <summary>
    /// Provides extensible options for searching in Rock.
    /// </summary>
    [DisplayName( "Smart Search" )]
    [Category( "Core" )]
    [Description( "Provides extensible options for searching in Rock." )]

    [Rock.SystemGuid.BlockTypeGuid( "9D406BD5-88C1-45E5-AFEA-70F9CFB66C74" )]
    public partial class SmartSearch : RockBlock
    {
    }
}