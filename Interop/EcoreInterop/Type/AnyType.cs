//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Interop.Ecore;
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

namespace NMF.Interop.Type
{
    
    
    /// <summary>
    /// The default implementation of the AnyType class
    /// </summary>
    [XmlNamespaceAttribute("http://www.eclipse.org/emf/2003/XMLType")]
    [XmlNamespacePrefixAttribute("ecore.xml.type")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/emf/2003/XMLType#//AnyType")]
    public partial class AnyType : ModelElement, IAnyType, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Mixed property
        /// </summary>
        private ObservableList<object> _mixed;
        
        private static Lazy<ITypedElement> _mixedAttribute = new Lazy<ITypedElement>(RetrieveMixedAttribute);
        
        /// <summary>
        /// The backing field for the AnyAttribute property
        /// </summary>
        private ObservableList<object> _anyAttribute;
        
        private static Lazy<ITypedElement> _anyAttributeAttribute = new Lazy<ITypedElement>(RetrieveAnyAttributeAttribute);
        
        private static IClass _classInstance;
        
        public AnyType()
        {
            this._mixed = new ObservableList<object>();
            this._mixed.CollectionChanging += this.MixedCollectionChanging;
            this._mixed.CollectionChanged += this.MixedCollectionChanged;
            this._anyAttribute = new ObservableList<object>();
            this._anyAttribute.CollectionChanging += this.AnyAttributeCollectionChanging;
            this._anyAttribute.CollectionChanged += this.AnyAttributeCollectionChanged;
        }
        
        /// <summary>
        /// The mixed property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("mixed")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public IListExpression<object> Mixed
        {
            get
            {
                return this._mixed;
            }
        }
        
        /// <summary>
        /// The anyAttribute property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("anyAttribute")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public IListExpression<object> AnyAttribute
        {
            get
            {
                return this._anyAttribute;
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/emf/2003/XMLType#//AnyType")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveMixedAttribute()
        {
            return ((ITypedElement)(((ModelElement)(AnyType.ClassInstance)).Resolve("mixed")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Mixed property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MixedCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Mixed", e, _mixedAttribute);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Mixed property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MixedCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Mixed", e, _mixedAttribute);
        }
        
        private static ITypedElement RetrieveAnyAttributeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(AnyType.ClassInstance)).Resolve("anyAttribute")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AnyAttribute property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AnyAttributeCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("AnyAttribute", e, _anyAttributeAttribute);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AnyAttribute property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AnyAttributeCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AnyAttribute", e, _anyAttributeAttribute);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "MIXED"))
            {
                if ((index < this.Mixed.Count))
                {
                    return this.Mixed[index];
                }
                else
                {
                    return null;
                }
            }
            if ((attribute == "ANYATTRIBUTE"))
            {
                if ((index < this.AnyAttribute.Count))
                {
                    return this.AnyAttribute[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "MIXED"))
            {
                return this._mixed;
            }
            if ((feature == "ANYATTRIBUTE"))
            {
                return this._anyAttribute;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/emf/2003/XMLType#//AnyType")));
            }
            return _classInstance;
        }
    }
}

