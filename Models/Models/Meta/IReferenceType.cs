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
    /// The public interface for ReferenceType
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ReferenceType))]
    [XmlDefaultImplementationTypeAttribute(typeof(ReferenceType))]
    public interface IReferenceType : NMF.Models.IModelElement, NMF.Models.Meta.IStructuredType
    {
        
        /// <summary>
        /// The Events property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("DeclaringType")]
        [ConstantAttribute()]
        ICollectionExpression<NMF.Models.Meta.IEvent> Events
        {
            get;
        }
        
        /// <summary>
        /// The References property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("DeclaringType")]
        [ConstantAttribute()]
        ICollectionExpression<NMF.Models.Meta.IReference> References
        {
            get;
        }
    }
}

