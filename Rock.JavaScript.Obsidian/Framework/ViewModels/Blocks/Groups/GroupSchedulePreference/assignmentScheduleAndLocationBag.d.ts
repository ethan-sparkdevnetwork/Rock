//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
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

import { Guid } from "@Obsidian/Types";
import { ListItemBag } from "@Obsidian/ViewModels/Utility/listItemBag";

/** Gets or sets a class representing data to pass cleanly into mobile. */
export type AssignmentScheduleAndLocationBag = {
    /** Gets or sets a guid representing the group member assignment ID. */
    groupMemberAssignmentGuid?: Guid | null;

    /** Gets or sets a list of schedule keys and values. */
    scheduleListItem?: ListItemBag | null;

    /** Gets or sets a list of location keys and values. */
    locationListItem?: ListItemBag | null;
};
