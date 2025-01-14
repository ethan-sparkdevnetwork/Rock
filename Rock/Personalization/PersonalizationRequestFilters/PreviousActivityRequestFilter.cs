﻿// <copyright>
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
using System;
using System.Linq;
using System.Web;

namespace Rock.Personalization
{
    /// <summary>
    /// Class PreviousActivityRequestFilter.
    /// Implements the <see cref="Rock.Personalization.PersonalizationRequestFilter" />
    /// </summary>
    /// <seealso cref="Rock.Personalization.PersonalizationRequestFilter" />
    public class PreviousActivityRequestFilter : PersonalizationRequestFilter
    {
        #region Configuration

        /// <summary>
        /// Gets or sets the previous activity types.
        /// </summary>
        /// <value>The previous activity types.</value>
        public PreviousActivityType[] PreviousActivityTypes { get; set; } = new PreviousActivityType[0];

        #endregion Configuration

        /// <summary>
        /// Determines whether the specified HTTP request meets the criteria of this filter.
        /// </summary>
        /// <param name="httpRequest">The HTTP request.</param>
        /// <returns><c>true</c> if the specified HTTP request is match; otherwise, <c>false</c>.</returns>
        public override bool IsMatch( HttpRequest httpRequest )
        {
            if ( PreviousActivityTypes.Length == 0 || PreviousActivityTypes.Length == 2 )
            {
                // If nothing is selected, return true.
                // If both are selected, we can also return true because a previous activity can only be New or Returning.
                return true;
            }

            var firstTimeVisitorCookie = httpRequest.Cookies.Get( Rock.Personalization.RequestCookieKey.ROCK_FIRSTTIME_VISITOR );

            // Only count them as a First Time visitor if we know for sure they are. Which means the cookie has to exist and
            // have a value of True.
            var isFirstTimeVisitor = firstTimeVisitorCookie != null && firstTimeVisitorCookie.Value.AsBoolean();

            if ( isFirstTimeVisitor )
            {
                return PreviousActivityTypes.Contains( PreviousActivityType.New );
            }
            else
            {
                return PreviousActivityTypes.Contains( PreviousActivityType.Return );
            }
        }

        /// <summary>
        /// Options on whether filter on New or Returning visitor
        /// </summary>
        public enum PreviousActivityType
        {
            /// <summary>
            /// The new
            /// </summary>
            New = 0,

            /// <summary>
            /// The returning
            /// </summary>
            Return = 1
        }
    }
}
