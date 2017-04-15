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

namespace NMF.Models.Changes
{
    
    
    /// <summary>
    /// The default implementation of the ElementaryChange class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/changes")]
    [XmlNamespacePrefixAttribute("changes")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/changes#//ElementaryChange")]
    public abstract partial class ElementaryChange : ModelChange, IElementaryChange, NMF.Models.IModelElement
    {
        
        private static Lazy<ITypedElement> _affectedElementReference = new Lazy<ITypedElement>(RetrieveAffectedElementReference);
        
        /// <summary>
        /// The backing field for the AffectedElement property
        /// </summary>
        private NMF.Models.IModelElement _affectedElement;
        
        private static Lazy<ITypedElement> _featureReference = new Lazy<ITypedElement>(RetrieveFeatureReference);
        
        /// <summary>
        /// The backing field for the Feature property
        /// </summary>
        private ITypedElement _feature;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The affectedElement property
        /// </summary>
        [XmlElementNameAttribute("affectedElement")]
        [XmlAttributeAttribute(true)]
        public NMF.Models.IModelElement AffectedElement
        {
            get
            {
                return this._affectedElement;
            }
            set
            {
                if ((this._affectedElement != value))
                {
                    NMF.Models.IModelElement old = this._affectedElement;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAffectedElementChanging(e);
                    this.OnPropertyChanging("AffectedElement", e, _affectedElementReference);
                    this._affectedElement = value;
                    this.OnAffectedElementChanged(e);
                    this.OnPropertyChanged("AffectedElement", e, _affectedElementReference);
                }
            }
        }
        
        /// <summary>
        /// The feature property
        /// </summary>
        [XmlElementNameAttribute("feature")]
        [XmlAttributeAttribute(true)]
        public ITypedElement Feature
        {
            get
            {
                return this._feature;
            }
            set
            {
                if ((this._feature != value))
                {
                    ITypedElement old = this._feature;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFeatureChanging(e);
                    this.OnPropertyChanging("Feature", e, _featureReference);
                    this._feature = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetFeature;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetFeature;
                    }
                    this.OnFeatureChanged(e);
                    this.OnPropertyChanged("Feature", e, _featureReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ElementaryChangeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//ElementaryChange")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the AffectedElement property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AffectedElementChanging;
        
        /// <summary>
        /// Gets fired when the AffectedElement property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AffectedElementChanged;
        
        /// <summary>
        /// Gets fired before the Feature property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FeatureChanging;
        
        /// <summary>
        /// Gets fired when the Feature property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FeatureChanged;
        
        private static ITypedElement RetrieveAffectedElementReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.Changes.ElementaryChange.ClassInstance)).Resolve("affectedElement")));
        }
        
        /// <summary>
        /// Raises the AffectedElementChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAffectedElementChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AffectedElementChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AffectedElementChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAffectedElementChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AffectedElementChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AffectedElement property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAffectedElement(object sender, System.EventArgs eventArgs)
        {
            this.AffectedElement = null;
        }
        
        private static ITypedElement RetrieveFeatureReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.Changes.ElementaryChange.ClassInstance)).Resolve("feature")));
        }
        
        /// <summary>
        /// Raises the FeatureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFeatureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FeatureChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FeatureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFeatureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FeatureChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Feature property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetFeature(object sender, System.EventArgs eventArgs)
        {
            this.Feature = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "AFFECTEDELEMENT"))
            {
                this.AffectedElement = ((NMF.Models.IModelElement)(value));
                return;
            }
            if ((feature == "FEATURE"))
            {
                this.Feature = ((ITypedElement)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "AffectedElement"))
            {
                return new AffectedElementProxy(this);
            }
            if ((attribute == "Feature"))
            {
                return new FeatureProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "AffectedElement"))
            {
                return new AffectedElementProxy(this);
            }
            if ((reference == "Feature"))
            {
                return new FeatureProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//ElementaryChange")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ElementaryChange class
        /// </summary>
        public class ElementaryChangeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private ElementaryChange _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ElementaryChangeReferencedElementsCollection(ElementaryChange parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.AffectedElement != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Feature != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AffectedElementChanged += this.PropagateValueChanges;
                this._parent.FeatureChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AffectedElementChanged -= this.PropagateValueChanges;
                this._parent.FeatureChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.AffectedElement == null))
                {
                    this._parent.AffectedElement = item;
                    return;
                }
                if ((this._parent.Feature == null))
                {
                    ITypedElement featureCasted = item.As<ITypedElement>();
                    if ((featureCasted != null))
                    {
                        this._parent.Feature = featureCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AffectedElement = null;
                this._parent.Feature = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.AffectedElement))
                {
                    return true;
                }
                if ((item == this._parent.Feature))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.AffectedElement != null))
                {
                    array[arrayIndex] = this._parent.AffectedElement;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Feature != null))
                {
                    array[arrayIndex] = this._parent.Feature;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                if ((this._parent.AffectedElement == item))
                {
                    this._parent.AffectedElement = null;
                    return true;
                }
                if ((this._parent.Feature == item))
                {
                    this._parent.Feature = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.AffectedElement).Concat(this._parent.Feature).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the affectedElement property
        /// </summary>
        private sealed class AffectedElementProxy : ModelPropertyChange<IElementaryChange, NMF.Models.IModelElement>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AffectedElementProxy(IElementaryChange modelElement) : 
                    base(modelElement, "affectedElement")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.IModelElement Value
            {
                get
                {
                    return this.ModelElement.AffectedElement;
                }
                set
                {
                    this.ModelElement.AffectedElement = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the feature property
        /// </summary>
        private sealed class FeatureProxy : ModelPropertyChange<IElementaryChange, ITypedElement>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FeatureProxy(IElementaryChange modelElement) : 
                    base(modelElement, "feature")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITypedElement Value
            {
                get
                {
                    return this.ModelElement.Feature;
                }
                set
                {
                    this.ModelElement.Feature = value;
                }
            }
        }
    }
}

