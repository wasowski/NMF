//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The public interface for TypedElement
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(TypedElement))]
    [XmlDefaultImplementationTypeAttribute(typeof(TypedElement))]
    public interface ITypedElement : NMF.Models.IModelElement, NMF.Models.Meta.IMetaElement
    {
        
        /// <summary>
        /// The IsOrdered property
        /// </summary>
        [XmlAttributeAttribute(true)]
        bool IsOrdered
        {
            get;
            set;
        }
        
        /// <summary>
        /// The IsUnique property
        /// </summary>
        [XmlAttributeAttribute(true)]
        bool IsUnique
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LowerBound property
        /// </summary>
        [DefaultValueAttribute(0)]
        [XmlAttributeAttribute(true)]
        int LowerBound
        {
            get;
            set;
        }
        
        /// <summary>
        /// The UpperBound property
        /// </summary>
        [DefaultValueAttribute(1)]
        [XmlAttributeAttribute(true)]
        int UpperBound
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Type property
        /// </summary>
        [XmlAttributeAttribute(true)]
        NMF.Models.Meta.IType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the IsOrdered property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsOrderedChanging;
        
        /// <summary>
        /// Gets fired when the IsOrdered property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsOrderedChanged;
        
        /// <summary>
        /// Gets fired before the IsUnique property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsUniqueChanging;
        
        /// <summary>
        /// Gets fired when the IsUnique property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsUniqueChanged;
        
        /// <summary>
        /// Gets fired before the LowerBound property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowerBoundChanging;
        
        /// <summary>
        /// Gets fired when the LowerBound property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowerBoundChanged;
        
        /// <summary>
        /// Gets fired before the UpperBound property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UpperBoundChanging;
        
        /// <summary>
        /// Gets fired when the UpperBound property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UpperBoundChanged;
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
    }
}

