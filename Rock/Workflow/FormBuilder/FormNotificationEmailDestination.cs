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

using Rock.Attribute;

namespace Rock.Workflow.FormBuilder
{
    /// <summary>
    /// The possible destination options for a <see cref="FormNotificationEmailSettings"/>.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <strong>This is an internal API</strong> that supports the Rock
    ///         infrastructure and not subject to the same compatibility standards
    ///         as public APIs. It may be changed or removed without notice in any
    ///         release and should therefore not be directly used in any plug-ins.
    ///     </para>
    /// </remarks>
    [RockInternal]
    public enum FormNotificationEmailDestination
    {
        /// <summary>
        /// A specific individual in the database will be sent the notification
        /// e-mail.
        /// </summary>
        SpecificIndividual = 0,

        /// <summary>
        /// One or more raw e-mail addresses will be send the notification e-mail.
        /// </summary>
        EmailAddress = 1,

        /// <summary>
        /// A secondary lookup will be performed using <see cref="Rock.Model.CampusTopic"/>
        /// to determine the final recipient of the notification e-mail.
        /// </summary>
        CampusTopic = 2
    }
}
