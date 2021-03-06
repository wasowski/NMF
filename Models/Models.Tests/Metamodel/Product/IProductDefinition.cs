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

namespace NMF.Models.Tests.Minimal_example.Product
{
    
    
    /// <summary>
    /// The public interface for ProductDefinition
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ProductDefinition))]
    [XmlDefaultImplementationTypeAttribute(typeof(ProductDefinition))]
    [ModelRepresentationClassAttribute("http://www.example.org/minimal_example#//product/ProductDefinition")]
    public interface IProductDefinition : IModelElement
    {
        
        /// <summary>
        /// The ID property
        /// </summary>
        [CategoryAttribute("ProductDefinition")]
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        string ID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The productsegments property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("productsegments")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        IOrderedSetExpression<IProductSegment> Productsegments
        {
            get;
        }
        
        /// <summary>
        /// The workpiecetypes property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("workpiecetypes")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        IOrderedSetExpression<IWorkpieceType> Workpiecetypes
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the ID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IDChanging;
        
        /// <summary>
        /// Gets fired when the ID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IDChanged;
    }
}

