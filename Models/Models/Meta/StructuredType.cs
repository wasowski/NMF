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
    /// The default implementation of the StructuredType class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//StructuredType")]
    [DebuggerDisplayAttribute("StructuredType {Name}")]
    public abstract partial class StructuredType : Type, NMF.Models.Meta.IStructuredType, NMF.Models.IModelElement
    {
        
        private static Lazy<ITypedElement> _operationsReference = new Lazy<ITypedElement>(RetrieveOperationsReference);
        
        /// <summary>
        /// The backing field for the Operations property
        /// </summary>
        private StructuredTypeOperationsCollection _operations;
        
        private static Lazy<ITypedElement> _attributesReference = new Lazy<ITypedElement>(RetrieveAttributesReference);
        
        /// <summary>
        /// The backing field for the Attributes property
        /// </summary>
        private StructuredTypeAttributesCollection _attributes;
        
        private static IClass _classInstance;
        
        public StructuredType()
        {
            this._operations = new StructuredTypeOperationsCollection(this);
            this._operations.CollectionChanging += this.OperationsCollectionChanging;
            this._operations.CollectionChanged += this.OperationsCollectionChanged;
            this._attributes = new StructuredTypeAttributesCollection(this);
            this._attributes.CollectionChanging += this.AttributesCollectionChanging;
            this._attributes.CollectionChanged += this.AttributesCollectionChanged;
        }
        
        /// <summary>
        /// The Operations property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("DeclaringType")]
        [ConstantAttribute()]
        public ICollectionExpression<NMF.Models.Meta.IOperation> Operations
        {
            get
            {
                return this._operations;
            }
        }
        
        /// <summary>
        /// The Attributes property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("DeclaringType")]
        [ConstantAttribute()]
        public ICollectionExpression<NMF.Models.Meta.IAttribute> Attributes
        {
            get
            {
                return this._attributes;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new StructuredTypeChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new StructuredTypeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//StructuredType")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveOperationsReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(StructuredType.ClassInstance)).Resolve("Operations")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Operations property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OperationsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Operations", e, _operationsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Operations property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OperationsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Operations", e, _operationsReference);
        }
        
        private static ITypedElement RetrieveAttributesReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(StructuredType.ClassInstance)).Resolve("Attributes")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Attributes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AttributesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Attributes", e, _attributesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Attributes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AttributesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Attributes", e, _attributesReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "OPERATIONS"))
            {
                return this._operations;
            }
            if ((feature == "ATTRIBUTES"))
            {
                return this._attributes;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected internal override string GetCompositionName(object container)
        {
            if ((container == this._operations))
            {
                return "Operations";
            }
            if ((container == this._attributes))
            {
                return "Attributes";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//StructuredType")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the StructuredType class
        /// </summary>
        public class StructuredTypeChildrenCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private StructuredType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public StructuredTypeChildrenCollection(StructuredType parent)
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
                    count = (count + this._parent.Operations.Count);
                    count = (count + this._parent.Attributes.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Operations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Attributes.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Operations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Attributes.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                NMF.Models.Meta.IOperation operationsCasted = item.As<NMF.Models.Meta.IOperation>();
                if ((operationsCasted != null))
                {
                    this._parent.Operations.Add(operationsCasted);
                }
                NMF.Models.Meta.IAttribute attributesCasted = item.As<NMF.Models.Meta.IAttribute>();
                if ((attributesCasted != null))
                {
                    this._parent.Attributes.Add(attributesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Operations.Clear();
                this._parent.Attributes.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if (this._parent.Operations.Contains(item))
                {
                    return true;
                }
                if (this._parent.Attributes.Contains(item))
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
                IEnumerator<NMF.Models.IModelElement> operationsEnumerator = this._parent.Operations.GetEnumerator();
                try
                {
                    for (
                    ; operationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = operationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    operationsEnumerator.Dispose();
                }
                IEnumerator<NMF.Models.IModelElement> attributesEnumerator = this._parent.Attributes.GetEnumerator();
                try
                {
                    for (
                    ; attributesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = attributesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    attributesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                NMF.Models.Meta.IOperation operationItem = item.As<NMF.Models.Meta.IOperation>();
                if (((operationItem != null) 
                            && this._parent.Operations.Remove(operationItem)))
                {
                    return true;
                }
                NMF.Models.Meta.IAttribute attributeItem = item.As<NMF.Models.Meta.IAttribute>();
                if (((attributeItem != null) 
                            && this._parent.Attributes.Remove(attributeItem)))
                {
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Operations).Concat(this._parent.Attributes).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the StructuredType class
        /// </summary>
        public class StructuredTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private StructuredType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public StructuredTypeReferencedElementsCollection(StructuredType parent)
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
                    count = (count + this._parent.Operations.Count);
                    count = (count + this._parent.Attributes.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Operations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Attributes.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Operations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Attributes.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                NMF.Models.Meta.IOperation operationsCasted = item.As<NMF.Models.Meta.IOperation>();
                if ((operationsCasted != null))
                {
                    this._parent.Operations.Add(operationsCasted);
                }
                NMF.Models.Meta.IAttribute attributesCasted = item.As<NMF.Models.Meta.IAttribute>();
                if ((attributesCasted != null))
                {
                    this._parent.Attributes.Add(attributesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Operations.Clear();
                this._parent.Attributes.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if (this._parent.Operations.Contains(item))
                {
                    return true;
                }
                if (this._parent.Attributes.Contains(item))
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
                IEnumerator<NMF.Models.IModelElement> operationsEnumerator = this._parent.Operations.GetEnumerator();
                try
                {
                    for (
                    ; operationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = operationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    operationsEnumerator.Dispose();
                }
                IEnumerator<NMF.Models.IModelElement> attributesEnumerator = this._parent.Attributes.GetEnumerator();
                try
                {
                    for (
                    ; attributesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = attributesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    attributesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                NMF.Models.Meta.IOperation operationItem = item.As<NMF.Models.Meta.IOperation>();
                if (((operationItem != null) 
                            && this._parent.Operations.Remove(operationItem)))
                {
                    return true;
                }
                NMF.Models.Meta.IAttribute attributeItem = item.As<NMF.Models.Meta.IAttribute>();
                if (((attributeItem != null) 
                            && this._parent.Attributes.Remove(attributeItem)))
                {
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Operations).Concat(this._parent.Attributes).GetEnumerator();
            }
        }
    }
}

