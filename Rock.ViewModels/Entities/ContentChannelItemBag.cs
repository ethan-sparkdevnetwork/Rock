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

using System;
using System.Linq;

using Rock.ViewModels.Utility;

namespace Rock.ViewModels.Entities
{
    /// <summary>
    /// ContentChannelItem View Model
    /// </summary>
    public partial class ContentChannelItemBag : EntityBagBase
    {
        /// <summary>
        /// Gets or sets the PersonAliasId of the Rock.Model.Person who either approved or declined the ContentItem. If no approval action has been performed on this item, this value will be null.
        /// </summary>
        /// <value>
        /// A System.Int32 representing the PersonAliasId of the Rock.Model.Person who either approved or declined the ContentItem. This value will be null if no approval action has been
        /// performed on this add.
        /// </value>
        public int? ApprovedByPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the approved date.
        /// </summary>
        /// <value>
        /// The approved date.
        /// </value>
        public DateTime? ApprovedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the content channel identifier.
        /// </summary>
        /// <value>
        /// The content channel identifier.
        /// </value>
        public int ContentChannelId { get; set; }

        /// <summary>
        /// Gets or sets the content channel type identifier.
        /// </summary>
        /// <value>
        /// The content channel type identifier.
        /// </value>
        public int ContentChannelTypeId { get; set; }

        /// <summary>
        /// Gets or sets the expire date time.
        /// </summary>
        /// <value>
        /// The expire date time.
        /// </value>
        public DateTime? ExpireDateTime { get; set; }

        /// <summary>
        /// Gets or sets the item global key.
        /// </summary>
        /// <value>
        /// The item global key.
        /// </value>
        public string ItemGlobalKey { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the permalink.
        /// </summary>
        /// <value>
        /// The permalink.
        /// </value>
        public string Permalink { get; set; }

        /// <summary>
        /// Gets or sets the priority of this ContentItem. The lower the number, the higher the priority.
        /// </summary>
        /// <value>
        /// A System.Int32 representing the priority of this ContentItem. The lower the number, the higher the priority of the Ad.
        /// </value>
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets the start date time.
        /// </summary>
        /// <value>
        /// The start date time.
        /// </value>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets the Rock.Model.ContentChannelItemStatus (status) of this ContentItem.
        /// </summary>
        /// <value>
        /// A Rock.Model.ContentChannelItemStatus enumeration value that represents the status of this ContentItem. When ContentItemStatus.PendingApproval the item is 
        /// awaiting approval; when ContentItemStatus.Approved the item has been approved by the approver, when ContentItemStatus.Denied the item has been denied by the approver.
        /// </value>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the structured content.
        /// </summary>
        /// <value>
        /// The structured content.
        /// </value>
        public string StructuredContent { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        /// <value>
        /// The created date time.
        /// </value>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the modified date time.
        /// </summary>
        /// <value>
        /// The modified date time.
        /// </value>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the created by person alias identifier.
        /// </summary>
        /// <value>
        /// The created by person alias identifier.
        /// </value>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the modified by person alias identifier.
        /// </summary>
        /// <value>
        /// The modified by person alias identifier.
        /// </value>
        public int? ModifiedByPersonAliasId { get; set; }

    }
}
