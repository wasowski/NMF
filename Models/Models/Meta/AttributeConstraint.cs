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
    /// The default implementation of the AttributeConstraint class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//AttributeConstraint")]
    public partial class AttributeConstraint : NMF.Models.ModelElement, NMF.Models.Meta.IAttributeConstraint, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the Values property
        /// </summary>
        private ObservableList<string> _values;
        
        private static Lazy<ITypedElement> _valuesAttribute = new Lazy<ITypedElement>(RetrieveValuesAttribute);
        
        private static Lazy<ITypedElement> _declaringTypeReference = new Lazy<ITypedElement>(RetrieveDeclaringTypeReference);
        
        private static Lazy<ITypedElement> _constrainsReference = new Lazy<ITypedElement>(RetrieveConstrainsReference);
        
        /// <summary>
        /// The backing field for the Constrains property
        /// </summary>
        private NMF.Models.Meta.IAttribute _constrains;
        
        private static IClass _classInstance;
        
        public AttributeConstraint()
        {
            this._values = new ObservableList<string>();
            this._values.CollectionChanging += this.ValuesCollectionChanging;
            this._values.CollectionChanged += this.ValuesCollectionChanged;
        }
        
        /// <summary>
        /// The Values property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public IListExpression<string> Values
        {
            get
            {
                return this._values;
            }
        }
        
        /// <summary>
        /// The DeclaringType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("AttributeConstraints")]
        public NMF.Models.Meta.IClass DeclaringType
        {
            get
            {
                return ModelHelper.CastAs<NMF.Models.Meta.IClass>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The Constrains property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public NMF.Models.Meta.IAttribute Constrains
        {
            get
            {
                return this._constrains;
            }
            set
            {
                if ((this._constrains != value))
                {
                    NMF.Models.Meta.IAttribute old = this._constrains;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConstrainsChanging(e);
                    this.OnPropertyChanging("Constrains", e, _constrainsReference);
                    this._constrains = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetConstrains;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetConstrains;
                    }
                    this.OnConstrainsChanged(e);
                    this.OnPropertyChanged("Constrains", e, _constrainsReference);
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
                return base.ReferencedElements.Concat(new AttributeConstraintReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//AttributeConstraint")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the DeclaringType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanging;
        
        /// <summary>
        /// Gets fired when the DeclaringType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanged;
        
        /// <summary>
        /// Gets fired before the Constrains property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConstrainsChanging;
        
        /// <summary>
        /// Gets fired when the Constrains property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConstrainsChanged;
        
        private static ITypedElement RetrieveValuesAttribute()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(AttributeConstraint.ClassInstance)).Resolve("Values")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Values property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ValuesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Values", e, _valuesAttribute);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Values property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ValuesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Values", e, _valuesAttribute);
        }
        
        private static ITypedElement RetrieveDeclaringTypeReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(AttributeConstraint.ClassInstance)).Resolve("DeclaringType")));
        }
        
        /// <summary>
        /// Raises the DeclaringTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeclaringTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeclaringTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            NMF.Models.Meta.IClass oldDeclaringType = ModelHelper.CastAs<NMF.Models.Meta.IClass>(oldParent);
            NMF.Models.Meta.IClass newDeclaringType = ModelHelper.CastAs<NMF.Models.Meta.IClass>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldDeclaringType, newDeclaringType);
            this.OnDeclaringTypeChanging(e);
            this.OnPropertyChanging("DeclaringType", e, _declaringTypeReference);
        }
        
        /// <summary>
        /// Raises the DeclaringTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeclaringTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeclaringTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            NMF.Models.Meta.IClass oldDeclaringType = ModelHelper.CastAs<NMF.Models.Meta.IClass>(oldParent);
            NMF.Models.Meta.IClass newDeclaringType = ModelHelper.CastAs<NMF.Models.Meta.IClass>(newParent);
            if ((oldDeclaringType != null))
            {
                oldDeclaringType.AttributeConstraints.Remove(this);
            }
            if ((newDeclaringType != null))
            {
                newDeclaringType.AttributeConstraints.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldDeclaringType, newDeclaringType);
            this.OnDeclaringTypeChanged(e);
            this.OnPropertyChanged("DeclaringType", e, _declaringTypeReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        private static ITypedElement RetrieveConstrainsReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(AttributeConstraint.ClassInstance)).Resolve("Constrains")));
        }
        
        /// <summary>
        /// Raises the ConstrainsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConstrainsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConstrainsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConstrainsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConstrainsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConstrainsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Constrains property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetConstrains(object sender, System.EventArgs eventArgs)
        {
            this.Constrains = null;
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "DECLARINGTYPE"))
            {
                return this.DeclaringType;
            }
            if ((reference == "CONSTRAINS"))
            {
                return this.Constrains;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "VALUES"))
            {
                if ((index < this.Values.Count))
                {
                    return this.Values[index];
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
            if ((feature == "VALUES"))
            {
                return this._values;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "DECLARINGTYPE"))
            {
                this.DeclaringType = ((NMF.Models.Meta.IClass)(value));
                return;
            }
            if ((feature == "CONSTRAINS"))
            {
                this.Constrains = ((NMF.Models.Meta.IAttribute)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "DECLARINGTYPE"))
            {
                return new DeclaringTypeProxy(this);
            }
            if ((reference == "CONSTRAINS"))
            {
                return new ConstrainsProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//AttributeConstraint")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AttributeConstraint class
        /// </summary>
        public class AttributeConstraintReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private AttributeConstraint _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AttributeConstraintReferencedElementsCollection(AttributeConstraint parent)
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
                    if ((this._parent.DeclaringType != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Constrains != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DeclaringTypeChanged += this.PropagateValueChanges;
                this._parent.ConstrainsChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DeclaringTypeChanged -= this.PropagateValueChanges;
                this._parent.ConstrainsChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.DeclaringType == null))
                {
                    NMF.Models.Meta.IClass declaringTypeCasted = item.As<NMF.Models.Meta.IClass>();
                    if ((declaringTypeCasted != null))
                    {
                        this._parent.DeclaringType = declaringTypeCasted;
                        return;
                    }
                }
                if ((this._parent.Constrains == null))
                {
                    NMF.Models.Meta.IAttribute constrainsCasted = item.As<NMF.Models.Meta.IAttribute>();
                    if ((constrainsCasted != null))
                    {
                        this._parent.Constrains = constrainsCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.DeclaringType = null;
                this._parent.Constrains = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.DeclaringType))
                {
                    return true;
                }
                if ((item == this._parent.Constrains))
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
                if ((this._parent.DeclaringType != null))
                {
                    array[arrayIndex] = this._parent.DeclaringType;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Constrains != null))
                {
                    array[arrayIndex] = this._parent.Constrains;
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
                if ((this._parent.DeclaringType == item))
                {
                    this._parent.DeclaringType = null;
                    return true;
                }
                if ((this._parent.Constrains == item))
                {
                    this._parent.Constrains = null;
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.DeclaringType).Concat(this._parent.Constrains).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the DeclaringType property
        /// </summary>
        private sealed class DeclaringTypeProxy : ModelPropertyChange<NMF.Models.Meta.IAttributeConstraint, NMF.Models.Meta.IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DeclaringTypeProxy(NMF.Models.Meta.IAttributeConstraint modelElement) : 
                    base(modelElement, "DeclaringType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IClass Value
            {
                get
                {
                    return this.ModelElement.DeclaringType;
                }
                set
                {
                    this.ModelElement.DeclaringType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Constrains property
        /// </summary>
        private sealed class ConstrainsProxy : ModelPropertyChange<NMF.Models.Meta.IAttributeConstraint, NMF.Models.Meta.IAttribute>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConstrainsProxy(NMF.Models.Meta.IAttributeConstraint modelElement) : 
                    base(modelElement, "Constrains")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IAttribute Value
            {
                get
                {
                    return this.ModelElement.Constrains;
                }
                set
                {
                    this.ModelElement.Constrains = value;
                }
            }
        }
    }
}

