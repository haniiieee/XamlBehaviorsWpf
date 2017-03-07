// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 
namespace Microsoft.Xaml.Interactions.Core
{
    using System.Windows;
    using Microsoft.Xaml.Interactivity;

    /// <summary>
    /// An action that will change the value of a property from a data store object.
    /// This class is identical to ChangePropertyAction. The only difference is that the data store picker is loaded 
    /// for this action.
    /// </summary>
    [DefaultTrigger(typeof(UIElement), typeof(Interactivity.EventTrigger), "Loaded")]
    public class SetDataStoreValueAction : ChangePropertyAction
    {
    }
}